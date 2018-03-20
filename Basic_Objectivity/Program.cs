using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Objectivity
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuboid cu = new Cuboid();
            Cuboid cu2 = new Cuboid(2, 4, 5);
            int result = Aritmetics.Add(2, 3);

            // Klasa anonimowa to klasa, ktora nie posiada wlasnej nazwy. Przydatna np. w LinQ
            var anonymousObject = new {name = "Roman", age = 25};

            Console.WriteLine("Aritmetics result: " + result);
            Console.WriteLine(Cuboid.ShowNumCuboid());
            Console.WriteLine(Cuboid.numCuboid);

            // Operacje na enumach
            PseudoCalendar pseudoCalendar = new PseudoCalendar();
            pseudoCalendar.month = Month.August;
            Console.WriteLine(pseudoCalendar.month);

            Month month = Month.April;
            Console.WriteLine(month);


            Console.ReadKey();
        }
    }
}
