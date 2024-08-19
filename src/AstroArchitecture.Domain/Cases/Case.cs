using AstroArchitecture.Domain.Abstractions;

namespace AstroArchitecture.Domain
{
    public class Case : Entity<Guid>
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string ImageUrl { get; private set; }
        public List<Weapon> Weapons { get; private set; }

        public Case(string name, decimal price, string imageUrl, List<Weapon> weapons)
        {
            Name = name;
            Price = price;
            ImageUrl = imageUrl;
            Weapons = weapons;
        }
    }
}