using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkAD
{
    class CustomerRecord
    {
        public int idRecord { get; set; }
        public String categoryRecord { get; set; }
        public String typeRecord { get; set; }
        public int countRecord { get; set; }
        public DateTime entryTimeRecord { get; set; }
        public DateTime exitTimeRecord { get; set; }
        public double entryCostRecord { get; set; }

        public bool isLeftRecord { get; set; }
    }
}
