using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
	class Program
	{
		static void Main(string[] args)
		{
			var o = new Osoba();
			var r = new Radnik();
		

			Osoba oO = new Osoba();
			Osoba oR = new Radnik();
			Osoba oS = new Student();


			oO.Foo();
			oR.Foo();

			Console.WriteLine(oR.GetType());

			Console.ReadKey();
		}	
	}

	class Osoba
	{
		public string Ime = "Pera";
		public string Prezime;


		public virtual void Foo() => Console.WriteLine("Foo za osobu");
	}

	class Radnik : Osoba
	{
		public decimal plata;

		public override void Foo() => Console.WriteLine("Foo za radnika");
	}

	class Student : Osoba
	{
		public new void Foo() => Console.WriteLine("Foo za studenta");
	}
}
