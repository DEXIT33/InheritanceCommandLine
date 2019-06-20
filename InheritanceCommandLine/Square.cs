using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceCommandLine
{
    class Square : Rectangle
    {
        public override int Obsah()
        {
            return a * a;
        }
    }
}
