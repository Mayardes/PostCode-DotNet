
using System.Text.Json.Serialization;

namespace PostCode_Dotnet.Models;

public class Code
{

    [JsonPropertyName("admin_district")]
    public string AdminDistrict {get; set;}

    [JsonPropertyName("admin_county")]
    public string AdminCountry {get; set;}

    [JsonPropertyName("admin_ward")]
    public string AdminWard {get; set;}

    [JsonPropertyName("parish")]
    public string Parish {get; set;}

    [JsonPropertyName("parliamentary_constituency")]
    public string ParliamentaryConstituency {get; set;}

    [JsonPropertyName("parliamentary_constituency_2024")]
    public string ParliamentaryConstituency2024 {get; set;}

    [JsonPropertyName("ccg")]
    public string CCG {get; set;}

    [JsonPropertyName("ccg_id")]
    public string CCGId {get; set;}

    [JsonPropertyName("ced")]
    public string CED {get; set;}

    [JsonPropertyName("nuts")]
    public string Nuts {get; set;}

    [JsonPropertyName("lsoa")]
    public string Lsoa {get; set;}

    [JsonPropertyName("msoa")]
    public string Msoa {get; set;}

    [JsonPropertyName("lau2")]
    public string Lau2 {get; set;}

    [JsonPropertyName("pfa")]
    public string Pfa {get; set;}
}