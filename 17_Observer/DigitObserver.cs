using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
	public class DigitObserver : IObserver
	{
		public void Update(NumberGenerator generator)
		{
			// 知らされたので、報告者から値をぶんどって、表示をしておく。
			Console.WriteLine("DigitObserver: " + generator.GetNumber());

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
