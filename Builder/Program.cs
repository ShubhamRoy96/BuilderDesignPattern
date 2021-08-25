using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Wac Donals!\n");

            Director director = new();
            Product finalProduct = new();
            #region Efficient way without code repetition
            //System.Collections.Generic.List<BuilderBase> _builderBases = new System.Collections.Generic.List<BuilderBase>()
            //{
            //    new BurgerBuilder(),
            //    new FriesBuilder(),
            //    new DrinksBuilder()
            //};

            //foreach (BuilderBase builder in _builderBases)
            //{
            //    director.PlaceOrder(builder);
            //    finalProduct = builder.GetFinalProduct();
            //    finalProduct.ShowProductDetails();
            //}
            #endregion

            BuilderBase burgerBuilder = new BurgerBuilder();
            director.PlaceOrder(burgerBuilder);
            finalProduct = burgerBuilder.GetFinalProduct();
            finalProduct.ShowProductDetails();



            BuilderBase friesBuilder = new FriesBuilder();
            director.PlaceOrder(friesBuilder);
            finalProduct = friesBuilder.GetFinalProduct();
            finalProduct.ShowProductDetails();

            BuilderBase drinksBuilder = new DrinksBuilder();
            director.PlaceOrder(drinksBuilder);
            finalProduct = drinksBuilder.GetFinalProduct();
            finalProduct.ShowProductDetails();
        }
    }
}
