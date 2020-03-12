using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;
using Newtonsoft.Json;
using System.IO;

namespace DotNetExample
{
    public delegate int Add(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            /* ImplementationClass mu = new ImplementationClass();
             Add ad = new Add(mu.Add);
             Console.ReadLine();*/
            /*Customer cs = new Customer()
            {
                Name = "Anoop",
                Id = 101,
                Mob = 89539945,
                Hobbies = new List<string>() { "reading", "Fishing" }
            };
            string str = JsonConvert.SerializeObject(cs);
            Console.WriteLine(str);
            File.WriteAllText(@"cs.json", str);*/
            string path = @"D:\Anoop_kumar\CensusAnalyzer\CensusAnalyzer\StateCensusData.json";
            //var val = File.ReadAllText(path);
            dynamic value = JsonConvert.DeserializeObject(path);
            foreach (var one in value)
            {
                Console.WriteLine("{0},{1}", one.Statte, one.Population);
            }
            //foreach (var line in value)
            //{
            //    var val1 = line.Split(',');
            //    var val = JsonConvert.SerializeObject(val1, Formatting.Indented);
            //    File.WriteAllText(@"hello.json", val);
            //    Console.WriteLine(val);
            //}

            Console.Read();
        }

    }
}
