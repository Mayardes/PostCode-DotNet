namespace PostCode_Dotnet.Models;

public class Address
{
    public string PostCode {get; set;}
    public int Quality {get; set;}
    public int Eastings {get; set;}
    public int Northings {get; set;}
    public string Country {get; set;}
    public string City {get; set;}
    public double Longitude {get; set;}
    public double Latitude {get; set;}
    public string EuropeanElectoralRegion {get; set;}
    public string PrimaryCareTrust {get; set;}
    public string Region {get; set;}
    public string InCode {get; set;}
    public string OutCode {get; set;}
    public string ParliamentaryConstituency {get; set;}
    public string ParliamentaryConstituency2024 {get; set;}
    public string AdminDistrict {get; set;}
    public string Parish {get; set;}
    public string AdminCountry {get; set;}
    public int DateOfIntroduction {get; set;}
    public string AdminWard {get; set;}
    public string CCG {get; set;}
    public string Nuts {get; set;}
    public string Pfa {get; set;}
}