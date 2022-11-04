using System;

namespace ConsoleApp12
{
    class Program
    {

        static void ShowWindow(int kx, int ky, int szelesseg, int magassag)
        {
            for (int oszlopEltolas = 0; oszlopEltolas < szelesseg; oszlopEltolas++)
            {
                for (int sorEltolas = 0; sorEltolas < magassag; sorEltolas++)
                {
                    Console.SetCursorPosition(kx + oszlopEltolas, ky + sorEltolas);
                    Console.Write('█');
                }
            }
        }
        static void zaszlo(ConsoleColor felso, ConsoleColor kozepso, ConsoleColor also)
        {

            Console.ForegroundColor = felso;
            ShowWindow(20, 0, 60, 10);
            Console.ForegroundColor = kozepso;
            ShowWindow(20, 10, 60, 10);
            Console.ForegroundColor = also;
            ShowWindow(20, 20, 60, 10);
        }
        static void Main(string[] args)
        {
            zaszlo(ConsoleColor.Red ,ConsoleColor.White,ConsoleColor.Green);
        }
    }
}
