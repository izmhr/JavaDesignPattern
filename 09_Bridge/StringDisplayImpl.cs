using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Bridge
{
	public class StringDisplayImpl : DisplayImpl
	{
		private string str;
		private int width;

		public StringDisplayImpl(string str)
		{
			this.str = str;
			this.width = Encoding.Default.GetByteCount(this.str);
		}

		// 実装を行った。実装の階層
		public override void RawClose()
		{
			PrintLine();
		}

		public override void RawOpen()
		{
			PrintLine();
		}

		public override void RawPrint()
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
