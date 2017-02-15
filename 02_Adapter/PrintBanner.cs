using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
	public class PrintBanner : Banner, IPrint
	{
		public PrintBanner(string str) : base(str)
		{
		}

		// Banner の実装をつかいたいのだけど、 IPrint の仕様で書く必要がある。
		public void PrintStrong()
		{
			ShowWithParen();
		}

		public void PrintWeak()
		{
			ShowWithAster();
		}
	}
}
