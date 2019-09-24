
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment1._1
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] words = GetWordsFromFile(@"C:\WTH\words.txt");
            string[] filteredWords = FilterWords(words, 100, false);
            OutputToFile(filteredWords);
            OutputStats(words, 100, filteredWords);
        }
        private static void OutputStats(string[] words, int wordCountValue, string[] filteredWords)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine("The portion of words that are dollar words are " + percentageOfDollarWords(words, filteredWords));
            Console.WriteLine("The most expencive word is \"" + mostExpensiveWord(words) + "\"");
            Console.WriteLine(longestShortestDollarWords(filteredWords));
            watch.Stop();
            string elapsed = watch.Elapsed.ToString();
            string elapsedMs = watch.ElapsedMilliseconds.ToString();

            Console.WriteLine("The time taken to run this program in Milliseconds is " + elapsedMs);

        }

        private static string mostExpensiveWord(string[] words)
        {
            int[] wordPrice = new int[words.Length];
            string word;

            for (int i = 0; i <= words.Length - 1; i++)
            {
                word = words[i];
                wordPrice[i] = CountingLetters(word);

            }
            return words[wordPrice.Max()];

        }

        private static double percentageOfDollarWords(string[] words, string[] filteredWords)
        {
            double percentageOfDollarWords = ((double)filteredWords.Length / (double)words.Length) * 100;
            return percentageOfDollarWords;
        }

        private static string longestShortestDollarWords(string[] filteredWords)
        {

            int largestValue = int.MinValue;
            string largestString = "";

            int shortestValue = int.MaxValue;
            string shortestString = "";

            for (int i = 0; i <= filteredWords.Length - 1; i++)
            {
                if (filteredWords[i].Length > largestValue)
                {
                    largestValue = filteredWords[i].Length;
                    largestString = filteredWords[i];
                }

                if (filteredWords[i].Length < shortestValue)
                {
                    shortestValue = filteredWords[i].Length;
                    shortestString = filteredWords[i];
                }
            }
            string Output = "The largest Dollar word is \"" + largestString + "\" \nThe shortest Dollar word is \"" + shortestString + "\"";
            return Output;
        }

        private static void OutputToFile(string[] filteredWords)
        {
            File.WriteAllLines(@"C:\WTH\dollarWords.txt", filteredWords);
        }

        public static string[] GetWordsFromFile(string filePathName)
        {
            List<string> allWords = new List<string>();
            using (StreamReader file = new StreamReader(filePathName))
            {
                while (!file.EndOfStream)
                {
                    allWords.Add(file.ReadLine());
                }
                return allWords.ToArray();
            }
        }
        public static string[] FilterWords(string[] words, int WordCountValue, bool mostExpensiveWordSwitch)
        {
            int largestPrice = 0;
            int mostExpensiveWordIndex = 0;

            List<string> results = new List<string>();
            List<string> mostExpensiveWord = new List<string>();
            foreach (var word in words)
            {

                int price = CountingLetters(word);

                if (price > largestPrice)
                {
                    largestPrice = price;
                    mostExpensiveWordIndex++;
                }

                if (price == WordCountValue)
                {
                    results.Add(word);
                }
            }

            if (mostExpensiveWordSwitch == false)
            {
                return results.ToArray();
            }
            return null;
        }

        public static int CountingLetters(String word)
        {
            int WordCountAmount = 0;
            if (word == null)
            {
                return 0;
            }
            foreach (char c in word)
            {
                if (c == 'A' || c == 'a')
                {
                    WordCountAmount += 1;
                }
                if (c == 'B' || c == 'b')
                {
                    WordCountAmount += 2;
                }
                if (c == 'C' || c == 'c')
                {
                    WordCountAmount += 3;
                }
                if (c == 'D' || c == 'd')
                {
                    WordCountAmount += 4;
                }
                if (c == 'E' || c == 'e')
                {
                    WordCountAmount += 5;
                }
                if (c == 'F' || c == 'f')
                {
                    WordCountAmount += 6;
                }
                if (c == 'G' || c == 'g')
                {
                    WordCountAmount += 7;
                }
                if (c == 'H' || c == 'h')
                {
                    WordCountAmount += 8;
                }
                if (c == 'I' || c == 'i')
                {
                    WordCountAmount += 9;
                }
                if (c == 'J' || c == 'j')
                {
                    WordCountAmount += 10;
                }
                if (c == 'K' || c == 'k')
                {
                    WordCountAmount += 11;
                }
                if (c == 'L' || c == 'l')
                {
                    WordCountAmount += 12;
                }
                if (c == 'M' || c == 'm')
                {
                    WordCountAmount += 13;
                }
                if (c == 'N' || c == 'n')
                {
                    WordCountAmount += 14;
                }
                if (c == 'O' || c == 'o')
                {
                    WordCountAmount += 15;
                }
                if (c == 'P' || c == 'p')
                {
                    WordCountAmount += 16;
                }
                if (c == 'Q' || c == 'q')
                {
                    WordCountAmount += 17;
                }
                if (c == 'R' || c == 'r')
                {
                    WordCountAmount += 18;
                }
                if (c == 'S' || c == 's')
                {
                    WordCountAmount += 19;
                }
                if (c == 'T' || c == 't')
                {
                    WordCountAmount += 20;
                }
                if (c == 'U' || c == 'u')
                {
                    WordCountAmount += 21;
                }
                if (c == 'V' || c == 'v')
                {
                    WordCountAmount += 22;
                }
                if (c == 'W' || c == 'w')
                {
                    WordCountAmount += 23;
                }
                if (c == 'X' || c == 'x')
                {
                    WordCountAmount += 24;
                }
                if (c == 'Y' || c == 'y')
                {
                    WordCountAmount += 25;
                }
                if (c == 'Z' || c == 'z')
                {
                    WordCountAmount += 26;
                }
            }
            return WordCountAmount;
        }

    }
}