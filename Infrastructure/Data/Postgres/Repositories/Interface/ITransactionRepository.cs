using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure.Data.Postgres.Repositories.Interface
{
    public interface ITransactionRepository : IRepository<Transaction, int>
    {
        Task<IList<Transaction>> GetAllTransactionAsync(Expression<Func<Transaction, bool>>? filter = null);
        Task<IList<Transaction>> GetTransactionByIdAsync(int id);
    }
}
