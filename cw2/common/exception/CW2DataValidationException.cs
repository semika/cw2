using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2.common.exception
{
    class CW2DataValidationException : Exception
    {
        public CW2DataValidationException()
        {

        }

        public CW2DataValidationException(String message) : base (message)
        {
            
        }
    }
}
