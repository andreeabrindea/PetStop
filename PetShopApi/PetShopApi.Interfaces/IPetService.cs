using PetShopApi.Common.Entities;

namespace PetShopApi.Interfaces;

public interface IPetService
{
    Task<List<Pet>> GetAll();
}