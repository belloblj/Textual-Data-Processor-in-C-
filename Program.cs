using System.Text.RegularExpressions;

namespace Textual_Data_with_Strings
        { /* Write a C# program that performs the following operations on a given text:

        
        Word Count: Calculate and display the number of words in the paragraph.
        Vowel Count: Calculate and display the number of vowels (a, e, i, o, u) in the paragraph.
        Word Frequency Count: Calculate and display all unique word frequencies in the paragraph in ascending order of words.
        Constraints:
        Consider words to be sequences of characters separated by spaces.
        Ignore the case when counting vowels.
        Punctuation should not be considered as part of a word when calculating word frequency.
        Tips:
        Use the Split method to break the paragraph into words.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a paragraph of text: "); //Input: Prompt the user to enter a paragraph of text.
            string paragraph = Console.ReadLine(); // store input as paragraph

            string lowerText = paragraph.ToLower(); //convert entire paragraph to lowercase

            string[] enteredWords = Regex.Split(paragraph, @"[\s/]+"); //split the paragraphs to words on / \s for tabs and newlines
            string[] extractedWords = enteredWords //
            .Select(word => Regex.Replace(word, "[^a-zA-Z]", ""))//remove punctuation
            .Where(word => !string.IsNullOrWhiteSpace(word)) //remove spaces and empty entries
            .ToArray();  // convert to an array
            int wordCount = extractedWords.Length;
            int vowelCount = lowerText.Count(c => "aeiou".Contains(c)); //check for vowels and take count

            Dictionary<string, int> wordFreq = new Dictionary<string, int>(); //use dictionary to store word frequencies
            foreach (string word in extractedWords) //use foreach loop to take count of each ectracted word, record 1 for first existence and increment for more
            {
                string normalizedWord = word.ToLower();
                if (wordFreq.ContainsKey(normalizedWord)) //if word exist in Dictionary, it adds at each time it finds more of it
                    wordFreq[normalizedWord]++;
                else
                    wordFreq[normalizedWord] = 1; //if there's only 1 of the word, it records the count as 1
            }

            var sortedFreq = wordFreq.OrderBy(pair => pair.Key);

            Console.WriteLine($"Word Count: {wordCount}"); //print count of total words
            Console.WriteLine($"Vowel Count: {vowelCount}"); //print count of vowels
            Console.WriteLine("Word Frequency Count:");
            Console.WriteLine($"{"",6}{"Word"} Frequency:");//format the output to match the examples in the question. 6 character column to Righ-Align
            foreach (var pair in sortedFreq)
            {
                Console.WriteLine($"{pair.Key, 12} {"",5} {pair.Value}"); // 12 and 5 character column for Right-Align
            }


        }
    }
}
