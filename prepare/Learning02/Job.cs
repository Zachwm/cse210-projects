using System;

public class Job
{
    public string _zmJobTitle;
    public string _zmCompany;
    public int _zmStartYear;
    public int _zmEndYear;

    public void zmDisplay()
    {
        Console.WriteLine($"{_zmJobTitle} ({_zmCompany}) {_zmStartYear}-{_zmEndYear}");
    }
}