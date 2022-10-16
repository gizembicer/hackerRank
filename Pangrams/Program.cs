class Result
{
    public static string pangrams(string s)
    {
        string alphabet = "abcdefghijklmnoprstuvwxyz";
        bool pangram = true;
        foreach (char c in alphabet)
        {
            if (s.ToLower().Contains(c))
                continue;
            else
            {
                pangram = false;
                break;
            }
        }
        if (pangram)
            return "pangram";
        else
            return "not pangram";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string result = Result.pangrams(s);

        Console.WriteLine(result);

    }
}
