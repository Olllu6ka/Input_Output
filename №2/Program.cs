using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создаем папку для нашего текста )");
            FileInfo fileInfo = new FileInfo(@"C:\Users\Мой друг\source\repos\Input Output\№2\Folder_0\Test.txt");
            FileStream stream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter streamWriter = new StreamWriter((Stream)stream, Encoding.Unicode);
            streamWriter.WriteLine("I love C#");
            streamWriter.WriteLine(": )");
            streamWriter.WriteLine(streamWriter.NewLine);
            streamWriter.Close();
            Console.WriteLine("Текст записан :)");
            StreamReader reader = fileInfo.OpenText();
            string input;
            Console.WriteLine("Вывод текста вашего файла: ");
            while ((input = reader.ReadLine()) != null) 
            {
                Console.WriteLine(input);
            }
            reader.Close();
            Console.ReadKey();
        }
    }
}
