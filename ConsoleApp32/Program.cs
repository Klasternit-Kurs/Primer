using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
	class Program
	{
		static void Main()
		{
			List<GeoFigura> figure = new List<GeoFigura>();
			figure.Add(new Kvadrat { a = 5 });
			figure.Add(new Pravougaonik { a = 2, b = 4 });
			figure.Add(new Kvadrat { a = 2 });
			figure.Add(new Pravougaonik { a = 12, b = 45 });

			foreach (GeoFigura g in figure)
			{
				Console.WriteLine(g.Povrsina());
			}
			Console.ReadKey();

			IObim oo = new Kvadrat { a = 4};
			oo.Obim();

		}	
	}
	
	abstract class GeoFigura 
	{
		public abstract int Povrsina();
	}

	public interface IObim
	{
		int Obim();
	}

	class Kvadrat : GeoFigura, IObim
	{
		public int a;

		public override int Povrsina() => a * a;
		public int Obim() => 4 * a;
	}

	class Pravougaonik : GeoFigura
	{
		public int a, b;

		public override int Povrsina() => a * b;
		public override int Obim() => 2 * a + 2 * b;
	}

	
}
