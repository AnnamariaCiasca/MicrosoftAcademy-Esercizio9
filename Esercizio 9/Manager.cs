using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_9
{
    class Manager
    {
        public static void Start()
        {
            char continua;
            Distributore.PopolaDistributore();
          

            do
            {
                Console.WriteLine("\n");
                Distributore.MostraSnacks();
                Console.WriteLine("\n\nScegli il tuo snack digitando il codice corrispondente:\n");

                Snack snack = Distributore.ScegliSnack();

                Distributore.GestisciPagamento(snack);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nVuoi scegliere un altro Snack? Se sì, digita S");
                continua = Console.ReadKey().KeyChar;
                Console.ForegroundColor = ConsoleColor.White;
            } while (continua == 's' || continua == 'S');
        }
    }
}
