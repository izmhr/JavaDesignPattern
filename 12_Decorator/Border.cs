using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
	public abstract class Border : Display
	{
		protected Display display;
		protected Border(Display display)
		{
			this.display = display;
		}
	}
}
