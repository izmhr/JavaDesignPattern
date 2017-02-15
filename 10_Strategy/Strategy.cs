using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
	public interface Strategy
	{
		Hand NextHand();
		void Study(bool win);
	}
}
