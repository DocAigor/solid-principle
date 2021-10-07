using System;
using System.IO;
namespace SolidSrp.GoodThings
{
    //e ora?
    public class Printer
    {
        public void Print(string message) => Console.WriteLine(message);
    }

    public class FileManager
    {
        public void WriteFile(string fileName, string message) => File.WriteAllText(fileName, message);

        public string ReadFile(string fileName) => File.ReadAllText(fileName);
    }
}
