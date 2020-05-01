namespace Algorithmics.Codility
{
    public static class ToBinary
    {
        public static string ToBinaryRecursive(int n)
        {
            if (n == 0) return "0";
            if (n == 1) return "1";
            return ToBinaryRecursive(n / 2) + n % 2;
        }

        public static string ToBinaryIterative(int n)
        {
            string binary = "";

            int maxGap = 0;
            int count = 0;

            while (n >= 1)
            {
                if ((n % 2) == 1)
                {
                    if (count > maxGap) maxGap = count;
                    count = 0;
                }
                else
                {
                    count++;
                }

                binary = (n % 2) + binary;

                n /= 2;
            }
            return binary;
        }
    }
}
