using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSGSIWebClientDemo.Models
{
    public class CSMatchList
    {
        [JsonProperty(PropertyName = "matches")]
        public List<CSMatch> Matches { get; set; }
    }
}
