using System;

class BurgerBuilder : BuilderBase
{
    Product _product;

    public BurgerBuilder()
    {
        _product = new Product("Burger");
    }

    internal override void AddIngredients()
    {
        try
        {
            _product.Add("2 x Buns");
            _product.Add("Pattice");
            _product.Add("Pickle");
            _product.Add("Veggies");
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
