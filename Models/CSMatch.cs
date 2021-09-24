﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSGSIWebClientDemo.Models
{
    public class CSMatch
    {
        //[JsonProperty(PropertyName = "id")]
        //public int Id { get; set; }

        public int id { get; set; }
        public int user_id { get; set; }
        public double datetime_start { get; set; }
        public int minutes_played { get; set; }
        public string map_name { get; set; }
        public string team { get; set; }
        public string round_win_team { get; set; }
        [JsonProperty(PropertyName = "match_stats")]
        public Dictionary<string, int> matchStats { get; set; }
        //public MatchStats matchStats { get; set; }
    }
}
