using Microsoft.AspNetCore.Mvc;
using PetShopApi.Interfaces;

namespace PetShopApi.Controllers;

[ApiController]
[Route("pets")]
public class PetController : ControllerBase
{
    private readonly IPetService _petService;

    public PetController(IPetService petService)
    {
        _petService = petService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var pets = await _petService.GetAll();
        return Ok(pets);
    }
}