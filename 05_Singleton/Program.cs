using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("はじめますよ");
			Singleton s1 = Singleton.GetInstance();
			Singleton s2 = Singleton.GetInstance();
			if(s1 == s2)
			{
				Console.WriteLine("同じインスタンスです");
			}
			else
			{
				Console.WriteLine("異なるインスタンスなんです");
			}
			Console.WriteLine("おわります");
		}
	}
}
