using System.Text.Json.Serialization;

namespace PostCode_Dotnet.Models;

public class Addresses
{
    [JsonPropertyName("result")]
    public Address Results {get; set;}

    [JsonPropertyName("status")]
    public int Status  {get; set;}
}