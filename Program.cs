using System;

namespace dotNetOnMac
{
    class Program
    {
        //https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/run
        //call "dotnet run"
        static void Main(string[] args)
        {
            dynamic rtn = "Hello World!";
            rtn = Utils.getStuff();
            Console.WriteLine(rtn.stuff);
            
        }
    }
}
