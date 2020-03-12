using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetExample
{
    class Organization : IEnumerable
    {
        List<Employee> emps = new List<Employee>();
        public void Add(Employee emp)
        {
            emps.Add(emp);
        }
        public int Count
        {
            get { return emps.Count; }
        }
        public Employee this[int index]
        {
            get { return emps[index]; }
        }
        public IEnumerator GetEnumerator()
        {
            return new OrganizationEnumerator(this);
        }
    }
}
