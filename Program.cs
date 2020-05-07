using system;

namespace Polymorphism
{
	class Program
	{
		static void Main(string[] args)
		{
			PrinterWindows printer;
			
			Console.WriteLine("Choose Printer : ");
			Console.WriteLine("1. Epson Printer");
			Console.WriteLine("2. Canon Printer");
			Console.WriteLine("3. LaserJet Printer\n");
			
			Console.Write("Type Bumber Printer [1..3]: ");
			int nomorPrinter = Convert.ToInt32(Console.ReadLine());
			
			if (nomorPrinter == 1){
				printer = new Epson Printer();
			}
			else if (nomorPrinter == 2){
				printer = new Canon Printer();
			}
			else{
				printer = new LaserJet Printer();
			}
			printer.Show();
			printer.Print();
			
			Console.ReadKey();
		}
	}	
}