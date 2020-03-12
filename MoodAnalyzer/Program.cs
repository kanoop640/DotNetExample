using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Able to check moods wheather Happy or Sad");
            MoodAnalyzerClass analysis = new MoodAnalyzerClass();
            Console.WriteLine(analysis.Mood(" i am sad"));
            Console.ReadLine();
        }
    }
}
