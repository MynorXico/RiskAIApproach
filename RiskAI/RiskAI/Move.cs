using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskAI
{
    public class Move
    {
        Country From { get; }
        Country To { get; }
        int NTroops { get; }

        public Move(Country from, Country to, int numberOfTroops)
        {
            this.From = from;
            this.To = to;
            this.NTroops = numberOfTroops;
        }
    }
}
