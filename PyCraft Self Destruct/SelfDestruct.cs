using System;
using System.IO;

namespace PyCraft_Self_Destruct
{
    class SelfDestruct
    {
        //these are the pycraft main files, you shouldn't get banned for having discord rpc, or bunifu, but if you want to delete those you can add in the paths
        public static string pycraft = @"C:\Visual Studio Projects\PyCraft\bin\Debug\PyCraft.exe";
        public static string vamemory = @"C:\Visual Studio Projects\PyCraft\bin\Debug\VAMemory.dll";
        public static string dir = @"C:\Visual Studio Projects\PyCraft\bin\Debug";
        static void Main(string[] args)
        {
            System.Console.Title = "PyCraft Self Destruct";
            System.Console.WriteLine("                                              //PyCraft Self Destruct//");
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("Are you sure you want to self destruct? press ENTER to self destruct");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            if (consoleKeyInfo.Key == ConsoleKey.Enter)
            {
                File.Delete(pycraft);
                File.Delete(vamemory);
                System.Console.WriteLine("");
                System.Console.WriteLine("");
                System.Console.WriteLine($"Deleted PyCraft and VAMemory at {dir}. Press ENTER close this console");
            }
            else
            {

            }
            System.Console.ReadLine();
        }
    }
}
