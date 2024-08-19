using AstroArchitecture.Core.Enums;
using AstroArchitecture.Domain.Abstractions;

namespace AstroArchitecture.Domain;

public class Skin : Entity<Guid>
{
     public string Name { get; private set; }
     public decimal Price { get; private set; }
     public string ImageUrl { get; private set; }
     public string WeaponName { get; private set; }
     public SkinRarity Rarity { get; private set; }
     public SkinQuality Quality { get; private set; }
     public string CaseName { get; private set; }
     public bool StatTrak { get; private set; }
     public bool Souvenir { get; private set; }
     
}