public class zmRunning : zmActivity
{
    private double zmDistance;

    public zmRunning(string zmdate, int zmminutes, double zmdistance) : base(zmdate, zmminutes)
    {
        this.zmDistance = zmdistance;
    }

    public override double zmGetDistance()
    {
        return zmDistance;
    }

    public override double zmGetSpeed()
    {
        return zmDistance / zmMinutes * 60;
    }

    public override double zmGetPace()
    {
        return zmMinutes / zmDistance;
    }

    public override string zmGetSummary()
    {
        return $"{base.zmGetSummary()} - Distance: {zmDistance} miles, Speed: {zmGetSpeed()} mph, Pace: {zmGetPace()} min per mile";
    }
}
