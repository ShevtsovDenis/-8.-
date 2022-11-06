using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем файл с 10 рандомными числами от 0 до 15. Путь к файлу относительный
            string path = "Numbers.txt";
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(0, 15));
                }
            }
            //Вводим переменную суммы
            int sum = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    //Вводим переменную и присваиваем ей значение считанной строки. Значение строки конвертируем в int32
                    int number = Convert.ToInt32(sr.ReadLine());
                    sum += number;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
