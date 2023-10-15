using Pustok.Database.DomainModels;
using System.Collections.Generic;

namespace Pustok.Database
{
    public class DbContext
    {
        public static int _productId;

        public static List<Product> _products = new List<Product>
        {
            new Product(++_productId, "American", "Description", "Green", "Small", 200),
            new Product(++_productId, "Black Eyed Susan", "Description", "Blue", "Small", 25.45m),
            new Product(++_productId, "Bleeding Heart", "Description", "Green", "Small", 30.45m),
            new Product(++_productId, "Cuba", "Description", "Red", "Small", 50)
        };

        public static int _slidebarId;

        public static List<Slidebar> _slidebars = new List<Slidebar>
        {
            new Slidebar(++_slidebarId, "65% OFF", "NEW PLANT", "Pronia, With 100% Natural Organic & PlantShop", "Discover Now"),
        };
    }
}
