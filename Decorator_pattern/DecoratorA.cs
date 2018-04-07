using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
    public class DecoratorA : IComponent
    {
        private IComponent c;

        public DecoratorA(IComponent c)
        {
            this.c = c;
        }

        public string operation()
        {
            
            return c.operation() + "  and snoring  ";
        }
    }
}
