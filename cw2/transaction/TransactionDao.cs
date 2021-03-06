using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.Entity.Core;
using cw2.common.exception;

namespace cw2.transaction
{
    public sealed class TransactionDao
    {
        private static TransactionDao instance = null;

        private TransactionDao()
        {
        }
        public static TransactionDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TransactionDao();
                }
                return instance;
            }
        }

        public Transaction save(Transaction transaction)
        {
            using (Entities db = new Entities())
            {
                if (db.Database.Exists())
                {
                    if (transaction.Id == 0) //Add new record
                    {
                        db.Entry(transaction).State = EntityState.Added;
                        db.Transactions.Add(transaction);
                    }
                    else
                    {
                        foreach (TransactionInstance tins in transaction.TransactionInstances)
                        {
                            if (tins.Id != 0)
                            {
                                db.Entry(tins).State = EntityState.Modified;
                            }
                            else
                            {
                                db.Entry(tins).State = EntityState.Added;
                                db.TransactionInstances.Add(tins);
                            }
                        }

                        db.Entry(transaction).State = EntityState.Modified;
                    }

                    db.SaveChanges();
                }
                else
                {
                    throw new CW2DatabaseUnavaiableException("Database Unavailable");
                }
            
                
            }
            return transaction;
        }

        public List<Transaction> getAllTransactions()
        {
            List<Transaction> transactionList = new List<Transaction>();
            
            using (Entities db = new Entities())
            {
                if (db.Database.Exists())
                {
                    transactionList = db.Transactions.ToList<Transaction>();
                }
                else
                {
                    throw new CW2DatabaseUnavaiableException("Database Unavailable");
                }
               
            }

            return transactionList;
        }

        public List<Transaction> searchTransactionByCriteria(TransactionDto dto)
        {
            List<Transaction> transactionList = new List<Transaction>();

            using (Entities db = new Entities())
            {
                if (db.Database.Exists())
                {
                    var searchQuery = from txn in db.Transactions
                                      join tins in db.TransactionInstances on txn.Id equals tins.TransactionId
                                      where  (dto.Title == null || txn.Title.Contains(dto.Title))
                                          && (dto.Type == null || txn.Type.Equals(dto.Type)) 
                                            //&& (dto.CreatedDate == null || txn.ExpireDate == dto.CreatedDate) 
                                            //&& (tins.TransactionDate == dto.CreatedDate)

                                      select txn;
                    transactionList.AddRange(searchQuery.ToList<Transaction>());
                }
                else
                {
                    throw new CW2DatabaseUnavaiableException("Database Unavailable");
                }
                
            }
            return transactionList;
        }

        public void delete(int id)
        {
            clearTransactionInstances(id);

            using (Entities db = new Entities())
            {
                if (db.Database.Exists())
                {
                    Transaction transaction = db.Transactions.First(e => e.Id == id);

                    var entry = db.Entry(transaction);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Transactions.Attach(transaction);
                    }
                    db.Transactions.Remove(transaction);

                    //remove trnsaction instances
                    /*foreach (TransactionInstance tins in transaction.TransactionInstances)
                    {
                        transaction.TransactionInstances.Remove(tins);
                    }*/

                    db.SaveChanges();
                }
                else
                {
                    throw new CW2DatabaseUnavaiableException("Database Unavailable");
                }
            }
        }

        public void clearTransactionInstances(int transactionId)
        {
            using(Entities db = new Entities())
            {
                if (db.Database.Exists())
                {
                    var transactionInstances = from tins in db.TransactionInstances where tins.TransactionId.Equals(transactionId) select tins;

                    List<TransactionInstance> list = transactionInstances.ToList<TransactionInstance>();

                    db.TransactionInstances.RemoveRange(list);

                    db.SaveChanges();
                }
                else
                {
                    throw new CW2DatabaseUnavaiableException("Database Unavailable");
                }
            }
        }

        public Transaction findById(int id, Boolean detached)
        {
            using(Entities db = new Entities())
            {
                if (db.Database.Exists())
                {
                    Transaction transaction = db.Transactions.Where(t => t.Id == id).Include(t => t.TransactionInstances).FirstOrDefault();

                    if (detached)
                    {
                        db.Entry(transaction).State = EntityState.Detached;
                    }
                    return transaction;
                }
                else
                {
                    throw new CW2DatabaseUnavaiableException("Database Unavailable");
                }
                
            }
        }

        public TransactionInstance saveTransactionInstace(TransactionInstance transactionInstance)
        {
            using (Entities db = new Entities())
            {
                if (db.Database.Exists())
                {
                    if (transactionInstance.Id == 0) //Add new record
                    {
                        db.Entry(transactionInstance).State = EntityState.Added;
                        db.TransactionInstances.Add(transactionInstance);
                    }
                    else
                    {
                        db.Entry(transactionInstance).State = EntityState.Modified;
                    }

                    db.SaveChanges();

                    return transactionInstance;
                }
                else
                {
                    throw new CW2DatabaseUnavaiableException("Database Unavailable");
                }
            }
        }
    }
}
