using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
	public interface IObserver
	{
		void Update(NumberGenerator generator);
	}
}
