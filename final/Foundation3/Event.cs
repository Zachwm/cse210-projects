class zmEvent
{
    protected string zmTitle;
    private string zmDescription;
    protected DateTime zmDate;
    private TimeSpan zmTime;
    private zmAddress zmAddress;

    public zmEvent(string zmtitle, string zmdescription, DateTime zmdate, TimeSpan zmtime, zmAddress zmaddress)
    {
        this.zmTitle = zmtitle;
        this.zmDescription = zmdescription;
        this.zmDate = zmdate;
        this.zmTime = zmtime;
        this.zmAddress = zmaddress;
    }

    public string GetStandardDetails()
    {
       return $"Title: {zmTitle}\nDescription: {zmDescription}\nDate: {zmDate.ToShortDateString()}\nTime: {zmTime.ToString(@"hh\:mm", System.Globalization.CultureInfo.InvariantCulture)}\nAddress: {zmAddress}\n";
    }
    

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Type: Generic Event\nTitle: {zmTitle}\nDate: {zmDate.ToShortDateString()}\n";
    }
}