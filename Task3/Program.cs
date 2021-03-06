using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки.
            В строке может быть несколько фрагментов, заключённых в фигурные скобки.
            Возможно использование вложенных фигурных скобок, необходимо, чтобы программа 
            это учитывала.
            */

            Console.WriteLine("Удаление из строки содержимого фигурных скобок с учётом вложенности");
            Console.WriteLine();

            Console.WriteLine("Введите строку:");
            string sourceString = Console.ReadLine();
            string resultString = "";

            /*
            При решении задачи учитывается, что в строке могут быть незакрытые или неоткрытыескобки.

            Задача решается через цикл, каждая итерация которого ищет в исходной строке
            парные скобки изнутри уровней вложенности и сокращает исходную строку, удаляя
            их содержимое по одному за итерацию.

            При этом части строки с непарными скобками также последовательно отсекаются 
            от исходной строки слева направо и переносятся в результирующую строку.

            В последней итерации в результирующую строку переносится остаток исходной строки,
            в котором совсем не осталось парных скобок.
            */

            while (sourceString.Length > 0)
            {
                // Ищем парные скобки "изнутри" уровней вложенности
                // Для этого начинаем поиск с положения первой ЗАКРЫВАЮЩЕЙ скобки

                int rightBracketPos = sourceString.IndexOf("}");

                if (rightBracketPos > 0)
                {
                    // Закрывающая скобка присутствует в исходной строке и находится в такой
                    // позиции, что перед ней может располагаться открывающая скобка.
                    
                    // Ищем позицию открывающей скобки слева от закрывающей
                    int leftBracketPos = sourceString.LastIndexOf("{", rightBracketPos);
                    if (leftBracketPos >= 0)
                    {
                        // Внутри строки у закрывающей скобки есть парная открывающая скобка

                        // Сокращаем исходную строку, удаляя из неё содержимое в парных скобках
                        sourceString = sourceString.Remove(leftBracketPos, 
                                                           rightBracketPos - leftBracketPos + 1);
                    }
                    else
                    {
                        // Внутри строки нет парной скобки к закрывающей скобке
                        // Переносим исходную строку целиком в результирующую строку
                        resultString += sourceString;
                        sourceString = "";
                    }
                }
                else if (rightBracketPos == 0)
                {
                    // Закрывающая скобка находится в начале строки, поэтому у неё точно нет
                    // парной открывающей скобки.

                    // Переносим закрывающую скобку в результирующую строку
                    // Исходную строку сокращаем на один символ слева
                    resultString += "}";
                    sourceString = sourceString.Substring(1);
                }
                else
                {
                    // Внутри строки нет закрывающей скобки, следовательно, нет и парных скобок.

                    // Переносим исходную строку целиком в результирующую строку
                    resultString += sourceString;
                    sourceString = "";
                }
            }

            Console.WriteLine();
            Console.WriteLine("Результат:");
            Console.WriteLine("{0}", resultString);
            Console.ReadKey();
        }
    }
}
