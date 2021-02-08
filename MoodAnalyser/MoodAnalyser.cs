﻿using System;

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
            try
            {
                if (Message.ToLower().Contains("sad"))
                    return "SAD";
                else return "HAPPY";
            }
            catch(NullReferenceException ) {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MOOD, "Mood should not be null");
            }
           
        }
        static void Main(string[] args)
        {
          
        }
    }
}
