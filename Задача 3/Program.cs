using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Указываем путь к текстовому файлу
            string path = @"D:\4 Обучение\Модуль 2\Самостоятельная работа 8. Работа с файловой системой\Задача 3\текст.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                //Находим количество строк в файле
                int strings = File.ReadAllLines(path).Length;
                Console.WriteLine("Количество строк в файле {0}",strings);
                //Вводим строковую переменную, куда записываем весь текст и удаляем из него перенос строки
                string a = "";
                a = sr.ReadToEnd().Replace("\n","");
                string[] number_of_words = a.Split();
                //Находим количество слов в файле
                Console.WriteLine("Количество слов в файле {0}",number_of_words.Length);
                //Находим количество символов в тексте. Здесь не понял как удалить символ переноса строки из текста, поэтому вычел количество строк, уменьшенное на 1.
                int number_of_chars =a.Length;
                Console.WriteLine("Количество символов в файле (с учетом пробелов) {0}",number_of_chars-(--strings));
            }
            Console.ReadKey();  
        }
    }
}
