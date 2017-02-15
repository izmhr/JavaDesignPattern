using DesignPattern.FactoryMethod.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod.IDCard
{
	public class IDCardFactory : Factory
	{
		private ArrayList owners = new ArrayList();

		protected override Product CreateProduct(string owner)
		{
			return new IDCard(owner);
		}

		protected override void RegisterProduct(Product p)
		{
			owners.Add(((IDCard)p).GetOwner());	// ここなんで名前だけなんだろう？
		}

		public ArrayList GetOwners()
		{
			return owners;
		}
	}
}
