// See https://aka.ms/new-console-template for more information

string val = "shubham";
//--------------------------------------------
//for reverse to string
//val = reverse(val);
//Console.WriteLine(val);
//--------------------------------------------
//for duplicate string coount
Main(val);



static string reverse(string name)
{
    char[] charArray = new char[name.Length];

    for (int s = name.Length - 1, j = 0; s >= 0; s--, j++)
    {
        charArray[j] = name[s];
    }
    return new string(charArray);
}



    static void Main(string input)
    {
        Dictionary<char, int> charCount = CountDuplicateChars(input);

        Console.WriteLine("Duplicate Characters and their Counts:");
        foreach (var kvp in charCount)
        {
            if (kvp.Value > 1)
            {
                Console.WriteLine($"Character '{kvp.Key}' appears {kvp.Value} times.");
            }
        }
    }

    static Dictionary<char, int> CountDuplicateChars(string input)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        return charCount;
    }

