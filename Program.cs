using System;

namespace dotNetOnMac
{
    class Program
    {
        //call "dotnet run"
        static void Main(string[] args)
        {
            dynamic rtn = "Hello World!";
            rtn = Utils.getStuff();
            Console.WriteLine(rtn.stuff);
            
        }
    }
}
