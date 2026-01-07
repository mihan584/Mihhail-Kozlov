using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            {
                Console.WriteLine("Tere kasutaja!");
            }
            //float arv1 = 0f;
            //float arv2 = 0f;
            //Console.WriteLine("sisesta esimene arv mida tahad arvutada");
            //arv1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("sisesta teine arv");
            //arv2 = float.Parse(Console.ReadLine());
            //List<float> arvud = new List<float> {arv1,arv2 };


            //arv1 += arv2;
            //arv2 += arv1;


            //arvud.Add(0);
            //arvud.Add(1);

            Console.WriteLine("sisesta palun oma kasutajanimi");

            string kasutajanimi = "";
            while (kasutajanimi == "")
            {
                Console.WriteLine("mis on sinu kasutajanimi?");
                kasutajanimi = Console.ReadLine();
                if (kasutajanimi == "mihhail") ;
                {
                    Console.WriteLine("kasutajanimi on õige");
                    

                    
                }
               Console.WriteLine("sisesta kasutajanimi milles on 7 tähemärki");                                
                {
                    if (kasutajanimi.Length == 7) ;
                    return;
                }

            }
        }
    }
}






      