using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulearn_2
{
    public class PublicClass
    {
        public int PublicMethod() { return 0; }
        private int PrivateMethod() { return 0; }
        internal int InternalMethod() { return 0; }

        // Так делать нельзя: нарушение областей видимости класса InternalClass и метода
        // public InternalClass InternalMethodReturnsInternalClass() { return new InternalClass(); }
    }

    internal class InternalClass
    {
    }

    public class SomeOtherClass
    {
        public int SomeMethod()
        {
            var obj = new InternalClass();
            return new PublicClass().InternalMethod();
        }
    }
}
