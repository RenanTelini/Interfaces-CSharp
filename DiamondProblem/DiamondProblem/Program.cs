using DiamondProblem.Devices;

namespace DiamondProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080};
            Console.WriteLine("Printer class:");
            p.ProcessDoc("My letter - Printer.ProcessDoc");
            p.Print("My letter - Printer.Print");

            Console.WriteLine();
            Scanner s = new Scanner() { SerialNumber = 2003};
            Console.WriteLine("Scanner class:");
            s.ProcessDoc("My Email - Scanner.ProcessDoc");
            Console.WriteLine(s.Scan() + "Scanner.Scan");

            Console.WriteLine();
            ComboDevice c = new ComboDevice() { SerialNumber = 3921};
            Console.WriteLine("ComboDevice class:");
            c.ProcessDoc("My dissertation - ComboDevice.ProcessDoc");
            c.Print("My dissertation - ComboDevice.Print");
            Console.WriteLine(c.Scan() + "ComboDevice.Scan");
        }
    }
}