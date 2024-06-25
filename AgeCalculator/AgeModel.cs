using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgeCalculator
{
    public class AgeModel
    {
        public int Years { get; set; }
        public int Months { get; set; }
        public int Days { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public string AgeToString { get; set; }

    }
}