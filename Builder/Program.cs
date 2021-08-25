using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Wac Donals!\n");

            Director director = new();

            #region Efficient way without code repetition
            //List<BuilderBase> _builderBases = new List<BuilderBase>()
            //{
            //    new BurgerBuilder(),
            //    new FriesBuilder(),
            //    new DrinksBuilder()
            //};

            //foreach (BuilderBase builder in _builderBases)
            //{
            //    director.PlaceOrder(builder);
            //    builder.GetResult().Show();
            //} 
            #endregion

            BuilderBase burgerBuilder = new BurgerBuilder();
            director.PlaceOrder(burgerBuilder);
            burgerBuilder.GetResult().Show();


            BuilderBase friesBuilder = new FriesBuilder();
            director.PlaceOrder(friesBuilder);
            friesBuilder.GetResult().Show();

            BuilderBase drinksBuilder = new DrinksBuilder();
            director.PlaceOrder(drinksBuilder);
            drinksBuilder.GetResult().Show();
        }
    }
}
