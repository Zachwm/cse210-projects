using System;

public class zmActivity
{
    public string zmDate;
    public int zmMinutes;

    public zmActivity(string zmdate, int zmminutes)
    {
        this.zmDate = zmdate;
        this.zmMinutes = zmminutes;
    }

    public virtual double zmGetDistance()
    {
        return 0;
    }

    public virtual double zmGetSpeed()
    {
        return 0;
    }

    public virtual double zmGetPace()
    {
        return 0;
    }

    public virtual string zmGetSummary()
    {
        return $"{zmDate} {GetType().Name} ({zmMinutes} min)";
    }
}
