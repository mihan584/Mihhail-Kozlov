namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere palun sisesta oma kasutajanimi:");
            string kasutajanimi = Console.ReadLine();
            do
            {
                Console.WriteLine("Palun sisesta oma kasutajanimi");
                kasutajanimi = Console.ReadLine();
            
            
            } while (kasutajanimi == "");

            Console.WriteLine("Palun sisesta oma parool");

            int parool = int.Parse(Console.ReadLine());
            while (parool < 1000 || parool > 9999)
            {
                Console.WriteLine("Parool peab olema neljakohaline");
                parool = int.Parse(Console.ReadLine());
            }

            int[] arvud = [1,3,6,9,11];
            foreach (int kõikarvud  in arvud)
            {
                int kõikarvudkokku = arvud.Sum();
                Console.WriteLine(kõikarvudkokku);
            }




        }
    }
}
