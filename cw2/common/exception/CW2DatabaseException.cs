using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2.common.exception
{
    class CW2DatabaseException : Exception
    {
        public CW2DatabaseException()
        {

        }

        public CW2DatabaseException(String message) : base (message)
        {
            
        }
    }
}
