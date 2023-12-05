class zmOutdoorGathering : zmEvent
{
    private string zmWeatherStatement;

    public zmOutdoorGathering(string zmTitle, string zmDescription, DateTime zmDate, TimeSpan zmTime, zmAddress zmAddress, string zmweatherstatement)
        : base(zmTitle, zmDescription, zmDate, zmTime, zmAddress)
    {
        this.zmWeatherStatement = zmweatherstatement;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Outdoor Gathering\nWeather: {zmWeatherStatement}\n";
    }

    public override string GetShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {zmTitle}\nDate: {zmDate.ToShortDateString()}\n";
    }
}