using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cw2.common;
using System.Data.SqlClient;
using System.Data;
using static cw2.Cw2DataSet;

namespace cw2.transaction
{
    class TransactionDataSetDao
    {
        private static TransactionDataSetDao instance = null;

        private TransactionDataSetDao()
        {
        }
        public static TransactionDataSetDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TransactionDataSetDao();
                }
                return instance;
            }
        }

        public List<TransactionRow> getAllTransactions()
        {
            List<TransactionRow> transactionList = new List<TransactionRow>();

            DataTable transactionTable = DataSetProvider.Instance.getDataSet().Tables["Transaction"];

            foreach(TransactionRow transactionRow in transactionTable.Rows)
            {
                transactionList.Add(transactionRow);
            }
            
            return transactionList;
        }

        public TransactionRow findById(int id)
        {
            Cw2DataSet dataSet = DataSetProvider.Instance.getDataSet();
            TransactionRow transactionRow = dataSet.Transaction.FindById(id);
            TransactionDto dto = new TransactionDto();

            return transactionRow;
        }
    }
}
