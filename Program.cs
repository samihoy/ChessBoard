using System.Text;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)

            // Maximillian Lundberg .NET
        {
            // Unicode standarden jag använde var NSimSum eftersom det var enda fonten som kunde skriva utt symbolerna på min dator
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("skriv in en siffra");
            //if statment som tar emot ett input, chekar om det är siffra och assignar värdet till en lokal variabel
            if (int.TryParse(Console.ReadLine(), out int x))
            {
                // en schakbräda har per definerat lika långa sidor och uppgiften sa specifikt att man skulle mata in EN siffra, osäker på på om det var oklart skrivet eller öppet för tolkning. jag gick med text beskrivningnen
                // jag valde att göra uppgiften i mestadels if statments för att:
                // 1. Uppgiften var enkel, därför får den en enkel lösning
                // 2. alla If staments ser nästan likadana utt och skulle kuna göras om till metoder och KRAFTIGT korta ner hella koden, jag har dok lämnat dom "as is" så det är enklare följa logiken vid rättning  : )

                int y = x * x;
                // p är en variabel som skiftar printing möstret efter varje rad har skrivits utt, används bara om schakbrädet har jämt antal sidor vs ojämt
                int p = 0;

                // for-loop som räknar hur många ruttor som ska skrivs utt
                for (int i = 1; i <= y; i++)
                {
                    // if stament som används vid ojämnt antal ruttor på sidorna (x värdet)
                    if (x % 2 == 1)
                    {
                        if (i % 2 == 1)
                        {Console.Write("◻︎");
                        }
                        else if (i % 2 == 0)
                        {Console.Write("◼︎");
                        }
                        if (i % x == 0)
                        {Console.WriteLine("\n");
                        }
                    }
                    // statment som används vid jämt antal ruttor på sidorna (x värdet)
                    else if (x % 2 == 0)
                    {   // printar en rad med ruttor och lägger till+1 på p så nästa rad använder en inversad print ordning
                        if (p % 2 == 0)
                        {
                            if (i % 2 == 0)
                            {Console.Write("◻︎");
                            }
                            else if (i % 2 == 1)
                            {Console.Write("◼︎");
                            }
                            if (i % x == 0)
                            {Console.WriteLine("\n");
                                p++;
                            }
                        }
                        // inversad print ordning för nästa rad
                        else
                        {
                            if (i % 2 == 0)
                            {Console.Write("◼︎");
                            }
                            else if (i % 2 == 1)
                            {Console.Write("◻︎");
                            }
                            if (i % x == 0)
                            {Console.WriteLine("\n");
                                p++;
                            }
                        }
                    }
                }
            }
            else
            {Console.WriteLine("input is not a number, learn to use a keyboard!");
            }
        }

    }
    
}
