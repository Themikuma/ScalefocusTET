using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            WordProvider wp = new WordProvider();
            var word = wp.GetWord();
            var encodedWord = new string('*', word.Length);
            Console.WriteLine(encodedWord);
        }
    }
}
