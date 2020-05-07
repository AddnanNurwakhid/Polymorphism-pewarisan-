using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Canon Printer : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon Display dimension : 9.5*12");
        }
        public override void Print()
        {
            Console.WriteLine("Canon Printer Printing....  ");
        }
    }
}