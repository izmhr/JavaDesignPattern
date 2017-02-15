using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Bridge
{
	public class CountDisplay : Display
	{
		public CountDisplay(DisplayImpl impl) : base(impl)
		{
		}

		// 機能をひとつ増やした。機能の階層。
		public void MultiShow(int times)
		{
			Open();
			for(int i = 0; i < times; i++)
			{
				Print();
			}
			Close();
		}
	}
}
