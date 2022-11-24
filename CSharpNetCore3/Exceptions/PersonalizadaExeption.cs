using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CSharpNetCore3.Exceptions
{
    internal class PersonalizadaExeption : Exception
    {
        public PersonalizadaExeption()
        {
        }

        public PersonalizadaExeption(string message) : base(message)
        {
        }

        public PersonalizadaExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PersonalizadaExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
