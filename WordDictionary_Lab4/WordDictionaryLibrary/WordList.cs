using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordDictionaryLibrary
{
    public class WordList
    {
        public string Name { get; }
        public string[] Languages { get; }
        public static readonly string LocalAppDirectory = ($"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}" +
            $"\\" + $"Lab4\\");
        private List<Word> wordsList = new List<Word>();
        static string fileName = string.Empty;

        /// <summary>
        /// Designer.Sets proper names and Languages to the values of the parameters.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="languages"></param>
        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
        }
        /// <summary>
        /// Returns array with names of all lists that are stored (without the file extension).
        /// </summary>
        /// <returns></returns>
        public static string[] GetLists()
        {
            string[] list = Directory.GetFiles(LocalAppDirectory);
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = Path.GetFileNameWithoutExtension(list[i]);
            }
            return list;
        }
        /// <summary>
        /// Loads the dictionary (name entered without file extension) and returns as WordList.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static WordList LoadList(string name)
        {
            if (File.Exists(LocalAppDirectory + name + ".dat"))
            {
                fileName = LocalAppDirectory + name + ".dat";
                string[] textLines = File.ReadAllLines(fileName);
                string[] languages = textLines[0].TrimEnd(';').Split(';');
                WordList languageWords = new WordList(name, languages);

                for (int i = 1; i < textLines.Length; i++)
                {
                    string[] tokens = textLines[i].TrimEnd(';').Split(';');
                    languageWords.wordsList.Add(new Word(tokens));
                }
                return languageWords;
            }
            else
            {
                throw new IOException("File not exist.");
            }
        }

        /// <summary>
        /// Saves the list to a file with the same name as the list and file extension .dat
        /// </summary>
        public void Save()
        {
            String textToWrite = string.Empty;
            foreach (string language in Languages)
            {
                textToWrite += language + ";";
            }

            foreach (Word item in wordsList)
            {
                textToWrite += Environment.NewLine;
                foreach (var translation in item.Translations)
                {
                    textToWrite += translation + ";";
                }
            }
            fileName = LocalAppDirectory + Name + ".dat";
            File.WriteAllText(fileName, textToWrite);
        }
        /// <summary>
        /// Adds words to the list. Discard ArgumentException if the number of translations is incorrect.
        /// </summary>
        /// <param name="translations"></param>
        public void Add(params string[] translations)
        {
            if (translations.Length % Languages.Length == 0)
            {
                for (int i = 0; i < translations.Length; i += Languages.Length)
                {
                    string[] dictionary = new string[Languages.Length];
                    for (int j = 0; j < Languages.Length; j++)
                    {
                        dictionary[j] = translations[i + j];
                    }
                    wordsList.Add(new Word(dictionary));
                }
            }
            else
            {
                throw new ArgumentException("Invalid Arguement");
            }
        }
        /// <summary>
        /// translation corresponds to the index in Languages. Search the language and delete the word.
        /// </summary>
        /// <param name="translation"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool Remove(int translation, string word)
        {
            for (int i = 0; i < wordsList.Count; i++)
            {
                if (wordsList[i].Translations[translation] == word)
                {
                    wordsList.RemoveAt(i);
                    Save();
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Counts and returns the number of words in the list.
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return wordsList.Count;
        }
        /// <summary>
        /// sortByTranslation = The language in which the list is to be sorted.
        /// showTranslations = Callback that is called for each word in the list.
        /// </summary>
        /// <param name="sortByTranslation"></param>
        /// <param name="showTranslations"></param>
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            List<Word> sortedWordsList = wordsList.OrderBy(x => x.Translations[sortByTranslation]).ToList();
            foreach (Word word in sortedWordsList)
            {
                showTranslations(word.Translations);
            }
        }
        /// <summary>
        /// Randomly returns Word from the list, with randomly selected
        /// </summary>
        /// <returns></returns>
        public Word GetWordToPractice()
        {
            var rnd = new Random();
            int[] randomLanguages = { rnd.Next(Languages.Length), rnd.Next(Languages.Length) };

            while (randomLanguages[0] == randomLanguages[1])
            {
                randomLanguages[0] = rnd.Next(Languages.Length);
            }

            return new Word(randomLanguages[0], randomLanguages[1], wordsList[rnd.Next(wordsList.Count)].Translations);
        }
    }
}
