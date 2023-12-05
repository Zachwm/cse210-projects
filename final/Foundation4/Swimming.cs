public class zmSwimming : zmActivity
{
    private int zmLaps;

    public zmSwimming(string zmdate, int zmminutes, int zmlaps) : base(zmdate, zmminutes)
    {
        this.zmLaps = zmlaps;
    }

    public override double zmGetDistance()
    {
        return zmLaps * 50 / 1000.0;
    }

    public override double zmGetSpeed()
    {
        return zmGetDistance() / zmMinutes * 60;
    }

    public override double zmGetPace()
    {
        return zmMinutes / zmGetDistance();
    }

    public override string zmGetSummary()
    {
        return $"{base.zmGetSummary()} - Distance: {zmGetDistance()} miles, Speed: {zmGetSpeed()} mph, Pace: {zmGetPace()} min per mile";
    }
}
