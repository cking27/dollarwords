using System;
using System.Collections.Generic;
using System.Linq;

namespace DollarWordsNs
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dollarWords = new DollarWords();

            var wordList = new[]
            {
                "job",
                "Practice",
                "ironized",
                "non-stop"
            };

            var results = dollarWords.GetResults(wordList);

            foreach (var result in results)
            {
                // should print "ironized"
                Console.WriteLine(result);
            }
        }
    }

    public class DollarWords
    {
        public IEnumerable<string> GetResults(IEnumerable<string> wordList)
        {
            // TODO: Implement solution here

        }
    }
}
