using System;
using System.Runtime.Serialization;

namespace QuanLyNhaKho
{
    [Serializable]
    internal class PasswordAgain : Exception
    {
        public PasswordAgain()
        {
        }

        public PasswordAgain(string message) : base(message)
        {
        }

        public PasswordAgain(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PasswordAgain(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}