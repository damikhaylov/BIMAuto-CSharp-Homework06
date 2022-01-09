using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные
            пробелом. Знаки препинания не используются. Составить программу, определяющую является
            ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала
            на лапу Азора»).
            */

            Console.WriteLine("Определение, является ли предложение палиндромом");
            Console.WriteLine();

            Console.WriteLine("Введите предложение:");
            string s = Console.ReadLine();

            // Используем разновидность метода Split, вычищающий массив от пустых элементов
            // при повторяющихся пробелах
            char[] delimeters = new char[] { ' ' };
            string[] words = s.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

            // Собираем строку без пробелов и преобразуем к нижнему регистру
            s = String.Join("", words);
            s = s.ToLower();
            Console.WriteLine(s);

            bool maybePalindrome = true;

            // Попарно сравниваем символы, зеркальные относительно середины строки
            for (int i=0; i < s.Length/2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    maybePalindrome = false;
                    break;
                }
            }

            Console.WriteLine();
            if (maybePalindrome)
            {
                Console.WriteLine("Предложение является палиндромом");
            }
            else
            {
                Console.WriteLine("Предложение не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
