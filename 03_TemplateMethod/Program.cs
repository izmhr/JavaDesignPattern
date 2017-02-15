﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			AbstractDisplay d1 = new CharDisplay('H');
			AbstractDisplay d2 = new StringDisplay("hello, world");
			AbstractDisplay d3 = new StringDisplay("こにちわ");
			d1.Display();
			d2.Display();
			d3.Display();
		}
	}
}
