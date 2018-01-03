using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDll1;

namespace NugetProjectRefTest
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
