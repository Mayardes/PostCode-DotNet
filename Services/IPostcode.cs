using System.Threading.Tasks;
using PostCode_Dotnet.Models;
using Refit;

namespace PostCode_Dotnet.Services;

[Headers("accept: application/json")]
public interface IPostcode
{
    [Get("/postcodes/{code}")]
    Task<AddressesCode> GetAsync(string code);

    [Get("/postcodes?lon={longitude}&lat={latitude}")]
    Task<AddressesLongLat> GetByLongitudeAndLatitudeAsync(decimal longitude, decimal latitude);
}