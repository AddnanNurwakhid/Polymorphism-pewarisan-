using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class PrinterWindows
    {

            public virtual void Show()
            {
                Console.WriteLine("Display dimension : ");
            }
            public virtual void Print()
            {
                Console.WriteLine("Printer Printing.... ");
            }

    }
}
