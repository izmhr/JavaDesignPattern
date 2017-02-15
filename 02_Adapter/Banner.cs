using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
	public class Banner
	{
		private string str;
		public Banner(string str)
		{
			this.str = str;
		}

		public void ShowWithParen()
		{
			Console.WriteLine("( " + str + " )");
		}

		public void ShowWithAster()
		{
			Console.WriteLine("* " + str + " *");
		}
	}
}
