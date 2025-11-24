using System.Security.Cryptography.X509Certificates;

namespace eelarve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //küsi kasutajalt tema nime (tsüklis)
            //küsi kasutajalt tema tulusid, niikaua kuni rohkem pole
            //siis küsi kasutajalt tema kulusid, ka niikaua kuni rihkem pole.
            //hoia andmeid List tüüpi muutujas, andmed ise peavad olema komakohaga
            //tee uus meetod, mis arvutab kokku järjendi sisu
            //hoia kogutulusid ja kogukulusid eraldi muutujates kasutades oma meetodi
            //arvuta kasutajale tulude ja kulude põhjal tema hetkeseis
            //Ümarda kasutajale tagastav arv kahe komakohani. Ja kuva nimeline sõnum



            string kasutajanimi = "";
            Console.WriteLine("Mis on teie kasutajanimi");
            do
            {
                Console.WriteLine("Teie nimi on:");
                kasutajanimi = Console.ReadLine();
            } while (kasutajanimi == "");

            {
                string kasutajasisestus = "";
                while (kasutajasisestus != "rohkem pole")
                {
                    List<float> tulud = new List<float>();
                    Console.WriteLine("Mis on teie sissetulekus? \n kui rohkem ei ole midagi lisada, siis kirjuta \"rohkem pole\"");
                    kasutajasisestus = Console.ReadLine();
                    if (kasutajasisestus != "rohkem pole")
                    {
                        tulud.Add(float.Parse(kasutajasisestus));
                    }

                   
                    while (kasutajasisestus != "rohkem pole") ;
                    {
                        List<float> kulud = new List<float>();
                        Console.WriteLine("Mis on teie väljaminekus? \n kui rohkem ei ole midagi lisada, siis kirjuta \"rohkem pole\"");
                        if (kasutajasisestus != "rohkem pole") ;
                        {
                            kulud.Add(float.Parse(kasutajasisestus) );
                        }
                        public static float arvutus(List<float> kokkuarvutatavkollektsioon)
        {
            foreach (var arv in kokkuarvutatavkollektsioon)
            {
                
            }
            return null;
        }
                    }
                }

            }
        }
    }
}
                    
                
           

            
            
           
            
                
            
        
    
