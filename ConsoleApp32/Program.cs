using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
	class Program
	{
		public delegate void MojTIPdelegata();

		static void Main()
		{
			Nesto n = new Nesto();

			n.Obrni(true);
			Console.WriteLine(n.op(3, 4));
			n.Obrni(false);
			Console.WriteLine(n.op(3, 4));
			Console.ReadKey();
		}	
	}

	class Nesto
	{
		public delegate int Operacija(int x, int y);
		public Operacija op;

		public void Obrni(bool o)
		{
			if (o)
				op = Oduzimac;
			else
				op = Sabirac;
		}

		private int Sabirac(int a, int b) => a + b;
		private int Oduzimac(int a, int b) => a - b;
	}
	
}
