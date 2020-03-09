using System;
using System.Collections.Generic;

namespace dictionary2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("Word", "Excited");
            excitedWord.Add("Definition", "Having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("Part of speech", "Adjective");
            excitedWord.Add("Example sentence", "I am excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list
            Dictionary<string, string> funWord = new Dictionary<string, string>();

            funWord.Add("Word", "Fun");
            funWord.Add("Definition", "Enjoyment, amusement, or lighthearted pleasure");
            funWord.Add("Part of speech", "Adjective");
            funWord.Add("Example sentence", "The children were having fun in the play area");

            dictionaryOfWords.Add(funWord);

            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> word in dictionaryOfWords)
            {

                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> wordData in word)

                {
                    Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                }
            }
        }
    }
}
