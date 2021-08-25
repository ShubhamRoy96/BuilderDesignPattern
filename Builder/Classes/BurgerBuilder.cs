using System;

class BurgerBuilder : BuilderBase
{
    Product _product;

    public BurgerBuilder()
    {
        _product = new Product();
        _product.AddProductTitle("Burger");
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

    internal override Product GetFinalProduct()
    {
        return _product;
    }
}
