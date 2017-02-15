using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
	public class WinningStrategy : Strategy
	{
		private Random random;
		private bool won = false;
		private Hand prevHand;

		public WinningStrategy(int seed)
		{
			random = new Random(seed);
		}

		public Hand NextHand()
		{
			if(!won)
			{
				// 前回勝てなかったら、今回は手を変える。 前回勝っていたら、同じ手を出す。
				prevHand = Hand.GetHand(random.Next(3));
			}
			return prevHand;
		}

		public void Study(bool win)
		{
			won = win;
		}
	}
}
