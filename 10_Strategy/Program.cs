using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
	class Program
	{
		static void Main(string[] args)
		{
			if(args.Length != 2)
			{
				Console.WriteLine(args);
				Console.WriteLine("Usage: randomseed1 randomseed2");
				Console.WriteLine("Example: 24 32");
				Environment.Exit(0);
			}

			int seed1 = Int32.Parse(args[0]);
			int seed2 = Int32.Parse(args[1]);
			Player player1 = new Player("Taro", new WinningStrategy(seed1));
			Player player2 = new Player("Jiro", new ProbStrategy(seed2));
			for(int i = 0; i < 100; i ++)
			{
				Hand nextHand1 = player1.NextHand();
				Hand nextHand2 = player2.NextHand();
				if(nextHand1.IsStrongerThan(nextHand2))
				{
					Console.WriteLine("Winner " + player1.ToString());
					player1.Win();
					player2.Lose();
				}
				else if(nextHand2.IsStrongerThan(nextHand1))
				{
					Console.WriteLine("Winner " + player2.ToString());
					player1.Lose();
					player2.Win();
				}
				else
				{
					Console.WriteLine("Even...");
					player1.Even();
					player2.Even();
				}
			}
			Console.WriteLine("Total Result: ");
			Console.WriteLine(player1.ToString());
			Console.WriteLine(player2.ToString());
		}
	}
}

