using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
    public class DecoratorB : IComponent
    {
        protected IComponent c;

        protected string sleepingPlace;

        public DecoratorB(IComponent c, string sleepingPlace)
        {
            this.c = c;
            this.sleepingPlace = sleepingPlace;
        }

        public string operation()
        {
            return c.operation() + "on" + operationSleepingPlace() ;
        }

        public string operationSleepingPlace()
        {
            return sleepingPlace;
        }
    }
}
