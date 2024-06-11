using System.Text.Json.Serialization;

namespace PostCode_Dotnet.Models;

public class AddressesValidate
{
    [JsonPropertyName("result")]
    public bool Results {get; set;}

    [JsonPropertyName("status")]
    public int Status  {get; set;}
}