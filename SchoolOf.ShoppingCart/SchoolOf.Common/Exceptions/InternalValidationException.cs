using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOf.Common.Exceptions
{
    public class InternalValidationException : Exception
    {
        public InternalValidationException(List<string> errors)
        {
            Errors = errors;
        }

        public InternalValidationException(string error)
        {
            Errors = new List<string> { error };
        }

        public List<string> Errors { get; }
    }
}
