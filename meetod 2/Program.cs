using System.ComponentModel.Design;

namespace meetod_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vastus = "";
            string info = "";
            do
            {


                //kasutajalt info saamine
                Console.WriteLine("Palun sisesta filtreeritav lähteinfo");
                info = GetResponse();
                Console.WriteLine("Palun sisesta otsitav info");
                string searchThisWord = "apelsin";
                //filtreerimine ja teavitus
                bool doesWordExist = FindThisWord(searchThisWord, info);
                if (doesWordExist)
                {
                    Console.WriteLine("Leidsime sõna \"" + searchThisWord + "\" sinu sisestatud infost");
                    Console.WriteLine(info);
                }
                else
                {
                    Console.WriteLine("Sõna \"" + searchThisWord + "\"infost puudub");
                }
                //programmi töö kordamine
                vastus = RepeatAction();
            } while (vastus == "jah");

            do
            {
                Console.WriteLine("Kas soovid infosse midagi juurde lisada");
                vastus = RepeatAction();
                if (vastus == "jah") ;
                {
                    Console.WriteLine("Kirjuta juurdelisatav info");
                    info += GetResponse();
                }
                vastus = "";
                Console.WriteLine("kas tahad tegevust korrata?");
                vastus = GetResponse();
            } while (vastus == "jah");

            Console.WriteLine("Kas salvestad dokumendi töölauale või dokumendikausta?");
            string kuhu = GetResponse();

            string saveFileHere = "";
            if (kuhu == "töölaud")
            {

            }
            else if (kuhu == "dokumendid")
            {
                saveFileHere = "C:\\Users\\opilane\\Documents\\dfgdf\\info.txt";
                File.WriteAllText(saveFileHere, info);
            }
            else if (kuhu == "dokumendid") ;
            {
                saveFileHere = "C:\\Users\\opilane\\Documents\\dfgdf\\info.txt";
                File.WriteAllText(saveFileHere, info);

                {

                }
            else
            {
                Console.WriteLine("ei saa aru " + kuhu + " ei ole salvestatav asukoht");
                vastus = RepeatAction() ;

            }
            
            {

            } while (vastus == "jah")


                // programmi lõpp
                Console.WriteLine("Headaega");

        }

        private static string RepeatAction()
        {
            string vastus;
            Console.WriteLine("Kas tahad tegevust korrata?");
            vastus = GetResponse();
            return vastus;
        }

        public static bool FindThisWord(string filter, string toBeFiltered)
        {
            if (toBeFiltered.Contains(filter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetResponse()
        {
            string sisestus = "";
            while (sisestus == "")
            {
                sisestus = Console.ReadLine();  
            }
            return "";
        }
    }
}
