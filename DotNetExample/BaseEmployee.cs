using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetExample
{
    public abstract class BaseEmployee
    {
        public int Id { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string GetFullName()
        {
            return this.FristName + " " + this.LastName;
        }
        public abstract int GetMonthlySalary();
    }
}
