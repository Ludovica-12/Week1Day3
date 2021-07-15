using System;

namespace Week1Day3.Esercizio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Analizza Numeri

                Si scriva un programma per poter analizzare una sequenza di numeri.
                Dati N numeri interi letti da tastiera (alternativa generati in maniera Random)
                si vogliono calcolare e stampare su schermo diversi risultati:



                1.quanti sono i numeri positivi, nulli e negativi
                2.quanti sono i numeri pari e dispari
                3.se la sequenza dei numeri inseriti è crescente, decrescente oppure né crescente né decrescente.



                Suggerimento.
                Una sequenza è crescente se ogni numero è maggiore del precedente,
                decrescente se ogni numero è minore del precedente,
                né crescente né decrescente in tutti gli altri casi.*/

            Console.WriteLine("Analizza la sequenza di numeri");

            int number = int.Parse(Console.ReadLine());
            int number1 = 0;
            int number2 = 0;

            int positive = 0;
            int negative = 0;
            int nothing = 0;

            int pari = 0;
            int dispari = 0;

            bool decrescente = true;
            bool crescente = true;

            Console.WriteLine($"Dovrai inserire {number} numeri");
            int[] numeriInseriti = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write($"\nInserisci il {i + 1}° numero:  ");
                numeriInseriti[i] = int.Parse(Console.ReadLine());

                if (numeriInseriti[i] == 0)
                   nothing++;
                    
                if (numeriInseriti[i] > 0)
                   positive++;

                else
                    negative++;
                    
                

                if (numeriInseriti[i] % 2 == 0)
                    pari++;
                else
                    dispari++;


                if( i >= 1 )
                {
                    if (number1 >= number2) 
                        decrescente = false;

                    if (number1 <= number2)
                        crescente = false;
                }
                number2 = number1;
                    

            }
            Console.WriteLine($"Ci sono {nothing} numeri nulli");
            Console.WriteLine($"Ci sono {positive} numeri positivi");
            Console.WriteLine($"Ci sono {negative} numeri negativi");

            Console.WriteLine($"Ci sono {pari} numeri pari");
            Console.WriteLine($"Ci sono {dispari} numeri dispari");

            if (!decrescente && !crescente)
                Console.WriteLine("Non è ne crescente ne decrescente");
            if (crescente)
                Console.WriteLine("E' crescente");
            if (decrescente)
                Console.WriteLine("E' decrescente");

            Console.WriteLine("Premi invio per terminare il programma");
            Console.ReadLine();


        }
    }
}
