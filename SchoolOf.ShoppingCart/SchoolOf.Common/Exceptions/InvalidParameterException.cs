using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOf.Common.Exceptions
{
    public class InvalidParameterException : Exception
    {
        public InvalidParameterException(int parameter)
            : base(String.Format("Invalid Value Parameter: {0}", parameter))
        {

        }
    }
}
