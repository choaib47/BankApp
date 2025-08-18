using System.Security.Cryptography.X509Certificates;

namespace BankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Konto konto = new Konto(123456, "Bourahla", 0);
            //bool status = true;
            

            /*if (antwort == "1")
            {
                Console.WriteLine("kontonummer: ");
                int kontonummer1 = int.Parse(Console.ReadLine());
                Console.WriteLine("inhaber: ");

                string inhaber1 = Console.ReadLine();

                Konto konto1 = new Konto(kontonummer1, inhaber1, 0);
            }*/
            while (true)
            {    
                Console.WriteLine("1. neues konto eröffnen\n 2. geld einzahlen\n 3. geld abheben\n 4. konto info anzeigen\n 5. beenden");
                string antwort = Console.ReadLine();
                int Antwort = int.Parse(antwort);

                if (Antwort == 2)
                {
                    Console.WriteLine("betrag: ");
                    decimal betrag = decimal.Parse(Console.ReadLine());

                    konto.Einzahlen(betrag);
                    
                }
                else if (Antwort == 3)
                {
                    Console.WriteLine("betrag zum abheben: ");
                    decimal betrag = decimal.Parse(Console.ReadLine());

                    konto.Abheben(betrag);

                }
                else if (Antwort == 4)
                {
                    konto.ZeigeInfo();

                }
                else if (Antwort == 5)
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("ungültige eingabe");
                }
            }

        }
    }    
        
}
