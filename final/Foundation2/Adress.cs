class zmAddress
{
    private string zmStreetAddress;
    private string zmCity;
    private string zmStateProvince;
    private int zmAreaCode;
    private string zmCountry;

    public zmAddress(string zmstreetAddress, string zmcity, string zmstateProvince, int zmareaCode, string zmcountry)
    {
        zmStreetAddress = zmstreetAddress;
        zmCity = zmcity;
        zmStateProvince = zmstateProvince;
        zmAreaCode = zmareaCode;
        zmCountry = zmcountry;
    }

    public bool IsInUSA()
    {
        return zmCountry.ToUpper() == "USA";
    }

    public override string ToString()
    {
        return $"{zmStreetAddress}\n{zmCity}, {zmStateProvince}\n{zmCountry}";
    }
}