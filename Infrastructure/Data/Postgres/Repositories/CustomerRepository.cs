using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
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
    public class CustomerRepository : Repository<Customer, int>, ICustomerRepository
    {
        public CustomerRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public virtual async Task<IList<Customer>> GetAllCustomerAsync(Expression<Func<Customer, bool>>? filter = null)
        {
            return filter == null
               ? await PostgresContext.Set<Customer>().ToListAsync()
               : await PostgresContext.Set<Customer>().Where(filter).ToListAsync();
        }

        public virtual async Task<IList<Customer>> GetCustomerByIdAsync(int id)
        {
            var customer = await PostgresContext.Customers
                .Where(c => c.Id == id)
                .ToListAsync();

            return customer;
        }
    }
}
