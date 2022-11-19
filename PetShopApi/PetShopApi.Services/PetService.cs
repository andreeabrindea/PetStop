using PetShopApi.Common.Entities;
using PetShopApi.Common.Enums;
using PetShopApi.Interfaces;

namespace PetShopApi.Services;

public class PetService : IPetService
{
    public async Task<List<Pet>> GetAll()
    {
        return new List<Pet>
        {
            new()
            {
                Id = 1,
                OwnerId = 1,
                Species = Species.Cat,
                Name = "Findus",
                Visits = new List<Visit>
                {
                    new()
                    {
                        Id = 1,
                        Reason = new()
                        {
                            Id = 1,
                            Name = "E prost"
                        },
                        DateTime = DateTimeOffset.Now.ToUnixTimeSeconds(),
                        Conclusion = "Doctoru recomanda bataie cu sare"
                    }
                }
            }
        };
    }
}