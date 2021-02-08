using NUnit.Framework;
using MoodAnalyserSpace;
namespace MoodAnalyserNUnitTest
{
    public class Tests
    {
        MoodAnalyser moodAnalyser;
        [SetUp]
        public void Setup()
        {
            moodAnalyser = new MoodAnalyser();
        }

        [Test]
        public void GivenMessage_WhenSad_ShouldReturnSad()
        {
            string message = moodAnalyser.AnalyseMood("SAD");
            Assert.AreEqual("SAD", message);
        }

    }
}