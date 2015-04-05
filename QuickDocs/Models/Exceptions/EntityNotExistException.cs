using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace QuickDocs.Models.Exceptions
{
    public class EntityNotExistException : Exception
    {
        public EntityNotExistException() { }

        public EntityNotExistException(string message) : base(message) { }

        public EntityNotExistException(string message, Exception inner) : base(message, inner) { }

        protected EntityNotExistException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}