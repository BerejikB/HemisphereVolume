using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume_of_a_hemisphere
{
    class HemisphereVolume
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hemisphere Radius: ");
                double radius = double.Parse(Console.ReadLine());
                double pi = Math.PI;
                double tt = (4/3);
                double volume =  (tt) * (pi * (radius * radius * radius));
                double volume2 = volume/2;
                Console.WriteLine("Volume = " + volume2);
                Console.ReadKey();

            }
    }

        
}
    

