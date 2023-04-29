
string[] words = { "apple", "banana", "cherry", "grape", "lemon" };
Random random = new Random();
string word = words[random.Next(0, words.Length)];
char[] display = new char[word.Length];

for (int i = 0; i < display.Length; i++)
{
    display[i] = '*';
}

int remainingAttempts = 3;
bool wordGuessed = false;

while (remainingAttempts > 0 && !wordGuessed)
{
    Console.WriteLine("Guess a letter:");
    char guess = Console.ReadLine()[0];

    bool letterFound = false;

    for (int i = 0; i < word.Length; i++)
    {
        if (word[i] == guess)
        {
            display[i] = guess;
            letterFound = true;
        }
    }

    if (!letterFound)
    {
        remainingAttempts--;
    }

    Console.WriteLine(display);

    if (new string(display) == word)
    {
        wordGuessed = true;
    }
}

if (wordGuessed)
{
    Console.WriteLine("You won!");
}
else
{
    Console.WriteLine("Game over.");
}

Console.ReadLine();
