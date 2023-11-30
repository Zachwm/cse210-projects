class zmProduct
{
    public int zmProductId;
    public string zmName;
    private double zmPrice;

    public zmProduct(int zmproductId ,string zmname , double zmprice)
    {
        zmProductId = zmproductId;
        zmName = zmname;
        zmPrice = zmprice;
    }
    public double GetPrice()
    {
        return zmPrice;
    }
}