using System;
using System.ComponentModel.Design;

namespace Uppgift_3._4
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hur lång är låten? Svara i minuter och sekunder");
            string längd = Console.ReadLine();

            int längdIndex = längd.IndexOf(" ");
            string minutersvar = längd[..längdIndex];
            string sekundersvar = längd[(längdIndex + 1)..];
            int min = int.Parse(minutersvar);
            int sec = int.Parse(sekundersvar);


            switch (min)
            {
                case 0:
                    
                        Console.WriteLine("Den får inte visas");
                        break;

                case 1:
                    Console.WriteLine("Den får inte visas");
                    break;

                case 2:
                    if (sec <= 45  || sec <= 140)
                        {
                            Console.WriteLine("Din låt får visas");
                        }
                    else
                        {
                            Console.WriteLine("Din låt får inte visas");
                        }
                    break;
                    
                case 3: 
                    Console.WriteLine("Din låt får visas");
                    break;

                case 4:
                    if (sec <= 20)
                        {
                        Console.WriteLine("Din låt får visas");
                        }
                       else
                        {
                        Console.WriteLine("Din låt får inte visas");
                        }
                    break;
                
                default: Console.WriteLine("Din låt får inte visas");
                    break;

            }
            Console.ReadKey();
                
        }
    }
}
