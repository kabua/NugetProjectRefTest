using System;
using CoreDll1;

namespace NugetProjectRefTest2
{
    class Program
    {
        static void Main(string[] args)
        {
	        var net = new TestNet();
	        Console.WriteLine(net.Name);
        }
	}
}
