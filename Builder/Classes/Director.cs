class Director
{
    internal void PlaceOrder(BuilderBase builder)
    {
        builder.AddIngredients();
        builder.GetFinalProduct();
    }
}
