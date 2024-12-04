Console.WriteLine("Lists\n");

List<string> words = ["one", "TWO123", "THREE!&^", "Four", "TWO", "THREE", "TWO", "THREE"];
GetOnlyUpperCaseWords(words);

List<string> GetOnlyUpperCaseWords(List<string> words)
{
    //your code goes here
    List<string> upperCaseWords = new List<string>();
    string upperCaseWord = "";

    foreach (string word in words)
    {
        // Check if word already exist in words list
        if (upperCaseWords.Contains(word))
        {
            continue;
        }

        bool isUpper = true;

        foreach (char letter in word)
        {
            if (!char.IsUpper(letter))
            {
                isUpper = false;
            }
        }
        if (isUpper)
        {
            upperCaseWords.Add(word);
        }

    }
    return upperCaseWords;
}

foreach (string word in GetOnlyUpperCaseWords(words))
{
    Console.WriteLine(word);
}


