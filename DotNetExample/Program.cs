using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;

namespace DotNetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Person person = new Person();
            person.SetBirthDate(new DateTime(1995, 03, 15));
            string date = person.GetBirthDate().ToString();
            Console.WriteLine(date);
            string pattern = @"([a-zA-Z]+) (\d+)";
            string str = "Your fullname is jan 2020 and you born at March 1995";
            Regex rc = new Regex(pattern);
            foreach (Match s in rc.Matches(str))
            {
                Console.WriteLine("Match is {0} and found at index {1}", s.Value, s.Index);
            }
            Customer cs = new Customer();
            cs.Name = "Anoop";
            cs.Id = 101;
            cs.Mob=8953997805;
            Console.WriteLine("Your name is : "+cs.Name);
            var cocki = new HttpCockies();
            cocki["name"] = "Imran";
            Console.WriteLine(cocki["name"]);*/
            Type fc = Type.GetType("DotNetExample.Customer");
            Console.WriteLine("Name of the class :"+fc.Name);
            Console.WriteLine("Namespace : " + fc.Namespace);
            Console.WriteLine("FullName : " + fc.FullName);
            Console.WriteLine("Properies in Customer ");
            PropertyInfo[] properties = fc.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name+" "+ property.Name);
            }
            Console.WriteLine();
            Type pri = Type.GetType("DotNetExample.primeFactor");
            //Type pri = typeof(primeFactor);
            primeFactor prime = new primeFactor();
            FieldInfo[] values = prime.GetType().GetFields();
            foreach(FieldInfo value in values)
            {
                Console.WriteLine("Field value :"+value.GetValue(prime));
            }
            Console.WriteLine("Name of the class :"+pri.Name);
            Console.WriteLine("Method in primeFator ");
            MethodInfo[] methods = pri.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine("Type of method :"+method.ReturnType.Name + " ," +"Method name :"+ method.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Constructor in Custorme ");
            ConstructorInfo[] constructors = fc.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
            ImplementationClass obj = new ImplementationClass();
            obj.Add(10, 20); obj.Sub(25, 10);
            obj.Mul(5, 12);
            Console.ReadLine();
        }
    }
}
