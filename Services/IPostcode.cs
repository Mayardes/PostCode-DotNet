using System.Threading.Tasks;
using PostCode_Dotnet.Models;
using Refit;

namespace PostCode_Dotnet.Services;

[Headers("accept: application/json")]
public interface IPostcode
{
    [Get("/postcodes/{code}")]
    Task<Address> GetAsync(string code);
}