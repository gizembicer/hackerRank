class Result
{
    public static int lonelyinteger(List<int> a)
    {
        int result = 0;
        var sortedList = a.OrderBy(x => x).ToList();
        for (int i = 0; i < sortedList.Count - 1; i = i + 2)
        {
            if (sortedList[i] != sortedList[i + 1])
            {
                result = sortedList[i];
                break;
            }
        }
        if (result == 0)
            result = sortedList[sortedList.Count - 1];
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Console.WriteLine(Result.lonelyinteger(arr));
    }
}
