using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PostCode_Dotnet.Models;

public class AddressesLongLat
{
    [JsonPropertyName("result")]
    public List<Address> Results {get; set;}

    [JsonPropertyName("status")]
    public int Status  {get; set;}
}