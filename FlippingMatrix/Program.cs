class Result
{
    public static int diagonalDifference(List<List<int>> arr)
    {
        if (arr.Count > 2)
        {
            int firstMax = 0;
            int firstMin = 0;
            int secondMin = 0;
            int secondMax = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                arr[i] = arr[i].OrderByDescending(x => x).ToList();
            }
            for (int i = 0; i < arr[1].Count; i++)
            {

            }
        }
        return 0;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);
        Console.WriteLine(result);

    }
}
