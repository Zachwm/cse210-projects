using System;

// Address class to store address information
class zmAddress
{
    public string zmStreet;
    public string zmCity;
    public string zmState;
    public string zmZipCode;

    public override string ToString()
    {
        return $"{zmStreet}, {zmCity}, {zmState}, {zmZipCode}";
    }
}