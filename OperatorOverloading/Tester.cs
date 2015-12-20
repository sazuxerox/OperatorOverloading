using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Tester
    {
        static void Main(string[] args)
        {
            var box1 = new Box();
            var box2 = new Box();
            var box3 = new Box();
            double volume = 0.0;

            //box1 specification
            box1.setBreadth(2.0);
            box1.setLength(1.0);
            box1.setheight(5.0);

            //box2 specification
            box2.setBreadth(2.0);
            box2.setLength(2.0);
            box2.setheight(2.0);

            volume = box1.getVolume();
            Console.WriteLine("Volume of Box1 : {0:f3}", volume);

            volume = box2.getVolume();
            Console.WriteLine("Volume of Box2 : {0:f3}", volume);

            box3 = box1 + box2;
            volume = box3.getVolume();
            Console.WriteLine("Volume of Box3: {0:f3}", volume);

            Console.ReadKey();
        }
    }
}
