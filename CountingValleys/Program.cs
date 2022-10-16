using System.IO;

class Result
{
    public static int countingValleys(int steps, string path)
    {
        int level = 0;
        int countOfValleys = 0;
        bool seaLevel = true;
        foreach (var item in path)
        {
            switch (item)
            {
                case 'U':
                    level++;
                    break;
                case 'D':
                    if (seaLevel)
                        countOfValleys++;
                    level--;
                    break;
            }
            if (level == 0)
                seaLevel = true;
            else
                seaLevel = false;
        }
        return countOfValleys;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        Console.WriteLine(result);
    }
}
