using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Bridge
{
	class Program
	{
		static void Main(string[] args)
		{
			//Display d0 = new Display(new DisplayImpl("hello"));
			Display d1 = new Display(new StringDisplayImpl("hello japan."));
			Display d2 = new CountDisplay(new StringDisplayImpl("hello japan."));
			CountDisplay d3 = new CountDisplay(new StringDisplayImpl("hello japan."));
			d1.Show();
			d2.Show();
			d3.Show();
			d3.MultiShow(5);	// d3 だけは「機能が」拡張されている。
		}
	}
}
