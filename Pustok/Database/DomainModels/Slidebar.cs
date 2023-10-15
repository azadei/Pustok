using static System.Net.Mime.MediaTypeNames;

namespace Pustok.Database.DomainModels
{
    public class Slidebar
    {
        public Slidebar()
        {
            Id = ++DbContext._slidebarId;
        }

        public Slidebar(int id, string title, string description, string offer, string order)
        {
            Id = ++DbContext._slidebarId;
            Title = title;
            Description = description;
            Offer = offer;
            Order = order;

        }

        public int Id { get; set; } 

        public string Title { get; set; }

        public string Description { get; set; }

        public string Order { get; set; }

        public string Offer { get; set; }
    }
}
