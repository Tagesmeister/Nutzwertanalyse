
namespace Nutzwertanalyse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] Firma = new string[10];
            Console.WriteLine("Willkommen zur Nutzwertanalyse.");
            Thread.Sleep(1800);
            string Weiter = "";
            bool check = false;
            int k = 0;
            int z = 0;
            int i = 0;


        Start:
            do
            {


                Console.Clear();
                Console.Write("Geben Sie hier die Firma ein: ");

                for (; i <= Firma.Length;)
                {
                    Firma[i] = Console.ReadLine();
                    k++;
                    i++;
                    break;


                }

                Console.WriteLine("Noch eine Firma? [ja|nein]");
                Weiter = Convert.ToString(Console.ReadLine());

                if (Weiter == "ja")
                {
                    continue;
                }
                else if (Weiter == "nein")
                {
                    goto Break;
                }
                else if (Weiter != "ja" || Weiter != "nein")
                {
                    Console.Clear();
                    Console.WriteLine("Ungültige Eingabe");
                    Thread.Sleep(1500);
                    goto Start;
                }

            } while (Weiter == "ja");




        Break:
            Console.Clear();
            Console.WriteLine("Ihre eingegebene Firmen: ");
            Console.WriteLine("Anzahl: " + k);
            Console.WriteLine("----------------------------------");
            Thread.Sleep(1500);

            Array.ForEach(Firma, Console.WriteLine);

            Console.ReadKey();

            


        }
    }
}
