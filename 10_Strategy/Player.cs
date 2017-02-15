using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
	public class Player
	{
		private string name;
		private Strategy strategy;
		private int winCount;
		private int loseCount;
		private int gameCount;

		public Player(string name, Strategy strategy)
		{
			this.name = name;
			this.strategy = strategy;
		}

		public Hand NextHand()
		{
			return strategy.NextHand();
		}

		public void Win()
		{
			strategy.Study(true);
			winCount++;
			gameCount++;
		}

		public void Lose()
		{
			strategy.Study(false);
			loseCount++;
			gameCount++;
		}

		public void Even()
		{
			gameCount++;
		}

		public override string ToString()
		{
			return "[" + name + ":" + gameCount + " games, " + winCount + " win, " + loseCount + " lose" + "]";
		}
	}
}
