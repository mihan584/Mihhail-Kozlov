namespace Meetod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tervitus();
            string kasutajaNimi = "";
            kasutajaNimi = NimeKüsimine(kasutajaNimi);

            Console.WriteLine("Mis on sinu nädalane eelarve?");
            float eelarve = 0.00f;
            bool kaskasutajajanõustub = false;
            while (kaskasutajajanõustub != true)
            {
                Console.WriteLine($"Pragune eelarve on {eelarve} kas see on õige?");
                Console.WriteLine("Vasta kas jah või ei:");
                string mistaütles = Console.ReadLine();

                if (mistaütles == "jah")
                {
                    kaskasutajajanõustub = true;
                }





            }
            Console.WriteLine($"{kasutajaNimi} sinu eelarve on:{SinuEelarvePäevas(eelarve)}");
            SinuEelarvePäevas(eelarve);

        }

        private static string NimeKüsimine(string kasutajaNimi)
        {
            while (kasutajaNimi == "")
            {
                Tervitus();
                Console.WriteLine("Palun sisesta oma kasutajaNimi");
                kasutajaNimi = Console.ReadLine();
            }

            return kasutajaNimi;
        }

        public static void Tervitus()
        {
            Console.WriteLine("*omik");
        }
        public static int SinuEelarvePäevas(float eelarve)
        {
            double eelarvepäevas = eelarve / 7;
            return (int)eelarvepäevas;
        }

    }
}