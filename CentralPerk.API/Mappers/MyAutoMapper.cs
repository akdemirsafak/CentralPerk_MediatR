using AutoMapper;
using CentralPerk.API.Dtos.Customer;
using CentralPerk.API.Dtos.Product;
using CentralPerk.API.Models;

namespace CentralPerk.API.Mappers;

public class MyAutoMapper:Profile
{
    public MyAutoMapper()
    {
        CreateMap<Product, ProductDto>();
        CreateMap<Customer, CustomerDto>();
    }
}