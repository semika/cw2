using System;
using System.Collections.Generic;
using System.IO;
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

        public void readDataSet()
        {
            //File exsis 
            if (File.Exists(AppConstant.LOCAL_DATA_SET_PATH))
            {
                this.dataSet.ReadXml(AppConstant.LOCAL_DATA_SET_PATH);
            }
            else   //If no file exsis, create a one
            {
                this.writeDataSet();
            }
            
        }

        public void writeDataSet()
        {
            this.dataSet.WriteXml(AppConstant.LOCAL_DATA_SET_PATH);
        }

        public Cw2DataSet getDataSet()
        {
            return this.dataSet;
        }
    }
}
