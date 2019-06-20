using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceCommandLine
{
    class Rectangle
    {
        protected int a;
        protected int b;

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public virtual int Obsah()
        {
            return a * b;
        }
    }
}
