using System;
using System.Collections.Generic;

class Product
{
    readonly List<string> _ingredients;
    string _ProductTitle;

    public Product(string ProductTitle)
    {
        _ingredients = new List<string>();
        _ProductTitle = ProductTitle;
    }

    internal void Add(string Ingredient)
    {
        _ingredients.Add(Ingredient);
    }

    internal void Show()
    {
        Console.WriteLine("Product : {0}", _ProductTitle);
        Console.WriteLine("Ingredients : ");
        foreach (string ingredient in _ingredients)
        {
            Console.WriteLine(ingredient);
        }
        Console.WriteLine();
    }
}
