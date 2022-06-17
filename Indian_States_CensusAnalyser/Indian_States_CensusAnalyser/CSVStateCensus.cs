using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indian_States_CensusAnalyser
{
    public class CSVStateCensus
    {
        public string State { get; set; }
        public string Population { get; set; }

        public string AreaInSqKm { get; set; }
        public string DensityPerSqKm { get; set; }
    }

    public class StateCodes
    {
        public string SrNo { get; set; }
        public string StateName { get; set; }
        public string TIN { get; set; }
        public string StateCode { get; set; }
    }
}
