namespace ApiProject.Model
{
    public static class DummyData
    {
        public static List<Product> Products;

        static DummyData()
        {
            Products = new List<Product>()
            {
                new(){Id=1,Name="Brick",Quantity=55},
                new(){Id=2,Name="Cement",Quantity=155},
                new(){Id=3,Name="Nails",Quantity=255}
            };
        }
    }
}
