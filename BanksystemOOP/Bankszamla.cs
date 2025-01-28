using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanksystemOOP
{
	internal class Bankszamla
	{
		private static int kovezkezoSzamlaszam = 1000;
		public string SzamlaSzam { get; private set;}
		public string Tulajneve { get; private set;}	
		public int Egyenleg {  get; private set;}

		public Bankszamla(string tulajdonosNev, int kezdoEgyenleg)
		{
			SzamlaSzam = $"ACC{kovezkezoSzamlaszam++}";
			Tulajneve = tulajdonosNev;
			Egyenleg = kezdoEgyenleg;	

		}

		public void Befizet(int osszeg)
		{
			if (osszeg > 0)
			{
				Egyenleg += osszeg;
				Console.WriteLine($"{osszeg} befizetve a(z) {SzamlaSzam} számlára");

			}
			else { Console.WriteLine("Hibás összeg!"); }
		}
		public void Kifizet(int osszeg) 
		{
			if (osszeg > 0 && osszeg <= Egyenleg)
			{
				Egyenleg -= osszeg;
				Console.WriteLine($"{osszeg} HUF kifizetve a(z) {SzamlaSzam} számláról");

			}
			else { Console.WriteLine("Hibás összeg, vagy nincs elég pénz a számlán"); }
		}
		public string GetSzamlaAdatok()
		{ return $"Számlaszám: {SzamlaSzam}, Tulajdonos: {Tulajneve},egyenleg: {Egyenleg}"; }

	}
}
