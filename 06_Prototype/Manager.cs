using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
	public class Manager
	{
		// Java だと HashMap を使います
		private Dictionary<string, Product> showcase = new Dictionary<string, Product>();

		public void Register(string name, Product product)
		{
			// この時登録された product が厳密にどんな型なのかは知らない。
			showcase.Add(name, product);
		}

		public Product Create(string protoname)
		{
			// protoname がどんなクラスの Product かわからないけど、各 product は CreateClone() できることが確約されているので、クローンしたものを返す。
			Product p;
			showcase.TryGetValue(protoname, out p);
			return (Product)p.Clone();
		}

	}
}
