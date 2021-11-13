using System;
using System.Linq;
using RedMonkeyLib.Models;

namespace RedMonkeyLib.Generators
{
    public class BanditGenerator
    {
        private Random _random;
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";
        const string nums = "0123456789";

        public BanditGenerator()
        {
            _random = new Random();
        }

        public Bandit[] GenerateArray(int count)
        {
            var bandits = new Bandit[count];
            for (int i = 0; i < count; i++)
            {
                bandits[i] = Generate();
            }

            return bandits;
        }

        public Bandit Generate()
        {
            return new(GenerateName(), GenerateName(), _random.Next(75, 100));
        }

        public string GenerateName(bool withNums = false)
        {
            return Enumerable.Repeat(chars, _random.Next(3, 10))
                .Select(s => s[_random.Next(s.Length)]).ToString();
        }
    }
}