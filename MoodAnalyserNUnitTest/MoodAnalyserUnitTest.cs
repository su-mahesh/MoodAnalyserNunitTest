using NUnit.Framework;
using MoodAnalyserNameSpace;
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
            moodAnalyser = new MoodAnalyser("I am in Sad Mood");
            string message = moodAnalyser.AnalyseMood();
            Assert.AreEqual("SAD", message);
        }

        [Test]
        public void GivenMessage_WhenHappy_ShouldReturnHappy()
        {
            moodAnalyser = new MoodAnalyser("I am in Happy Mood");
            string message = moodAnalyser.AnalyseMood();
            Assert.AreEqual("HAPPY", message);
        }

        [Test]
        public void GivenMessage_WhenNull_UsingCustomException_ShouldReturnNullMood()
        {
            moodAnalyser = new MoodAnalyser();
            try {
                string Message = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.NULL_MOOD, exception.exceptionType);
            }                      
        }

        [Test]
        public void GivenMessage_WhenEmpty_UsingCustomException_ShouldReturnEmptyMood()
        {
            moodAnalyser = new MoodAnalyser("");
            try
            {
                string Message = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.EMPTY_MOOD, exception.exceptionType);
            }
        }
        [Test]
        public void GivenMoodAnalyserClassName_WhenProper_ShouldReturnMoodAnalyserObject()
        {
            object expected = new MoodAnalyser();
            object result = MoodAnalyserFactory.GetMoodAnalyserObject("MoodAnalyserNameSpace.MoodAnalyser", "MoodAnalyser");
            expected.Equals(result);
        }

        [Test]
        public void GivenMoodAnalyserClassName_WhenImproper_ShouldThrowMoodAnalysisException()
        {
            try
            {
                object result = MoodAnalyserFactory.GetMoodAnalyserObject("MoodAnalyser.MoodAnalyser", "MoodAnalyser");
            }
            catch(MoodAnalyserException exception)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.NO_SUCH_CLASS, exception.exceptionType);
            }
        }
        [Test]
        public void GivenMoodAnalyserClassName_WhenConstructorNameIsImproper_ShouldThrowMoodAnalysisException()
        {
            try
            {
                object result = MoodAnalyserFactory.GetMoodAnalyserObject("MoodAnalyserNameSpace.MoodAnalyser", "MoodAnalys");
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.NO_SUCH_METHOD, exception.exceptionType);
            }
        }
    }
}