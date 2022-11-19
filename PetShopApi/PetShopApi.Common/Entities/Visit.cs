namespace PetShopApi.Common.Entities;

public class Visit
{
    public int Id { get; set; }
    public long DateTime { get; set; }
    public Reason Reason { get; set; }
    public string Conclusion { get; set; }
}