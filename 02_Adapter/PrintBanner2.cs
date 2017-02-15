using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
	public class PrintBanner2 : Print2
	{
		private Banner banner;
		public PrintBanner2(string str)
		{
			this.banner = new Adapter.Banner(str);
		}
		public override void PrintStrong()
		{
			banner.ShowWithParen();
		}

		public override void PrintWeak()
		{
			banner.ShowWithAster();
		}
	}
}
