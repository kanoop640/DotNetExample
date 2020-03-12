/// <summary>
/// It is class for method of MoodAnalysing
/// </summary>
namespace MoodAnalyzer
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// It is class for creating methods for MoodAnalysis class
    /// </summary>
    public class MoodAnalyzerClass
    {
       public string Mood(string msg)
        {
            if (msg.ToLower().Contains("happy"))
                return "HAPPY";
            return "SAD";
        }
    }
}
