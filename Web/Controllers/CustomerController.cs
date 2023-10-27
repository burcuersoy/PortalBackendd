using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Base.Interface;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class CustomerController : BaseCRUDController<Customer, int, CustomerCreateDto, CustomerUpdateDto, CustomerInfoDto>
    {
        public CustomerController(ICustomerService service) : base(service)
        {
        }
    }
}
