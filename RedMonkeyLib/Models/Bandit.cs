using System;
using RedMonkeyLib.Models.Abstracts;
using RedMonkeyLib.Models.Interfaces;

namespace RedMonkeyLib.Models
{
    public class Bandit : Person, IEquipmenter
    {
        private IWeapon _weapon;    
        public IWeapon Weapon { get; private set; }
        public IArmor Armor { get; private set; }

        public Band Band { get; private set; }
        public int KillCount { get; private set; }

        private Random _random;

        public Bandit(string firstname, string lastname, int maxHP = 100) : base(firstname, lastname, maxHP)
        {
            _random = new Random();
        }

        public Bandit(string firstname, string lastname, int maxHP = 100, IWeapon weapon = null,
            IArmor armor = null) : this(firstname,
            lastname, maxHP)
        {
            EquipWeapon(weapon);
            EquipArmor(armor);
        }

        public void EquipWeapon(IWeapon weapon)
        {
            Weapon = weapon;
        }

        public void EquipArmor(IArmor armor)
        {
            Armor = armor;
        }

        public override void TakeDamage(int damage)
        {
            damage -= Armor?.DamageReduction ?? 0;
            base.TakeDamage(damage);
        }

        public void SetBand(Band band)
        {
            Band = band;
        }

        public void Attack(Person person)
        {
            if (_weapon == null)
                person.TakeDamage(_random.Next(1, 10));
            else
                _weapon.DoDamage(person);

            if (person is Bandit bandit)
            {
                if (bandit.Band == Band)
                    Band.RemoveBandit(this);
            }

            KillCount += person.IsAlive ? 0 : 1;
        }
    }
}