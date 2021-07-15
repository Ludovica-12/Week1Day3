using System;
using System.Collections.Generic;

namespace Week1Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Routine();
            //EsempioArray();

            //Random per generare numeri casuali
            Random random = new Random();
            int numeroRand = random.Next(10, 21); //L'ultimo numero non è compreso
            Console.WriteLine($"è sato genrato casualmente il numero {numeroRand}");


            

        }

        private static void EsempioArray()
        {
            //ARRAY
            int[] primoArray = new int[5];
            primoArray[0] = 3;
            primoArray[1] = 10;
            primoArray[2] = 13;
            primoArray[3] = 55;
            primoArray[4] = 8;

            //cerco la posizione in base al valore
            int indice = Array.IndexOf(primoArray, 10);
            Console.WriteLine($"Il numero 10 si trova alla posizione {indice}");

            Console.WriteLine("Stampa del mio primo Array:\n");
            for (int i = 0; i < primoArray.Length; i++)
            {
                Console.Write($"{primoArray[i]} \t");
            }

            int[] numeri = { 1, 2, 45, 67, 70, };

            string[] nomi = { "Pippo", "Pluto", "Paperino" };

            List<int> listaNumeri = new List<int>(); //Lista vuota. Lista numeri
            listaNumeri.Add(23);
            listaNumeri.Add(45);
            int elementi = listaNumeri.Count;
            Console.WriteLine($"\nLa mia lista contiene {elementi}");
            listaNumeri.Add(5);
            Console.WriteLine($"La mia lista contiene {listaNumeri.Count}");

            //Matrici --->Bidimensionali
            int[,] matrice = new int[2, 3]; // 2 numero di righe, 3 numero di colonne
            int[,] matrice2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrice2[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }

        private static void Routine()
        {
            Console.WriteLine("Hello!");
            Menu(); //Nome routine

            int a = 1;
            int b = 2;
            //Metodo che mi restituisce la somma
            int somma = 0;
            somma = Sum(a, b); //prende parametri in ingresso e deve restituirmi un valore
            Console.WriteLine(somma);

            int c = 20;
            int d = 35;
            int sommacd = Sum(c, d);
            Console.WriteLine(sommacd);

            int e = 45;
            int f = 2;
            StampaSomma(e, f); //Non ritorna niente

            int g = 23;
            int h = 33;
            StampaSommaconRichiamo(g, h);


            int var1 = 10;
            CambioValore(var1);
            Console.WriteLine($"Il valore di var1 dopo la chiamata cambia valore è {var1}");

            int var2 = 10;
            CambioValorePerRif(ref var2); //Passag con riferimento. Non copio solo il valore, ma modifico la variabile principale
            Console.WriteLine($"Il valore di var1 dopo la chiamata cambia valore è {var2}");

            int n1 = 2;
            int n2 = 10;
            int somman = SommaDopoIncremento(ref n1, n2);
            Console.WriteLine($"La ariabile n1 vale {n1}"); //3
            Console.WriteLine($"La ariabile n2 vale {n2}"); //10
            Console.WriteLine($"La somma è {somman}");//14

            //OUT
            int x1 = 2;
            int x2 = 3;
            //int prodotto;
            int differenzx12 = DifferenzaEProdotto(x1, x2, out int prodotto);
            Console.WriteLine($"Il prodotto è {prodotto}");
            Console.WriteLine($"La differenza è {differenzx12}");

            //TryParse. --->Provo a fare la conversione 
            Menu();
            Console.WriteLine("Inserisci la tua scelta");
            //--int scelta = int.Parse(Console.ReadLine());
            //bool verificaInt = int.TryParse(Console.ReadLine(), out int scelta);
            //Console.WriteLine($"La scelta dell'utente è {scelta}");

            int scelta;
            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > 3)
            {
                Console.WriteLine("Scelta errata. Deve essere un intero compreso tra 1 e . Riprova");
            }
            Console.WriteLine($"La scelta dell'utente è {scelta}");
        }

        //Mi deve restituire la differenza ma mi inte ressa avere in outut il prodotto dei 2 valori passati in input
        private static int DifferenzaEProdotto(int x, int y, out int p)
        {
            int diff = x - y;
            p = x * y;

            return diff;
        }

        //Scrivere una funzione che prende input 2 interi (1 per riferimento 2 per valore) li incrementa di 1 e restituisce la loro somma
        private static int SommaDopoIncremento(ref int x, int y)
        {
            x++;
            y++;
            return x + y; //14
        }

        private static void CambioValore(int x)
        {
            x = 5;
            Console.WriteLine($"Cambio parametro. il suo valore è = {x}");
        }

        private static void CambioValorePerRif(ref int x)
        {
            x = 5;
            Console.WriteLine($"Cambio parametro. il suo valore è = {x}");
        }

        //Funzione che vive a se; l'importante è sapere il tipo dei parametri che vado a passare
        private static int Sum(int x, int y) //Due parametri dello stesso tipo di a , b
        {
            /* int z = x + y;
             return z;*/

            return x + y;
        }

        private static void StampaSomma(int x , int y)
        {
            Console.WriteLine($"La somma di {x} + {y} è uguale a {x + y}");
        }

        private static void StampaSommaconRichiamo(int x, int y)
        {
            Console.WriteLine($"La somma di {x} + {y} è uguale a {Sum(x , y)}");
        }

        private static void Menu()
        {
            Console.WriteLine("°°°Menu°°°");
            Console.WriteLine("Scelta 1");
            Console.WriteLine("Scelta 2"); 
            Console.WriteLine("Scelta 3");
        }

        //overloding
        private static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

        private static int Sum(ref int x, int y, int z)
        {
            return x + y + z;
        }

        private static double Sum(double a, double b)
        {
            return (a + b);
        }

    }
}
