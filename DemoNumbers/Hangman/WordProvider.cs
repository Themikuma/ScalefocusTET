using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class WordProvider
    {
        private int linesCount;
        private const string WORDS_FILE_PATH = "../../Words.txt";
        public WordProvider()
        {
            linesCount = CountLines();
        }

        private int CountLines()
        {
            int i = 0;
            using (StreamReader sr = new StreamReader(WORDS_FILE_PATH))
            {
                while (!sr.EndOfStream)
                {
                    sr.ReadLine();
                    i++;
                }
            }
            return i;
        }

        public string GetWord()
        {
            Random r = new Random();
            string word = "";
            int lineNumber = r.Next(linesCount);
            using (StreamReader sr = new StreamReader(WORDS_FILE_PATH))
            {
                for (int i = 0; i <= lineNumber; i++)
                {
                    word = sr.ReadLine();
                }
            }
            return word;
        }
    }
}
