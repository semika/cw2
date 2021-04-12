using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2.common
{
    public class CW2Response<T>
    {
        public T dto { get; set; }
        public string Status;
        public string Message;
        public List<T> dataList;
    }
}
