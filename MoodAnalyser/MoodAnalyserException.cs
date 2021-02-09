using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserNameSpace
{
    public class MoodAnalyserException : Exception
    {
        public enum ExceptionType
        {
            EMPTY_MOOD,
            NULL_MOOD,
            NO_SUCH_CLASS
        }

        public ExceptionType exceptionType;
        public MoodAnalyserException(ExceptionType exceptionType, string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
