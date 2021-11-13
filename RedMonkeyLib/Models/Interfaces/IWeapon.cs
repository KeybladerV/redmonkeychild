namespace RedMonkeyLib.Models.Interfaces
{
    public interface IWeapon
    {
        void DoDamage(IDamagable damagable);
        bool HasAmmo { get; }
        int MaxAmmo { get; }
        int Ammo { get; }
        int Damage { get; }
        bool IsMelee { get; }

        void Reload();
    }
}