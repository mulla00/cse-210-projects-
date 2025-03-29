using System;



public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    // public string GetStreetAddress()
    // {
    //     return streetAddress;
    // }

    // public string GetCity()
    // {
    //     return city;
    // }

    // public string GetStateOrProvince()
    // {
    //     return stateOrProvince;
    // }

    // public string GetCountry()
    // {
    //     return country;
    // }

    public bool IsAddressUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public string DisplayStreetAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}