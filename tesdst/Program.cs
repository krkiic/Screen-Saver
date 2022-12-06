

using System;
using System.Diagnostics;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace ConsoleApplication1
{
    class Program
    {
        

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        static void Main(string[] args)
        {


            Console.WriteLine("Press space to turn  off screen ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Spacebar)
            {
                SendMessage(GetConsoleWindow(), 0x0112, (IntPtr)0xF170, (IntPtr)2);

            }
            

        }
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

    }

    
}