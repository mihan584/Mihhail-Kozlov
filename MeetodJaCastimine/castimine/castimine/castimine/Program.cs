namespace castimine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double komakohagaaarv = 9.55d;
            Console.WriteLine((int)komakohagaarv);
            Console.WriteLine(roundedearv);



            int arv = 35;
            string arvtekstina = arv.ToString();
            Console.WriteLine(arvtekstina);
            Console.WriteLine(arv);
            double arvdouble = 2793745345d;
            int arvint = 0;
            arvint = (int)arvdouble;

            double uusdouble = arvint;

            //kirjuta programm mis küsib kasutajalt meetrites tema pikkust (komakohtatega)
            //teisenda kasutaja pikkus sentimeetriteks
            //küsimine esialgu on tekstikujul (kasutaja sisestab teksti),
            //program ise peab tekstist välja lugema komakohaga arvu.
            string pikkusm = "";
            Console.WriteLine("sisesta oma pikkus");
            pikkusm = Console.ReadLine();
            float pikkusFm = float.Parse(pikkusm);
            int pikkuscm = (int)pikkusFm;
            Console.WriteLine($"Sinu pikkus sentimeetrites on: {pikkuscm}");
        }
    }
}





