using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Base.Interface;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class TransactionController : BaseCRUDController<Transaction, int, TransactionCreateDto, TransactionUpdateDto, TransactionInfoDto>
    {
        public TransactionController(ITransactionService service) : base(service)
        {
        }
    }
}
