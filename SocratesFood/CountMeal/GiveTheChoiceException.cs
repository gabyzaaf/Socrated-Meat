using System;
using System.Runtime.Serialization;

namespace SocratesFoodTest
{
    [Serializable]
    public class GiveTheChoiceException : Exception
    {
        public GiveTheChoiceException()
        {
        }

        public GiveTheChoiceException(string message) : base(message)
        {
        }

        public GiveTheChoiceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GiveTheChoiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}