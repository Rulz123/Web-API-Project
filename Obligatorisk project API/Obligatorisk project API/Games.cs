﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Obligatorisk_project_API
{
    public class Games
    {
        public string internalName { get; set; }
        public string title { get; set; }
        public string metacriticlink { get; set; }
        public string dealID { get; set; }
        public string storeID { get; set; }
        public string gameID { get; set; }
        public string salePrice { get; set; }
        public string normalPrice { get; set; }
        public string isOnSale { get; set; }
        public string savings { get; set; }
        public string metacriticscore { get; set; }
        public string steamRatingText { get; set; }
        public string steamRatingPercent { get; set; }
        public string steamRatingCount { get; set; }
        public string steamAppID { get; set; }
        public int releaseDate { get; set; }
        public int lastChange { get; set; }
        public string dealRating { get; set; }
        public string thumb { get; set; }
    }
}
