using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod
{
	public class CharDisplay : AbstractDisplay
	{
		private char ch;

		public CharDisplay(char ch)
		{
			this.ch = ch;
		}

		public override void Close()
		{
			Console.WriteLine(">>>");
		}

		public override void Open()
		{
			Console.Write("<<<");
		}

		public override void Print()
		{
			Console.Write(this.ch);
		}
	}
}
