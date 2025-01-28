using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanksystemOOP
{
	internal class Bank
	{
		private List<Bankszamla> szamlak = new List<Bankszamla>();

		public void Szamlaletrehoz(string tulajdonosNev, int kezdoEgyenleg)
		{
			Bankszamla ujSzamla = new Bankszamla(tulajdonosNev, kezdoEgyenleg);
			szamlak.Add(ujSzamla);
			Console.WriteLine($"Új számla létrehozva! {ujSzamla.GetSzamlaAdatok()}");


		}
		public Bankszamla SzamlaKeres(string szamlaszam)
		{
			foreach (var szamla in szamlak)
			{
				if (szamla.SzamlaSzam == szamlaszam)
				{
					return szamla;

				}
			}
			return null;

		}
		public void OsszesSzamlaAdatok()
		{
			if (szamlak.Count == 0) { Console.WriteLine($"Nincs egyetlen számla sem a rendszerben"); }
			else
			{
				Console.WriteLine("Összes számla: ");
				foreach (var szamla in szamlak)
				{
					Console.WriteLine(szamla.GetSzamlaAdatok());

				}
			}
		}
	}
} 
