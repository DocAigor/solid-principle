using System;
using System.IO;

namespace SolidSrp.BadThings
{
    //qual è la responsabilità di questa classe? 
    public class AllInOne
    {
        public void Print(string message) => Console.WriteLine(message);

        public void WriteFile(string fileName, string message) => File.WriteAllText(fileName, message);

        public string ReadFile(string fileName) => File.ReadAllText(fileName);

    }
}
