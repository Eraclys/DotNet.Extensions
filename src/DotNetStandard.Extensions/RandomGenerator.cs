using System;

namespace DotNetStandard.Extensions
{
    public sealed class RandomGenerator : IRandomGenerator
    {
        private readonly Random _inner;

        public static readonly IRandomGenerator Default = new RandomGenerator();

        public RandomGenerator()
        {
            _inner = new Random();
        }

        public RandomGenerator(int seed)
        {
            _inner = new Random(seed);
        }

        public int Next()
        {
            return _inner.Next();
        }

        public int Next(int minValue, int maxValue)
        {
            return _inner.Next(minValue, maxValue);
        }

        public int Next(int maxValue)
        {
            return _inner.Next(maxValue);
        }

        public double NextDouble()
        {
            return _inner.NextDouble();
        }

        public void NextBytes(byte[] buffer)
        {
            _inner.NextBytes(buffer);
        }
    }
}