using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetExample
{
    public class Utility
    {
       public static  int readInt()
        {
            return int.Parse(Console.ReadLine());
        }
      public  static String readString()
        {
          String s=Console.ReadLine();
            return s;
        }
        public static double readDouble()
        {
            return Double.Parse(Console.ReadLine());
        }
   
        public static void intOut(int i)
        {
            Console.Write(" "+i);
        }
        public static void intOutLine(int i)
        {
            Console.WriteLine(i);
        }
        public static long readLong()
        {
            return long.Parse(Console.ReadLine());
        }
        public static void longOut(long i)
        {
            Console.WriteLine(i);
        }
        public static void doubleOut(double i)
        {
             Console.Write(" "+i);
        }
        public static void doubleOutLine(double i)
        {
            Console.WriteLine(i);
        }
        public static void stringOUt(string i)
        {
             Console.Write(" "+i);
        }
        public static  void stringOutLine(string i)
        {
            Console.WriteLine(i);
        }
        public static void stringOutBlank()
        {
            Console.WriteLine();
        }       
    }
}
