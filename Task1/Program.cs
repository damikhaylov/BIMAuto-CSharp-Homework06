using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные 
            пробелом. Знаки препинания не используются. Найти самое длинное слово в строке.
            */

            Console.WriteLine("Определение самого длинного слова в предложении");
            Console.WriteLine();

            Console.WriteLine("Введите предложение:");
            string s = Console.ReadLine();
            string[] words = s.Split(' ');
            string maxWord = "";

            foreach (string word in words)
            {
                if (word.Length > maxWord.Length)
                {
                    maxWord = word;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Самое длинное слово (или первое из наиболее длинных) - {0}", maxWord);
            Console.ReadKey();
        }
    }
}
