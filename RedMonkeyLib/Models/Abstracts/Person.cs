using System;
using RedMonkeyLib.Models.Interfaces;

namespace RedMonkeyLib.Models.Abstracts
{
    public abstract class Person : IDamagable
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }

        public int MaxHP { get; protected set; }

        private int _currentHP;

        public int HP
        {
            get => _currentHP;
            protected set
            {
                _currentHP = value;
                if (_currentHP > MaxHP)
                    _currentHP = MaxHP;
                OnHPChanged?.Invoke(this);
                IsAlive = _currentHP > 0;
            }
        }

        private bool _isAlive;

        public bool IsAlive
        {
            get => _isAlive;
            protected set
            {
                if (value == _isAlive)
                    return;
                _isAlive = value;
                OnIsAliveChanged?.Invoke(this);
            }
        }

        public event Action<Person> OnHPChanged;
        public event Action<Person> OnIsAliveChanged;

        public Person(string firstname, string lastname, int maxHp = 100)
        {
            FirstName = firstname;
            LastName = lastname;
            MaxHP = maxHp;
            MaxHeal();
        }

        public virtual void MaxHeal()
        {
            HP = MaxHP;
        }

        public virtual void Resurrect()
        {
            IsAlive = true;
            MaxHeal();
        }

        public virtual void TakeDamage(int damage)
        {
            if (IsAlive)
                HP -= damage;
        }

        public virtual void HealDamage(int damage)
        {
            if (IsAlive)
                HP += damage;
        }
    }
}