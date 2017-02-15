using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
	public class StringDisplay : Display
	{
		private string str;

		public StringDisplay(string str)
		{
			this.str = str;
		}

		public override int GetColumns()
		{
			return str.Length;
		}

		public override int GetRows()
		{
			return 1;
		}

		public override string GetRowText(int row)
		{
			if(row == 0)
			{
				return str;
			}
			else
			{
				return null;
			}
		}

		//public void Show()
		//{

		//}
	}
}
