using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2.common.exception
{
    class CW2DatabaseUnavaiableException : Exception
    {
        public CW2DatabaseUnavaiableException()
        {

        }

        public CW2DatabaseUnavaiableException(String message) : base (message)
        {
            
        }
    }
}
