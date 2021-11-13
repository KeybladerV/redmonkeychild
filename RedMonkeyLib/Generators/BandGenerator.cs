using System;
using RedMonkeyLib.Extensions;
using RedMonkeyLib.Models;

namespace RedMonkeyLib.Generators
{
    public class BandGenerator
    {
        private BanditGenerator _banditGenerator;
        private Random _random;

        public BandGenerator() : this(new BanditGenerator())
        {
        }

        public BandGenerator(BanditGenerator banditGenerator)
        {
            _banditGenerator = banditGenerator;
            _random = new Random();
        }

        public Band[] GenerateArray(int count, int minBandits, int maxBandits)
        {
            var bands = new Band[count];
            for (int i = 0; i < count; i++)
            {
                bands[i] = Generate(_random.Next(minBandits, maxBandits));
            }

            return bands;
        }

        public Band Generate(int banditCount)
        {
            var bandits = _banditGenerator.GenerateArray(banditCount);
            var founder = bandits.PickRandom();

            var newBand = new Band(_banditGenerator.GenerateName(true), founder);
            foreach (var bandit in bandits)
            {
                newBand.AddBandit(bandit);
            }

            return newBand;
        }
    }
}