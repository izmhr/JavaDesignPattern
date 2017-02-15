using DesignPattern.FactoryMethod.Framework;
using DesignPattern.FactoryMethod.IDCard;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			Factory factory = new IDCardFactory();
			Product card1 = factory.Create("わたし");
			Product card2 = factory.Create("あなた");
			Product card3 = factory.Create("YOU");
			card1.Use();
			card2.Use();
			card3.Use();
			ArrayList owners = ((IDCardFactory)factory).GetOwners();
			foreach(string owner in owners)
			{
				Console.WriteLine(owner);
			}
		}
	}
}
