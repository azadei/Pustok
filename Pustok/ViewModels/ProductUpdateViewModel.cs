namespace Pustok.ViewModels
{
    public class ProductUpdateViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }    
    }

    public class SlidebarUpdateViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Offer { get; set; }
        public string Order { get; set; }
    }
}
