using System;

namespace MoodAnalyserSpace
{
    public class MoodAnalyser
    {
        string Message;

        public MoodAnalyser()
        {
        }

        public MoodAnalyser(string Message)
        {
            this.Message = Message;
        }

        public string AnalyseMood()
        {
                if (Message == null)
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MOOD, "Mood should not be null");
                else if (Message.ToLower().Contains("sad"))
                    return "SAD";
                else if (Message.Length == 0)
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MOOD, "Mood should not be empty");

                else return "HAPPY"; 
        }

        static void Main(string[] args)
        {
          
        }
    }
}
