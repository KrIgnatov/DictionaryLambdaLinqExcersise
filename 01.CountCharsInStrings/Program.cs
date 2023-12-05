string input = Console.ReadLine();

CountAndPrintCharOccurrences(input);

static void CountAndPrintCharOccurrences(string input)
{
    Dictionary<char, int> charCount = new Dictionary<char, int>();

    foreach (char character in input)
    {
        if (character != ' ')
        {
            if (charCount.ContainsKey(character))
            {
                charCount[character]++;
            }
            else
            {
                charCount[character] = 1;
            }
        }
    }

    foreach (var pair in charCount)
    {
        char character = pair.Key;
        int occurrences = pair.Value;

        Console.WriteLine($"{character} -> {occurrences}");
    }
}
