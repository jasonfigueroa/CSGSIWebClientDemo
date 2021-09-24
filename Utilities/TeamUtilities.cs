using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSGSIWebClientDemo.Utilities
{
    public class TeamUtilities
    {
        public Dictionary<string, string> TeamDict { get; }

        public TeamUtilities()
        {
            TeamDict = new Dictionary<string, string>
            {
                { "CT", "Counter-Terrorists" },
                { "T", "Terrorists" }
            };
        }
    }
}
