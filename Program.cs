using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<IProduct>();

            products.Add(new Dradle(5, DradleSize.Medium));
            products.Add(new TekDek());
            var l1 = new Lego(2, "L1");
            var l2 = new Technic(12, "Technic");

            var combined = l1.Combine(l2);

            foreach(var p in products)
            {                
                Console.WriteLine("{0} passes inpsection? {1}",
                    p.ToString(),
                    p.Inspect());
            }
        }
    }


}