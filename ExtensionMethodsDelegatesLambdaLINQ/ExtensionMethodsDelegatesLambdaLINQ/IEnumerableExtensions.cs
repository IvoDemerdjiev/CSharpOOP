namespace ExtensionMethodsDelegatesLambdaLINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static double Sum<T>(this IEnumerable<T> collection) where T : IConvertible
        {
            var doubleCollection = collection.Select(x => Convert.ToDouble(x));

            double sum = 0;

            foreach (var number in doubleCollection)
            {
                sum += number;
            }

            return sum;
        }

        public static double Product<T>(this IEnumerable<T> collection) where T : IComparable
        {
            var doubleCollection = collection.Select(x => Convert.ToDouble(x));

            double product = 0;

            foreach (var number in doubleCollection)
            {
                product *= number;
            }

            return product;
        }

        public static double Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            var doubleCollection = collection.Select(x => Convert.ToDouble(x));

            double min = Double.MaxValue;

            foreach (var number in doubleCollection)
            {
                if (number<min)
                {
                    min = number;
                }
            }

            return min;
        }

        public static double Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            var doubleCollection = collection.Select(x => Convert.ToDouble(x));

            double max = Double.MinValue;

            foreach (var number in doubleCollection)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            return max;
        }

        public static double Avarage<T>(this IEnumerable<T> collection) where T : IComparable
        {
            var doubleCollection = collection.Select(x => Convert.ToDouble(x));

            double sum = 0;

            double avarage = 0;

            foreach (var number in doubleCollection)
            {
                sum += number;
            }

            avarage = sum / doubleCollection.Count();

            return avarage;
        }
    }
}
