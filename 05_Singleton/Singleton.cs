using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
	public class Singleton
	{
		private static Singleton instance = new Singleton();

		private Singleton()
		{
			Console.WriteLine("インスタンスを生成しました");
		}

		public static Singleton GetInstance()
		{
			return instance;
		}
	}
}
