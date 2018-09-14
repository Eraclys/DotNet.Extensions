using System;
using System.Collections.Generic;
using JetBrains.Annotations;
// ReSharper disable CheckNamespace

namespace DotNetStandard.Extensions
{
    public static partial class EnumerableExtensions
    {
        public static double Mean([NotNull] this IEnumerable<int> items)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            long sum = 0;
            long itemCount = 0;

            checked
            {
                foreach (var item in items)
                {
                    itemCount++;
                    sum += item;
                }
            }

            return itemCount == 0
                ? throw new InvalidOperationException("Sequence contains no elements")
                : (double) sum / itemCount;
        }

        public static double Mean([NotNull] this IEnumerable<long> items)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            long sum = 0;
            long itemCount = 0;

            checked
            {
                foreach (var item in items)
                {
                    itemCount++;
                    sum += item;
                }
            }

            return itemCount == 0
                ? throw new InvalidOperationException("Sequence contains no elements")
                : (double) sum / itemCount;
        }

        public static float Mean([NotNull] this IEnumerable<float> items)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            double sum = 0;
            long itemCount = 0;

            checked
            {
                foreach (var item in items)
                {
                    itemCount++;
                    sum += item;
                }
            }

            return itemCount == 0
                ? throw new InvalidOperationException("Sequence contains no elements")
                : (float)sum / itemCount;
        }

        public static double Mean([NotNull] this IEnumerable<double> items)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            double sum = 0;
            long itemCount = 0;

            checked
            {
                foreach (var item in items)
                {
                    itemCount++;
                    sum += item;
                }
            }

            return itemCount == 0
                ? throw new InvalidOperationException("Sequence contains no elements")
                : sum / itemCount;
        }

        public static decimal Mean([NotNull] this IEnumerable<decimal> items)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            decimal sum = 0;
            long itemCount = 0;

            checked
            {
                foreach (var item in items)
                {
                    itemCount++;
                    sum += item;
                }
            }

            return itemCount == 0
                ? throw new InvalidOperationException("Sequence contains no elements")
                : sum / itemCount;
        }
    }
}