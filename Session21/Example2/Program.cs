string GetLongestWord(string filePath)
{
    string content = File.ReadAllText(filePath);
    string[] words = content.Split(' ');
    string longestWord = "";

    foreach (string word in words)
    {
        if (word.Length > longestWord.Length)
        {
            longestWord = word;
        }
    }

    return longestWord; 
}