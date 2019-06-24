using System;
using System.Runtime.Serialization;

namespace QuanLyNhaKho
{
    [Serializable]
    internal class IDandPassisNull : Exception
    {
        public IDandPassisNull()
        {
        }

        public IDandPassisNull(string message) : base(message)
        {
        }

        public IDandPassisNull(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IDandPassisNull(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}