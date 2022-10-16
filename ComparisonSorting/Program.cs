using System.IO;

class Result
{
    public static List<int> countingSort(List<int> arr)
    {
        int[] returnList = new int[100];
        int index = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            index = arr[i];
            returnList[index] = returnList[index] + 1;
        }

        return returnList.ToList();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.countingSort(arr);

        Console.WriteLine(String.Join(" ", result));
    }
}
