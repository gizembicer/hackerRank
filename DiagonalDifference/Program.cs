class Result
{
    public static int diagonalDifference(List<List<int>> arr)
    {
        int numberOfRows = arr.Count;
        int firstDiagonal = 0, secondDiagonal = 0;
        for (int i = 0; i < numberOfRows; i++)
        {
            firstDiagonal += arr[i][i];
            secondDiagonal += arr[i][numberOfRows - 1 - i];
        }
        return Math.Abs(firstDiagonal - secondDiagonal);
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
