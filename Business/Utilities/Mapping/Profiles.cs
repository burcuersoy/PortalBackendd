using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        CreateMap<RegisterDto, User>();
        CreateMap<User, UserProfileDto>();
        CreateMap<User, UserProfileDto>().ReverseMap();

        CreateMap<CustomerCreateDto, Customer>().ReverseMap();
        CreateMap<CustomerUpdateDto, Customer>().ReverseMap();
        CreateMap<Customer, CustomerInfoDto>().ReverseMap();

        CreateMap<TransactionCreateDto, Transaction>().ReverseMap();
        CreateMap<TransactionUpdateDto, Transaction>().ReverseMap();
        CreateMap<Transaction, TransactionInfoDto>().ReverseMap();
    }
}