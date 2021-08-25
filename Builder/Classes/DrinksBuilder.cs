using System;

class DrinksBuilder : BuilderBase
{
    Product _product;

    public DrinksBuilder()
    {
        _product = new Product("Drink");
    }

    internal override void AddIngredients()
    {
        try
        {
            _product.Add("Large Cup");
            _product.Add("Coke");            
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