using System;

class FriesBuilder : BuilderBase
{
    Product _product;

    public FriesBuilder()
    {
        _product = new Product();
        _product.AddProductTitle("Fries");
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

    internal override Product GetFinalProduct()
    {
        return _product;
    }
}
