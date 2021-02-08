using System;

namespace MoodAnalyserSpace
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string Message)
        {
            if (Message.ToLower().Contains("sad"))
                return "SAD";
            else return "HAPPY";
        }
        static void Main(string[] args)
        {
          
        }
    }
}
