using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace cw2.transaction
{
    class TransactionDao
    {
        public Transaction save(Transaction transaction)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    if (transaction.Id == 0) //Add new record
                    {
                        db.Entry(transaction).State = EntityState.Added;
                        db.Transactions.Add(transaction);
                    }
                    else
                    {
                        db.Entry(transaction).State = EntityState.Modified;
                    }

                    db.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }

            return transaction;
        }

        public List<Transaction> getAllTransactions()
        {
            List<Transaction> transactionList = new List<Transaction>();

            using (Entities db = new Entities())
            {
                transactionList = db.Transactions.ToList<Transaction>();
            }

            return transactionList;
        }

        public void delete(int id)
        {
            using (Entities db = new Entities())
            {
                Transaction transaction = db.Transactions.First(e => e.Id == id);
                var entry = db.Entry(transaction);
                if (entry.State == EntityState.Detached)
                {
                    db.Transactions.Attach(transaction);
                }
                db.Transactions.Remove(transaction);
                db.SaveChanges();
            }
        }

        public TransactionInstance saveTransactionInstace(TransactionInstance transactionInstance)
        {
            try
            {
                using (Entities db = new Entities())
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
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }

            return transactionInstance;
        }
    }
}
