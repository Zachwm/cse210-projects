class zmReception : zmEvent
{
    private string zmRsvpEmail;

    public zmReception(string zmtitle, string zmdescription, DateTime zmdate, TimeSpan zmtime, zmAddress zmaddress, string zmrsvpEmail)
        : base(zmtitle, zmdescription, zmdate, zmtime, zmaddress)
    {
        this.zmRsvpEmail = zmrsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Reception\nRSVP Email: {zmRsvpEmail}\n";
    }

    public override string GetShortDescription()
    {
        return $"Type: Reception\nTitle: {zmTitle}\nDate: {zmDate.ToShortDateString()}\n";
    }
}