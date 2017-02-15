using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
	class Program
	{
		static void Main(string[] args)
		{
			Display d1 = new StringDisplay("Hello World");
			d1.Show();

			Console.WriteLine();

			Display d2 = new SideBorder(d1, '#');
			d2.Show();

			Console.WriteLine();

			Display d3 = new FullBorder(d2);
			d3.Show();

			Console.WriteLine();

			Display d4 = new SideBorder(
				new FullBorder(
					new SideBorder(
						new FullBorder(
							new StringDisplay("Hello")
						)
					, '%')
				)
			, '&');
			d4.Show();

			Console.WriteLine();
		}
	}
}
