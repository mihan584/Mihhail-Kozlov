using System.Runtime.CompilerServices;

namespace FileOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("kirjuta siia oma postkast aadress");

            //    string filePath = "C:\\Users\\opilane\\source\\repos\\ülesanned mihhail kozlov\\FileOperation\\postkasti aadress.txt";
            //    string aadress = Console.ReadLine();

            //    File.WriteAllText(filePath, aadress);
            Console.WriteLine("kõik laulusõnad");

            DisplayThisFile();
        }
        private static void DisplayThisFile()
        {
            string line = "";
            try
            {
                using (StreamReader readThisThing = new StreamReader("C:\\Users\\opilane\\source\\repos\\ülesanned mihhail kozlov\\FileOperation\\dfg.txt"))
                {
                    int lineCount = 0;
                    while (readThisThing.EndOfStream == false)
                    {
                        lineCount++;
                        line = readThisThing.ReadLine();
                        int pikkus = line.Length;
                        Console.WriteLine(lineCount + " " + line + " . Reapikkus on" + pikkus);
                    }
                    readThisThing.Close();


                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ei saa lugeda sest: " + e.Message);
                throw;
            }
        
        }
    }
}
