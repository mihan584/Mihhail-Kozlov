using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace kiirdete_telje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string thing = "abc123"; // alfanumeeriline salasõna
            Console.WriteLine(thing.Length); //sõne pikkuse lugemine
            Random juhuarv = new Random(); //juhuaru tekitamine randomiga
            juhuarv.Next(75, 299); //lisaväärtus randomist floati

            float addevalue = juhuarv.Next(75, 299) / 100;

            //kirjuta program millel on kaks meetodit
            Console.WriteLine("Tere tulemast toidelljase");
            Console.WriteLine("Palun logi sisse logimiseks");
            bool login = UserLogin();
            if (login == false)
            {
                Console.WriteLine("Toidu tellimiseks sa pead olema sisselogitud");
            }
            else
            {
                Console.WriteLine("Sisesta toit mis osta tahad kui tahad lõpetada kirjuta \nenam ei oloe\n");
                string Lõpp = "";
                while (Lõpp != "enam ei ole") ;
            }
            {
                Console.WriteLine("Sisesta järgmine ost");
                string sisestus = Console.ReadLine();

            }

            //UserLogin() ja FoodOrder()




            //Userlogin() küsib kasutajalt tema nime ja parooli küsimused on tsüklis ja parooli küsimine peab olema alfanureemiline aga vahemikus 8 tähemärki ja 12 tähemärki pikk.
            // siis kui kasutajanimi ja parool on õige main programmis küsitakse kasutajalt toiduasju mida ta osta tahab
            // kasutaja soovitud asjad hoitakse listis kui rohkem pole ütle kasutajale et ta kirjutaks "tellimuse lõpp"
            // FoodOrder() arvutab kokku kui palju ostukorv maksma läheb. iga asi on 1.5+ mingi random float. tsükkel käib niikaua kuni rohkem asju ei ole.

        }
        bool login UserLogin()
        {
            string kasutajanimi = "";
            string kasutajaparool = "";
            while (kasutajanimi == "")
            {
                Console.WriteLine("Mis on sinu kasutajanimi");
                kasutajanimi = Console.ReadLine();
                if (kasutajanimi != "nipitiri") ;
                {
                    Console.WriteLine("Kasutajanimi on vale");
                }
                {
                    while (kasutajaparool == "") ;
                }
                Console.WriteLine("Mis on sinu kasutajaparool");
                kasutajaparool = Console.ReadLine();
                if (kasutajaparool != "LALALA") ;
                Console.WriteLine("See parool on vale");
                {
                    Console.WriteLine("Sisesta parool mis on pikem kui 12 tähe-märki");
                }
                if (kasutajaparool.Length < 12) ;
                {
                    {
                        Console.WriteLine("Sisesta parool mis on lühem kui 8 tähe-märki");
                    }
                    {
                        if (kasutajaparool.Length > 8) ;
                    }
                    return;












                }
               
    

            }
        }
    }
}

