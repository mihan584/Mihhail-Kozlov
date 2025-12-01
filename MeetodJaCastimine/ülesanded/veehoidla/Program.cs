namespace Veehoidla_tase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kirjuta program mis küsib kasutajalt kasutajanime - tsükliga meetodis
            string kasutajanimi = GetUserName();
            //kui on vale kasutajanimi, program lõppeb kasutajale teavitamisega

            if (kasutajanimi != "apelsin69")
            {
                Console.WriteLine($"Kasutajanimi ei ole õige, {kasutajanimi}.");
            }
            // kui on õige küsi veetaseme hetkeseisu komakohalise arvuga - tsüklis

            else
            {
                float veetase = 0.0F;
                while (veetase == 0.0F) ;
                {
                    Console.WriteLine("Mis on veetase anduril");
                    veetase = float.Parse(Console.ReadLine());
                }
            }
            //kutse välja eraldi meetod, mille parameetriks on veetase mis tagastab string tüüpi andme
            Console.WriteLine(veetasetuvastus(veetase));
            //meetod kontrollib 3 vahemiku ja tagastab teavituse põhinedes sellele kui kõrge vesi on
            //vahemik 1: 1-2m tase madal
            //vahemik 2: 2-3.5m tase normaalne
            //vahemik 3: 3.5-4.25m tase kõrge
            //kõik muu annab veateate anduri kohta
        }
        public static string veetasetuvastus(float vt)
        {
            if (vt >= 1.00F && vt < 2.00F)
            {
                return "Veetase on madal, hoia veega kokku.";
            }
            else if (vt >= 2.00F && vt < 3.50F)
            {
                return "Veetase on normaalne, tarbimine stabiilne.";
            }
            else if (vt >= 3.50F && vt < 4.25F) ;
            {
                return "Veetase on liiga kõrge! Ava tammi luugid.";

            }
        }

        public static void GetUserName()
        {
            string hetkesisestus = "";
            while (hetkesisestus == "") ;
            {
                Console.WriteLine("Mis on sinu kasutajanimi");
                hetkesisestus = Console.ReadLine();
            }
            return hetkesisestus;

        }
    }
}
          

    

