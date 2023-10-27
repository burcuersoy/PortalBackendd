using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories.Interface
{
    public interface ICustomerRepository : IRepository<Customer, int>
    {
        Task<IList<Customer>> GetAllCustomerAsync(Expression<Func<Customer, bool>>? filter = null);
        Task<IList<Customer>> GetCustomerByIdAsync(int id);
    }
}
