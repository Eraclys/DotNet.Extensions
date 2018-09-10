using System;

namespace DotNetExtensions
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
            throw new NotImplementedException();
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