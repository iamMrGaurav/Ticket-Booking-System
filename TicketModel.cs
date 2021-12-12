using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkAD
{
    class TicketModel
    {
      public int id { get; set; }
        public string category { get; set; }

        public string type { get; set; }
        public float rateOneHr { get; set; }
        public float rateTwoHr { get; set; }
        public float rateThreeHr { get; set; }
        public float rateFourHr { get; set; }
        public float rateWholeDay { get; set; }

    }
}
