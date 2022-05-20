namespace Schumacher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.
            List<Nagydíj> nagydíjak = new List<Nagydíj>();
            foreach (var sor in File.ReadAllLines("schumacher.csv").Skip(1))
            {
                nagydíjak.Add(new Nagydíj(sor));
            }

            //3.
            Console.WriteLine($"3. feladat: {nagydíjak.Count}");

            //4.
            Console.WriteLine($"4. feladat: Magyar Nagydíj helyezései");
            nagydíjak
                .Where(x => x.Név == "Hungarian Grand Prix" && x.Pozíció > 0)
                //.Where(x => x.Név == "Hungarian Grand Prix" && x.Státusz == "Finished")
                .ToList()
                .ForEach(x => Console.WriteLine($"\t{x.Dátum.ToString("yyyy. MM. dd.")}:{x.Pozíció}. hely"));

        }
    }
}