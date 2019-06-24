using System;
using System.Runtime.Serialization;

namespace QuanLyNhaKho
{
    [Serializable]
    internal class IDDoesnotExist : Exception
    {
        public IDDoesnotExist()
        {
        }

        public IDDoesnotExist(string message) : base(message)
        {
        }

        public IDDoesnotExist(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IDDoesnotExist(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}