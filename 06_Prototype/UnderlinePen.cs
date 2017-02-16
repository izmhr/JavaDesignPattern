using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
	public class UnderlinePen : Product
	{
		private char ulchar;
		public UnderlinePen(char ulchar)
		{
			this.ulchar = ulchar;
		}

		protected UnderlinePen(UnderlinePen other)
		{
			this.ulchar = other.ulchar;
		}

		// http://refluxflow.net/2011/02/csharp-icloneable.html
		public object Clone()
		{
			Product p = null;
			p = new UnderlinePen(this);
			return p;
		}

		public void Use(string s)
		{
			int length = Encoding.Default.GetByteCount(s);
			Console.WriteLine("\"" + s + "\"");
			Console.Write(" ");
			for(int i = 0; i < length; i++)
			{
				Console.Write(ulchar);
			}
			Console.WriteLine("");
		}
	}
}
