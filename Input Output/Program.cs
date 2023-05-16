using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            Wd
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(new string('-',30));
            for (int i = 0; i < 50; i++){
                DirectoryInfo directory = new DirectoryInfo($@"C:\Users\Мой друг\source\repos\Input Output\Input Output\Folder_{i}");
                if (directory.Exists){
                    Console.WriteLine("Name :  {0}", directory.Name);
                    Console.WriteLine("Full Name :  {0}", directory.FullName);
                    Console.WriteLine("Parent : {0}", directory.Parent);
                    Console.WriteLine("Creation Time : {0}", directory.CreationTime);
                }
            }
            for (int i = 0; i < 50; i++){
                DirectoryInfo directoryDelete = new DirectoryInfo($@"C:\Users\Мой друг\source\repos\Input Output\Input Output\Folder_{i}");
                if (directoryDelete.Exists){
                    directoryDelete.Delete();
                }
                else if (!directoryDelete.Exists){
                    Console.WriteLine();
                }
            }
            
            Console.ReadKey();
        }
    }
}
