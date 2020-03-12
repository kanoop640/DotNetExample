using NUnit.Framework;
using MoodAnalyzer;

namespace NUnitTesting
{
    public class Tests
    {
        private readonly MoodAnalyzerClass testmood = new MoodAnalyzerClass();
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void TestForHappyMood()
        {
            string str = testmood.Mood("I am happy");
            string happy = "HAPPY";
            Assert.AreEqual(str, happy);
        }
    }
}