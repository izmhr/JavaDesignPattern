using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
	class Program
	{
		static void Main(string[] args)
		{
			Manager manager = new Manager();
			UnderlinePen uPen = new UnderlinePen('~');
			MessageBox mBox = new MessageBox('+');
			MessageBox sBox = new MessageBox('/');
			manager.Register("strong message", uPen);
			manager.Register("warning box", mBox);
			manager.Register("slash box", sBox);

			Product p1 = manager.Create("strong message");
			p1.Use("hoge");
			Product p2 = manager.Create("warning box");
			p2.Use("hoge");
			Product p3 = manager.Create("slash box");
			p3.Use("hoge");
		}
	}
}
