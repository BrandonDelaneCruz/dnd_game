using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDGame.Weapons
{
    public abstract class Weapon
    {
        public int Cost { get; set; }
        public string WeaponDamage { get; set; } = "";
        public string VersatileWeaponDamage { get; set; } = "";
        public int NumberOfDIce { get; set; }
        public string DamageType { get; set; } = "";
        public double Weight { get; set; }
        public bool LightProperty { get; set; } = false;
        public bool FinesseProperty { get; set; } = false;
        public bool VersatileProperty { get; set; } = false;
        public bool ThrownProperty { get; set; } = false;
        public bool HeavyProperty { get; set; } = false;
        public bool TwoHandedProperty { get; set; } = false;
    }

    #region Simple Melee Weapons
    public abstract class SimpleMeleeWeapons : Weapon
    {

    }
    public class Club : SimpleMeleeWeapons
    {
        public Club()
        {
            Cost = 10;
            WeaponDamage = "d4";
            NumberOfDIce = 1;
            DamageType = "bludgeoning";
            Weight = 2;
            LightProperty = true;
        }
    }
    public class Dagger : SimpleMeleeWeapons
    {
        public Dagger()
        {
            Cost = 200;
            WeaponDamage = "d4";
            NumberOfDIce = 1;
            DamageType = "piercing";
            Weight = 1;
            LightProperty = true;
            FinesseProperty = true;
            ThrownProperty = true;
        }
    }
    public class GreatClub : SimpleMeleeWeapons
    {
        public GreatClub()
        {
            Cost = 20;
            WeaponDamage = "d8";
            NumberOfDIce = 1;
            DamageType = "bludgeoning";
            Weight = 10;
            TwoHandedProperty = true;

        }
    }
    public class Handaxe : SimpleMeleeWeapons
    {
        public Handaxe()
        {
            Cost = 500;
            WeaponDamage = "d6";
            NumberOfDIce = 1;
            DamageType = "slash";
            Weight = 2;
            LightProperty = true;
            ThrownProperty = true;
        }
    }
    public class Javelin : SimpleMeleeWeapons
    {
        public Javelin()
        {
            Cost = 50;
            WeaponDamage = "d6";
            NumberOfDIce = 1;
            DamageType = "pirceing";
            Weight = 2;
            ThrownProperty = true;
        }
    }
    public class LightHammer : SimpleMeleeWeapons
    {
    public LightHammer()
        {
            Cost = 200;
            WeaponDamage = "d4";
            NumberOfDIce = 1;
            DamageType = "bludgeoning";
            Weight = 2;
            LightProperty = true;
            ThrownProperty = true;
        }
    }
    public class Mace : SimpleMeleeWeapons
    {
    public Mace()
        {
            Cost = 500;
            WeaponDamage = "d6";
            NumberOfDIce = 1;
            DamageType = "bludgeoning";
            Weight = 4;
        }
    }
    public class Quarterstaff : SimpleMeleeWeapons
    {
    public Quarterstaff()
        {
            Cost = 20;
            WeaponDamage = "d6";
            NumberOfDIce = 1;
            TwoHandedProperty = true;
            VersatileWeaponDamage = "d8";
            DamageType = "bludgeoning";
            Weight = 4;
            VersatileProperty = true;
        }
    }
    public class Sickle : SimpleMeleeWeapons
    {
    public Sickle()
        {
            Cost = 100;
            WeaponDamage = "d4";
            NumberOfDIce = 1;
            DamageType = "slashing";
            Weight = 2;
            LightProperty = true;
        }
    }
    public class Spear : SimpleMeleeWeapons
    {
    public Spear()
        {
            Cost = 100;
            WeaponDamage = "d6";
            TwoHandedProperty = true;
            VersatileWeaponDamage = "d8";
            NumberOfDIce = 1;
            DamageType = "piercing";
            Weight = 3;
            ThrownProperty = true;
            VersatileProperty = true;
        }
    }
    #endregion

    #region Simple Ranged Weapons
    public class SimpleRangedWeapons : Weapon
    {
        public bool LoadingProperty { get; set; } = false;
    }
    public class LightCrossbow : SimpleRangedWeapons
    {
        public LightCrossbow()
        {
            Cost = 2500;
            WeaponDamage = "d8";
            NumberOfDIce = 1;
            DamageType = "piercing";
            Weight = 5;
            LoadingProperty = true;
            TwoHandedProperty = true;
        }
    }
    public class Dart : SimpleRangedWeapons
    {
        public Dart()
        {
            Cost = 5;
            WeaponDamage = "d4";
            NumberOfDIce = 1;
            DamageType = "piercing";
            Weight = 0.25;
            FinesseProperty = true;
            ThrownProperty = true;
        }
    }
    public class Shortbow : SimpleRangedWeapons
    {
        public Shortbow()
        {
            Cost = 2500;
            WeaponDamage = "d6";
            NumberOfDIce = 1;
            DamageType = "piercing";
            Weight = 2;
            TwoHandedProperty = true;
        }
    }

    #endregion

    #region Martial Melee Weapons
    public class MartiakMeleeWeapons : Weapon
    {

    }
    #endregion

    #region Martial Ranged Weapons
    public class MartialRangedWeapons : Weapon
    {

    }
    #endregion
}
