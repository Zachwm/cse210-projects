class zmOrder
{
    private List<zmProduct> zmproducts;
    private zmCustomer zmcustomer;

    public zmOrder(zmCustomer zmcustomer)
    {
        this.zmcustomer = zmcustomer;
        this.zmproducts = new List<zmProduct>();
    }

    public void AddProduct(zmProduct zmproduct)
    {
        zmproducts.Add(zmproduct);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (zmProduct product in zmproducts)
        {
            totalPrice += product.GetPrice();
        }

        // Add shipping cost
        totalPrice += zmcustomer.zmAddress.IsInUSA() ? 5 : 35;

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (zmProduct zmproduct in zmproducts)
        {
            label += $"{zmproduct.zmName} (ID: {zmproduct.zmProductId})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{zmcustomer.zmName}\n{zmcustomer.zmAddress.ToString()}";
    }
}