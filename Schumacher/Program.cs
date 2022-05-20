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
        }
    }
}