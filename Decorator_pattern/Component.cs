using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
    public class Component : IComponent
    {
        public string operation()
        {
            string strStatus = "I am sleeping";

            return strStatus;
        }
    }
}
