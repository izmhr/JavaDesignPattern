using DesignPattern.FactoryMethod.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod.IDCard
{
	public class IDCard : Product
	{
		private string owner;

		public IDCard (string owner)
		{
			Console.WriteLine(owner + " のカードを作ります");
			this.owner = owner;
		}

		public override void Use()
		{
			Console.WriteLine(owner + " のカードですよ、つかってますよ");
		}

		public string GetOwner()
		{
			return owner;
		}
	}
}
