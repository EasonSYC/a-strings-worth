internal class Program
{
    static int WordWorth(string word)
    {
        int wordWorth = 0;

        foreach (char c in word)
        {
            wordWorth += c;
        }

        return wordWorth;
    }

    static void Main()
    {
        Console.WriteLine("Please input a sentence: ");
        string input = Console.ReadLine() ?? string.Empty;

        List<string> words = new(input.Split());
        int sentenceWorth = 0;

        string outputStr = string.Empty;

        foreach (string str in words)
        {
            int currentWordWorth = WordWorth(str);
            sentenceWorth += currentWordWorth;
            outputStr += currentWordWorth + " ";
        }

        outputStr += $"(Total sum -> {sentenceWorth})";

        Console.WriteLine(outputStr);
    }
}