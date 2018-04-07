using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent component = new Component();
            component.operation();

            Console.WriteLine("Decorator A");
            IComponent sleepingStatus = new DecoratorA(new Component());
            Console.WriteLine(sleepingStatus.operation());

            Console.WriteLine("Decorator B");
            IComponent sleepingAndPlaceStatus = new DecoratorB(sleepingStatus, "sofa");
            Console.WriteLine(sleepingAndPlaceStatus.operation());

            Console.WriteLine("Press Enter to close..");
            Console.ReadLine();
        }
    }
}
