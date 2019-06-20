using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceCommandLine
{
    class Rectangle
    {
        public int a;
        public int b;

        public virtual int Obsah()
        {
            return a * b;
        }
    }
}
