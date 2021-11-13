using RedMonkeyLib.Models.Interfaces;

namespace RedMonkeyLib.Models
{
    public class Pistol : IWeapon
    {
        public bool HasAmmo { get; private set; }
        public int Ammo { get; private set; }
        public int MaxAmmo { get; private set; }
        public int Damage { get; private set; }
        public bool IsMelee { get; }

        public Pistol(int damage, int maxAmmo)
        {
            Damage = damage;
            MaxAmmo = maxAmmo;
            Reload();
            IsMelee = false;
        }

        public void Reload()
        {
            Ammo = MaxAmmo;
        }

        public void DoDamage(IDamagable damagable)
        {
            if (Ammo > 0)
                damagable.TakeDamage(Damage);
            else
                Reload();
        }
    }
}