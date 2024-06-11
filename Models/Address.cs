using System.Text.Json.Serialization;

namespace PostCode_Dotnet.Models;

public class Address
{
    [JsonPropertyName("postcode")]
    public string PostCode {get; set;}
    
    [JsonPropertyName("quality")]
    public int Quality {get; set;}

    [JsonPropertyName("eastings")]
    public int Eastings {get; set;}

    [JsonPropertyName("northings")]
    public int Northings {get; set;}

    [JsonPropertyName("country")]
    public string Country {get; set;}

    [JsonPropertyName("nhs_ha")]    
    public string City {get; set;}

    [JsonPropertyName("longitude")]   
    public double Longitude {get; set;}

    [JsonPropertyName("latitude")]   
    public double Latitude {get; set;}

    [JsonPropertyName("european_electoral_region")]  
    public string EuropeanElectoralRegion {get; set;}

    [JsonPropertyName("primary_care_trust")]  
    public string PrimaryCareTrust {get; set;}

    [JsonPropertyName("region")]  
    public string Region {get; set;}

    [JsonPropertyName("incode")]  
    public string InCode {get; set;}

    [JsonPropertyName("outcode")]  
    public string OutCode {get; set;}

    [JsonPropertyName("parliamentary_constituency")]  
    public string ParliamentaryConstituency {get; set;}

    [JsonPropertyName("parliamentary_constituency_2024")]  
    public string ParliamentaryConstituency2024 {get; set;}

    [JsonPropertyName("admin_district")]  
    public string AdminDistrict {get; set;}

    [JsonPropertyName("parish")]  
    public string Parish {get; set;}

    [JsonPropertyName("admin_county")]  
    public string AdminCountry {get; set;}

    [JsonPropertyName("date_of_introduction")]  
    public string DateOfIntroduction {get; set;}

    [JsonPropertyName("admin_ward")]  
    public string AdminWard {get; set;}

    [JsonPropertyName("ccg")]  
    public string CCG {get; set;}

    [JsonPropertyName("nuts")]  
    public string Nuts {get; set;}

    [JsonPropertyName("pfa")]  
    public string Pfa {get; set;}

    [JsonPropertyName("codes")]  
    public Code Codes {get; set;}
}