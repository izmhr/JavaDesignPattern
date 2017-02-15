using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
	public class Hand
	{
		public const int HANDVALUE_GUU = 0;
		public const int HANDVALUE_CHO = 1;
		public const int HANDVALUE_PAA = 2;

		public static readonly Hand[] hands = new Hand[]
		{
			new Hand(HANDVALUE_GUU),
			new Hand(HANDVALUE_CHO),
			new Hand(HANDVALUE_PAA)
		};

		private static readonly string[] names = new string[]{
			"グー", "チョキ", "パー"
		};

		private int handValue;

		private Hand(int handValue)
		{
			this.handValue = handValue;
		}

		public static Hand GetHand(int handValue)
		{
			return hands[handValue];
		}

		public bool IsStrongerThan(Hand h)
		{
			return Fight(h) == 1;
		}

		public bool IsWeakerThan(Hand h)
		{
			return Fight(h) == -1;
		}

		private int Fight(Hand h)
		{
			if(this == h)
			{
				return 0;
			}
			else if((this.handValue + 1) % 3 == h.handValue)
			{
				return 1;
			}
			else
			{
				return -1;
			}
		}

		public override string ToString()
		{
			return names[handValue];
		}
	}
}
