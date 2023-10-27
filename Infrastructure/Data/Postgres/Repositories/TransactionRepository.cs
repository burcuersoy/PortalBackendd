using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class TransactionRepository : Repository<Transaction, int>, ITransactionRepository
    {
        public TransactionRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public virtual async Task<IList<Transaction>> GetAllTransactionAsync(Expression<Func<Transaction, bool>>? filter = null)
        {
            return filter == null
                ? await PostgresContext.Set<Transaction>().ToListAsync()
                : await PostgresContext.Set<Transaction>().Where(filter).ToListAsync();
        }

        public virtual async Task<IList<Transaction>> GetTransactionByIdAsync(int id)
        {
            var transaction = await PostgresContext.Transactions
                .Where(c => c.Id == id)
                .ToListAsync();

            return transaction;
        }
    }
}
