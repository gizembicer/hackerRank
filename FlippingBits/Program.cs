using System.IO;

class Result
{
    public static long flippingBits(long n)
    {
        var binary = Convert.ToString(n, 2);
        binary = binary.PadLeft(32, '0');
        string transformedBinary = string.Empty;
        foreach (var item in binary)
        {
            switch (item)
            {
                case '1':
                    transformedBinary += '0';
                    break;
                case '0':
                    transformedBinary += '1';
                    break;
            }
        }
        
        return Convert.ToInt64(transformedBinary, 2);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.flippingBits(n);

            Console.WriteLine(result);
        }
    }
}
