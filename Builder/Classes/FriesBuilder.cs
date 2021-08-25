using System;

class FriesBuilder : BuilderBase
{
    Product _product;

    public FriesBuilder()
    {
        _product = new Product("Fries");
    }

    internal override void AddIngredients()
    {
        try
        {
            _product.Add("Cut Potato");
            _product.Add("Oil");
            _product.Add("Salt");            
        }
        catch (Exception)
        {

            throw;
        }
    }

    internal override Product GetResult()
    {
        return _product;
    }
}
