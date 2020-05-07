using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Epson Printer : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Epson Display dimension : 10*11");
        }
        public override void Print()
        {
            Console.WriteLine("Epson Printer Printing....  ");
        }
    }
}