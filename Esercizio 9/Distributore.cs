using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Esercizio_9
{
    class Distributore
    {
        static Dictionary<int, Snack> snacks = new Dictionary<int, Snack>();
        internal static void PopolaDistributore()
        {
            int count = 0;

            Snack snack = new Snack(1, "Patatine", (decimal)1.55);
            snacks.Add(count, snack);

            snack = new Snack(2, "Cioccolato", (decimal)1.15);
            snacks.Add(++count, snack);

            snack = new Snack(3, "Taralli", (decimal)1.85);
            snacks.Add(++count, snack);

            snack = new Snack(4, "Biscotti", (decimal)2.35);
            snacks.Add(++count, snack);

            snack = new Snack(5, "Acqua ", (decimal)0.55);
            snacks.Add(++count, snack);
             
           snack = new Snack(6, "Succo ", (decimal)1.2);
           snacks.Add(++count, snack);
        }

        public static void MostraSnacks()
        {
            Console.WriteLine("Lista di Snacks nel distributore:\n");
            Console.WriteLine($"Codice \t Nome         \tPrezzo");
            foreach (var item in snacks)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{item.Key+1}  \t {item.Value.Nome} \t {item.Value.Prezzo}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static Snack ScegliSnack()
        {
          
            int scelta = -1;
            bool esiste = false;

            do
            {
                while (!int.TryParse(Console.ReadLine(), out scelta)  || scelta > snacks.Count) 
                {
                    Console.WriteLine("Hai premuto un tasto non corretto");
                }
                esiste = true;
          
                   esiste = snacks.ContainsKey(scelta - 1);
            

            } while (!esiste);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nHai scelto {snacks[scelta - 1].Nome} al prezzo di {snacks[scelta - 1].Prezzo} euro\n");
            Console.ForegroundColor = ConsoleColor.White;

            return snacks[scelta - 1];
        }



        public static void GestisciPagamento(Snack snack)
        {
            decimal scelta = 0;
            decimal credito = 0; 
            bool continua = false;
           
            do
            {
               Console.WriteLine("Inserisci i soldi necessari all'acquisto: ");
               while (!decimal.TryParse(Console.ReadLine(), out scelta))
                    {
                    Console.WriteLine("Hai inserito un valore non corretto.\n");
                     }
              
                    credito =+ scelta;
                    if (credito < snack.Prezzo)
                    {
                        decimal creditoMancante = snack.Prezzo - credito;
                        Decimal.Round(creditoMancante, 2);

                        Console.WriteLine($"Mancano ancora {creditoMancante} euro\n");
                  
                        continua = true;
                    }
                    else
                    {
                        continua = false;
                    }
                
      
            } while (continua);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nErogazione snack in corso");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");


            if (credito > snack.Prezzo)
            {
                Console.WriteLine("\nErogazione resto in corso");
                decimal resto = snack.Prezzo - credito;
                Decimal.Round(resto, 2);
                Thread.Sleep(500);
                Console.Write(". ");
                Thread.Sleep(500);
                Console.Write(". ");
                Thread.Sleep(500);
                Console.Write(". ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\nEcco il resto:  {-resto} euro");
            }
            Console.WriteLine("\nBuon Appetito!");
        }
    }
}
