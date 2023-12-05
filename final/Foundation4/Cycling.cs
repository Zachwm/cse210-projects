public class zmCycling : zmActivity
{
    private int zmSpeed;

    public zmCycling(string zmdate, int zmminutes, int zmspeed) : base(zmdate, zmminutes)
    {
        this.zmSpeed = zmspeed;
    }

    public override double zmGetSpeed()
    {
        return zmSpeed;
    }

    public override double zmGetDistance()
    {
        return zmSpeed * zmMinutes / 60.0;
    }

    public override double zmGetPace()
    {
        return 60.0 / zmSpeed;
    }

    public override string zmGetSummary()
    {
        return $"{base.zmGetSummary()} - Distance: {zmGetDistance()} miles, Speed: {zmSpeed} mph, Pace: {zmGetPace()} min per mile";
    }
}
