using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace _3
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Напишите приложение для поиска заданного файла на диске.Добавьте код,
        //использующий класс FileStream и позволяющий просматривать файл в текстовом окне. В
        //заключение добавьте возможность сжатия найденного файла.
        static void Main(string[] args)
        {
            Console.WriteLine("Поиск Файла");
            string[] logic = Directory.GetLogicalDrives();
            Console.WriteLine("Это ваши диски:  ");
            foreach (var item in logic){
                Console.Write(item+"  ");
            } 
            Console.Write("\nВведите диск на котором будем искать: ");
            string path = Console.ReadLine();
            Directory.GetFiles(path).ToList().ForEach(f => Console.WriteLine(Path.GetFileName(f)));
            Console.Write("Введите вайл который вы хотите сжать: ");
            string sourcefile = Console.ReadLine();
            FileInfo fileInfo = new FileInfo(sourcefile);
            string direct = fileInfo.DirectoryName;
            try
            {
                FileStream stream = File.OpenRead($@"{direct}\{sourcefile}");
                FileStream filedestinaton = File.Create($@"{direct}\archive.zip");
                GZipStream zipStream = new GZipStream(filedestinaton, CompressionMode.Compress);
                int theByte = stream.ReadByte();
                while (theByte != -1){
                    zipStream.WriteByte((byte)theByte);
                    theByte = stream.ReadByte();
                }
                zipStream.Close();
                stream.Close();
                Console.WriteLine("Файл найден и заархивирован !");
            }
            catch (Exception e){
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
