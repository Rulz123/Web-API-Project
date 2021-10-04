using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Obligatorisk_opgave_API_MVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Obligatorisk_opgave_API_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                string constr = "Server=LAPTOP-EDR90JDB;Database=Cheapshark;Trusted_Connection=True;MultipleActiveResultSets=True";

                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                string json = new WebClient().DownloadString("https://www.cheapshark.com/api/1.0/deals?storeID=1&upperPrice=15");
                DataTable dt = JsonConvert.DeserializeObject<DataTable>(json);
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    string sql = "TRUNCATE TABLE Game;";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        
                        cmd.ExecuteNonQuery();
                    }


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {


                        sql = "INSERT INTO Game VALUES(@internalName, @title, @metacriticlink, @dealID, @storeID, @gameID, @salePrice, @normalPrice, @isOnSale, @savings," +
                            " @metacriticscore, @steamRatingText, @steamRatingPercent, @steamRatingCount, @steamAppID, @releaseDate, @lastChange, @dealRating, @thumb)";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@internalName", dt.Rows[i]["internalName"].ToString());
                            cmd.Parameters.AddWithValue("@title", dt.Rows[i]["title"].ToString());
                            cmd.Parameters.AddWithValue("@metacriticlink", dt.Rows[i]["metacriticlink"].ToString());
                            cmd.Parameters.AddWithValue("@dealID", dt.Rows[i]["dealID"].ToString());
                            cmd.Parameters.AddWithValue("@storeID", dt.Rows[i]["storeID"].ToString());
                            cmd.Parameters.AddWithValue("@gameID", dt.Rows[i]["gameID"].ToString());
                            cmd.Parameters.AddWithValue("@salePrice", dt.Rows[i]["salePrice"].ToString());
                            cmd.Parameters.AddWithValue("@normalPrice", dt.Rows[i]["normalPrice"].ToString());
                            cmd.Parameters.AddWithValue("@isOnSale", dt.Rows[i]["isOnSale"].ToString());
                            cmd.Parameters.AddWithValue("@savings", dt.Rows[i]["savings"].ToString());
                            cmd.Parameters.AddWithValue("@metacriticscore", dt.Rows[i]["metacriticscore"].ToString());
                            cmd.Parameters.AddWithValue("@steamRatingText", dt.Rows[i]["steamRatingText"].ToString());
                            cmd.Parameters.AddWithValue("@steamRatingPercent", dt.Rows[i]["steamRatingPercent"].ToString());
                            cmd.Parameters.AddWithValue("@steamRatingCount", dt.Rows[i]["steamRatingCount"].ToString());
                            cmd.Parameters.AddWithValue("@steamAppID", dt.Rows[i]["steamAppID"].ToString());
                            cmd.Parameters.AddWithValue("@releaseDate", dt.Rows[i]["releaseDate"].ToString());
                            cmd.Parameters.AddWithValue("@lastChange", dt.Rows[i]["lastChange"].ToString());
                            cmd.Parameters.AddWithValue("@dealRating", dt.Rows[i]["dealRating"].ToString());
                            cmd.Parameters.AddWithValue("@thumb", dt.Rows[i]["thumb"].ToString());


                            cmd.ExecuteNonQuery();

                        }
                    }
                    conn.Close();
                   
                }
              

                //try
                //{
                //    SeedData.Initialize();
                //}
                //catch (Exception ex)
                //{
                //    var logger = services.GetRequiredService<ILogger<Program>>();
                //    logger.LogError(ex, "An error occurred seeding the DB.");
                //}
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
