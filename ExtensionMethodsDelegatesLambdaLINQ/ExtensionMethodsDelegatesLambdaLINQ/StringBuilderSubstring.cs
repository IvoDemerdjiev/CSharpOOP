namespace ExtensionMethodsDelegatesLambdaLINQ
{

   using System.Text;

   public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder stringBuilder, int index, int lenght)
        {
            return new StringBuilder(stringBuilder.ToString(index, lenght));
        }
    }
}
