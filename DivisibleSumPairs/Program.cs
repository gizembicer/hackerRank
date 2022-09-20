class Result
{
    public static int divisibleSumPairs(int n, int k, List<int> arr)
    {
        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            for (int l = i + 1; l < n; l++)
            {
                if ((arr[i] + arr[l]) % k == 0)
                    counter++;
            }
        }
        return counter;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        var n = Console.ReadLine().Split(' ');


        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Console.WriteLine(Result.divisibleSumPairs(Convert.ToInt32(n[0]), Convert.ToInt32(n[1]), arr));
    }
}
