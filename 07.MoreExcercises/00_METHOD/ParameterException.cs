using System;
using System.Runtime.Serialization;

namespace _00_METHOD
{
    [Serializable]
    internal class ParameterException : Exception
    {
        private string paramName;
        private string v;

        public ParameterException()
        {
        }

        public ParameterException(string message) : base(message)
        {
        }

        public ParameterException(string paramName, string v)
        {
            this.paramName = paramName;
            this.v = v;
        }

        public ParameterException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ParameterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}