class zmLecture : zmEvent
{
    private string zmSpeaker;
    private int zmCapacity;

    public zmLecture(string zmtitle, string zmdescription, DateTime zmdate, TimeSpan zmtime, zmAddress zmaddress, string zmspeaker, int zmcapacity)
        : base(zmtitle, zmdescription, zmdate, zmtime, zmaddress)
    {
        this.zmSpeaker = zmspeaker;
        this.zmCapacity = zmcapacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Lecture\nSpeaker: {zmSpeaker}\nCapacity: {zmCapacity}\n";
    }

    public override string GetShortDescription()
    {
        return $"Type: Lecture\nTitle: {zmTitle}\nDate: {zmDate.ToShortDateString()}\n";
    }
}