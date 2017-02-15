using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
	public class GraphObserver : IObserver
	{
		public void Update(NumberGenerator generator)
		{
			Console.Write("GraphObserver: ");
			int count = generator.GetNumber();
			for(int i = 0; i < count; i++)
			{
				Console.Write("+");
			}
			Console.WriteLine();
			try
			{
				Thread.Sleep(100);
			}
			catch(ArgumentOutOfRangeException e)
			{
				Console.WriteLine(e);
			}
		}
	}
}
