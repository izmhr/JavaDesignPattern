using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
	public abstract class NumberGenerator
	{
		private ArrayList observers = new ArrayList();
		
		public void AddObserver(IObserver observer)
		{
			observers.Add(observer);
		}

		public void DeleteObserver(IObserver observer)
		{
			observers.Remove(observer);
		}

		public void NotifyObservers()
		{
			foreach(IObserver observer in observers)
			{
				observer.Update(this);
			}
		}

		public abstract int GetNumber();
		public abstract void Execute();
	}
}
