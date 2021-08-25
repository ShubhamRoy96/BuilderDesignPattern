using System;
using System.Collections.Generic;

class Product
{
    readonly List<string> _ingredients;
    string _productTitle;

    public Product()
    {
        _ingredients = new List<string>();
    }

    internal void AddProductTitle(string Title)
    {
        _productTitle = Title;
    }

    internal void Add(string Ingredient)
    {
        _ingredients.Add(Ingredient);
    }

    internal void ShowProductDetails()
    {
        Console.WriteLine("Product : {0}", _productTitle);
        Console.WriteLine("Ingredients : ");
        foreach (string ingredient in _ingredients)
        {
            Console.WriteLine(ingredient);
        }
        Console.WriteLine();
    }
}
