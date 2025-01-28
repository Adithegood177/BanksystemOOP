namespace BanksystemOOP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Bank bank = new Bank();
			bool fut = true;

			while (fut)
			{
				Console.Clear();
                Console.WriteLine("\n 1. új számla létrehoz");
                Console.WriteLine("2. Befiz");
                Console.WriteLine("3. kifiz");
                Console.WriteLine("4. egy szamla adat");
                Console.WriteLine("5. összes szamlalista");
				Console.WriteLine("6. kilep");
                Console.Write("Válassz lehetőséget: "); 
				int valasztas = Convert.ToInt32(Console.ReadLine());

				switch (valasztas) 
				{
					case 1:

						Console.Clear();
                        Console.WriteLine("Tulajdonos neve: ");
						string nev  = Console.ReadLine();
                        Console.WriteLine("Kezdőegyenleg: ");
						int kezdoEgyenleg = Convert.ToInt32(Console.ReadLine());
						bank.Szamlaletrehoz(nev, kezdoEgyenleg);
                        break;
					case 2:

						Console.Clear();
                        Console.WriteLine("Add meg a számlaszámot:");
						string szamlaszamBefizet = Console.ReadLine();
						var szamlaBefizet = bank.SzamlaKeres(szamlaszamBefizet);
						if (szamlaBefizet != null)
						{
                            Console.WriteLine("Add meg a befizetendő: ");
							int osszegbefizet = Convert.ToInt32(Console.ReadLine());
							szamlaBefizet.Befizet(osszegbefizet);
                        }
                        break;
					case 3:
						Console.Clear();
						Console.WriteLine("Add meg a számlaszámot:");
						string szamlaszamKifizet = Console.ReadLine();
						var szamlaKifizet = bank.SzamlaKeres(szamlaszamKifizet);
						if (szamlaKifizet != null)
						{
							Console.WriteLine("Add meg a befizetendő: ");
							int osszegbefizet = Convert.ToInt32(Console.ReadLine());
							szamlaKifizet.Kifizet(osszegbefizet);
						}

						Console.Clear();
						break;
					case 4:
						Console.Clear();
						Console.WriteLine("Add meg a számlaszámot:");
						string szamlaszamfel = Console.ReadLine();
						var szamla = bank.SzamlaKeres(szamlaszamfel);
						Console.Clear();
						if (szamla != null)
						{
                            Console.WriteLine(szamla.GetSzamlaAdatok);
                        }
						break;
					case 5:

						Console.Clear();
						bank.OsszesSzamlaAdatok();
						break;
					case 6:
						fut = false;
						Console.Clear();
                        Console.WriteLine("Kilépés....");
                        break;
				}
            }

			Console.ReadLine();	
		}
	}
}
