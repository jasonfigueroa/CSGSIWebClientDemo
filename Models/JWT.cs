using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSGSIWebClientDemo.Models
{
    public class JWT
    {
        public string access_token { get; set; }
        public string refresh_token { get; set; }
    }
}
