using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PostCode_Dotnet.Services;

namespace PostCode_Dotnet.Controllers;

[ApiController]
[Route("[controller]")]
public class AddressController(IPostcode postcode) : ControllerBase
{
    private readonly IPostcode _postCode = postcode;

    [HttpGet("postcode/")]
    public async Task<IActionResult> GetAddressAsync([FromQuery][Required] string postcode)
    {
        var result = await _postCode.GetAsync(postcode);

        return Ok(result);

    }
}