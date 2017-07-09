namespace ExtensionMethodsDelegatesLambdaLINQ
{
    using System.Linq;

    public static class DivisibleBySevenAndThree
    {

        public static void PrintDivisibleBy7And3(this int[] arr)
        {
            var toPrint = arr
                .Where(x => x % 3 == 0 && x % 7 == 0)
                .ToArray();
        }
    }
}
