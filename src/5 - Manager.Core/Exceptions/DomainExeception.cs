using System;
using System.Collections.Generic;

namespace Manager.Core.Exceptions
{
    public class DomainExeception : Exception
    {
        internal List<string> _errors;
        public IReadOnlyCollection<string> Errors =>  _errors;

        public DomainExeception()
        { }

        public DomainExeception(string message, List<string> errors) : base(message)
        {
            _errors = errors;
        }

        public DomainExeception(string message) : base(message) 
        { }

        public DomainExeception(string message, Exception innerException) : base(message, innerException)
        {

        }
    }

}