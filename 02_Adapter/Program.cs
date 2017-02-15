using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
	class Program
	{
		static void Main(string[] args)
		{
			//IPrint p = new PrintBanner("IZMHR");
			//p.PrintStrong();
			//p.PrintWeak();
			//Console.WriteLine("end");
			Print2 p = new PrintBanner2("KBR");
			p.PrintWeak();
			p.PrintStrong();
			Console.WriteLine("end");
		}
	}
}
