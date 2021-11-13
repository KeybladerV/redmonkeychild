using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using RedMonkeyLib.Extensions;
using RedMonkeyLib.Models.Abstracts;

namespace RedMonkeyLib.Models
{
    public class Band : IEnumerable<Bandit>
    {
        private HashSet<Bandit> _bandits;
        private Bandit _bossBandit;
        private int _morale;
        private string _name;

        public string Name => _name;

        public Action<Band, Bandit> OnBossChanged;
        public Action<Band> OnDisbanded;

        public Band(string name, Bandit founder)
        {
            _bandits = new HashSet<Bandit>();
            _name = name;
            _bossBandit = founder;
            _bandits.Add(_bossBandit);
            _bossBandit.SetBand(this);
            _morale = 3;
            _bossBandit.OnIsAliveChanged += OnBossIsAliveChanged;
        }

        private void OnBossIsAliveChanged(Person boss)
        {
            if (boss.IsAlive)
                return;
            if (_morale > 0)
                PickNewBoss();
            else
                Disband();
        }

        private void PickNewBoss()
        {
            var aliveBandits = _bandits.Where(b => b.IsAlive).ToArray();
            if (!aliveBandits.Any())
            {
                Disband();
                return;
            }

            var newBoss = aliveBandits.Aggregate((b1, b2) => b1.KillCount > b2.KillCount ? b1 : b2);
            _bossBandit.OnIsAliveChanged -= OnBossIsAliveChanged;
            newBoss.OnIsAliveChanged += OnBossIsAliveChanged;
            _bossBandit = newBoss;
        }

        private void Disband()
        {
            foreach (var bandit in _bandits)
            {
                bandit.SetBand(null);
            }

            OnDisbanded?.Invoke(this);
        }

        public void AddBandit(Bandit bandit)
        {
            _bandits.Add(bandit);
            bandit.SetBand(this);
        }

        public void RemoveBandit(Bandit bandit)
        {
            _bandits.Remove(bandit);
            bandit.SetBand(null);
        }

        public void AttackBand(Band band)
        {
            foreach (var bandit in _bandits)
            {
                bandit.Attack(band.PickRandom());
            }
        }

        public IEnumerator<Bandit> GetEnumerator()
        {
            return _bandits.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}