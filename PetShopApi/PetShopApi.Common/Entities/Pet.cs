using PetShopApi.Common.Enums;

namespace PetShopApi.Common.Entities;

public class Pet
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Species Species { get; set; }
    public int OwnerId { get; set; }
    public List<Visit> Visits { get; set; }
}