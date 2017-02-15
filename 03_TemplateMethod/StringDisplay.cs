using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod
{
	public class StringDisplay : AbstractDisplay
	{
		private string str;
		private int width;

		public StringDisplay(string str)
		{
			this.str = str;
			width = Encoding.Default.GetByteCount(this.str);
		}

		public override void Close()
		{
			PrintLine();
		}

		public override void Open()
		{
			PrintLine();
		}

		public override void Print()
		{
			Console.WriteLine("|" + str + "|");
		}

		private void PrintLine()
		{
			Console.Write("+");
			for(int i = 0; i < width; i++)
			{
				Console.Write("-");
			}
			Console.WriteLine("+");
		}
	}
}
