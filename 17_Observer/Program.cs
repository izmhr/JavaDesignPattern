using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
	class Program
	{
		static void Main(string[] args)
		{
			NumberGenerator generator = new RandomNumberGenerator();
			IObserver observer1 = new DigitObserver();
			IObserver observer2 = new GraphObserver();
			generator.AddObserver(observer1);
			generator.AddObserver(observer2);
			generator.Execute();
		}
	}
}
