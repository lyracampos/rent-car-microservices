namespace RentCar.Catalog.Api.Entities
{
    public class Category
    {
        public Category(string name, string description)
        {
            Name = name;
            Description = description;
            Slug = Name.ToLowerInvariant().Replace(" ", "-");
        }

        public string Name { get; private set; }
        public string Slug { get; private set; }
        public string Description { get; private set; }
    }
}