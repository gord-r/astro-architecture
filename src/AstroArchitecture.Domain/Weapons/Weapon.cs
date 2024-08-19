

using AstroArchitecture.Core.Enums;
using AstroArchitecture.Domain.Abstractions;

namespace AstroArchitecture.Domain;

public class Weapon : Entity<Guid> 
{
     public string Name { get; private set; }
     public WeaponType Type { get; private set; }
     public decimal Price { get; private set; }
     public decimal KillAward { get; private set; }
     public int Damage { get; private set; }
     public int RoundsPerShot { get; private set; }    
     public int MagazineCapacity { get; private set; }
     public int ReserveAmmoCapacity { get; private set; }
     public decimal FireRate { get; private set; }
     public decimal ReloadTime { get; private set; }
     public decimal MoveSpeed { get; private set; }
     public decimal AccurateRangeStand { get; private set; }
     public decimal AccurateRangeCrouch { get; private set; }
     public decimal FatalHeadshotRange { get; private set; }
     public decimal FatalHeadshotRangeHelmet { get; private set; }
     public decimal ArmorPenetration { get; private set; }

     public Weapon(string name, WeaponType type, decimal price, decimal killAward, int damage, int roundsPerShot, int magazineCapacity, int reserveAmmoCapacity, decimal fireRate, decimal reloadTime, decimal moveSpeed, decimal accurateRangeStand, decimal accurateRangeCrouch, decimal fatalHeadshotRange, decimal fatalHeadshotRangeHelmet, decimal armorPenetration)
     {
         Name = name;
         Type = type;
         Price = price;
         KillAward = killAward;
         Damage = damage;
         RoundsPerShot = roundsPerShot;
         MagazineCapacity = magazineCapacity;
         ReserveAmmoCapacity = reserveAmmoCapacity;
         FireRate = fireRate;
         ReloadTime = reloadTime;
         MoveSpeed = moveSpeed;
         AccurateRangeStand = accurateRangeStand;
         AccurateRangeCrouch = accurateRangeCrouch;
         FatalHeadshotRange = fatalHeadshotRange;
         FatalHeadshotRangeHelmet = fatalHeadshotRangeHelmet;
         ArmorPenetration = armorPenetration;
     }
}