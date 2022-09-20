class Result
{
    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> result = new List<int>();
        foreach (int i in grades)
        {
            if (i >= 38 && i % 5 > 2)
                result.Add(i + (5 - i % 5));
            else
                result.Add(i);
        }
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Console.WriteLine(String.Join("\n", Result.gradingStudents(arr)));
    }
}
