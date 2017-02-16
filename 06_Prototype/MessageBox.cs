using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
	public class MessageBox : Product
	{
		private char decochar;
		public MessageBox(char decochar)
		{
			this.decochar = decochar;
		}

		protected MessageBox(MessageBox other)
		{
			this.decochar = other.decochar;
		}

		// http://refluxflow.net/2011/02/csharp-icloneable.html
		public object Clone()
		{
			Product p = null;
			p = new MessageBox(this);
			return p;
		}

		public void Use(string s)
		{
			int length = Encoding.Default.GetByteCount(s);
			for (int i = 0; i < length + 4; i++)
			{
				Console.Write(decochar);
			}
			Console.WriteLine("");
			Console.WriteLine(decochar + " " + s + " " + decochar);
			for (int i = 0; i < length + 4; i++)
			{
				Console.Write(decochar);
			}
			Console.WriteLine("");
		}
	}
}
