using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2.common
{
    public sealed class DataSetProvider
    {
        Cw2DataSet dataSet = null;
        private DataSetProvider() {
            dataSet = new Cw2DataSet();
        }
        private static DataSetProvider instance = null;

        public static DataSetProvider Instance
        {
            get {
                if (instance == null)
                {
                    instance = new DataSetProvider();
                }
                return instance;
            }
        }

        public Cw2DataSet getDataSet()
        {
            return this.dataSet;
        }
    }
}
