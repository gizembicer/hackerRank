class Result
{
    public static int marsExploration(string s)
    {
        int numberOfChangedLetters = 0;
        int numberOfSosMessages = s.Length / 3;
        string expectedSosMessage = string.Empty;
        for (int i = 0; i < numberOfSosMessages; i++)
        {
            expectedSosMessage += "SOS";
        }
        for (int i = 0; i < s.Length; i++)
        {
            if(s[i] != expectedSosMessage[i])
                numberOfChangedLetters++;
        }
        return numberOfChangedLetters;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        int result = Result.marsExploration(s);
        Console.WriteLine(result);
    }
}
