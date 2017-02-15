using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
	class SideBorder : Border
	{
		private char borderChar;

		public SideBorder(Display display, char chr) : base(display)
		{
			this.borderChar = chr;
		}

		public override int GetColumns()
		{
			return 1 + display.GetColumns() + 1;	// 文字数は中身の両側に飾り文字分を加えたもの。
		}

		public override int GetRows()
		{
			return display.GetRows();
		}

		public override string GetRowText(int row)
		{
			return borderChar + display.GetRowText(row) + borderChar;
		}
	}
}
