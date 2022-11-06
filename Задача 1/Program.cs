using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Указываем путь считываемой директории
            string path = @"D:\4 Обучение\Модуль 2\lab7";
            //Создаем строковый массив с файлами (путь, все расширения,считывать все дериктории)
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            //Выводим имя каждого файла в новой строке
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
