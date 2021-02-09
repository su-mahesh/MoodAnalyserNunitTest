﻿using System;
using System.Reflection;

namespace MoodAnalyserNameSpace
{
    public class MoodAnalyser
    {
        public string Message;

        public MoodAnalyser()
        {
        }

        public MoodAnalyser(string Message)
        {
            this.Message = Message.ToUpper();
        }

        public string AnalyseMood()
        {
            try
            {
                if (Message.ToLower().Contains("sad"))
                    return "SAD";
                else if (Message.Equals(String.Empty))
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MOOD, "Mood should not be empty");
                else return "HAPPY";

            } catch (NullReferenceException)
            { throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MOOD, "Mood should not be null"); }
                
        }
        static void Main(string[] args)
        {

          
        }
    }
}
