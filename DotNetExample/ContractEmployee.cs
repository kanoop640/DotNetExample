using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetExample
{
    class ContractEmployee:BaseEmployee
    {
        public int HourlyPaid { get; set; }
        public int WorkedHour { get; set; }

        public override int GetMonthlySalary()
        {
            return this.HourlyPaid * this.WorkedHour;
        }
    }
}
