using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PostCode_Dotnet.Models;

public class AddressesCode
{
    [JsonPropertyName("result")]
    public Address Results {get; set;}

    [JsonPropertyName("status")]
    public int Status  {get; set;}
}