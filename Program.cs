using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThisIsWin11_Plugin_Builder
{
    internal static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main(string[] switches)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (switches.Length == 1)
            {
                string arg = switches[0].Trim();

                if (arg == "/basic")
                {
                    Form1 opentweaks = new Form1();
                    opentweaks.ShowDialog();
                }
                if (arg == "/advanced")
                {
                    Form2 opentweaks = new Form2();
                    opentweaks.ShowDialog();
                }
                if (arg == "/about")
                {
                    Form3 opentweaks = new Form3();
                    opentweaks.ShowDialog();
                }
                if (arg != "/about" && arg != "/basic" && arg != "/advanced")
                {
                    Application.Run(new Form1());
                }
            }
            else
            {
                Application.Run(new Form1());
            }
        }
    }
}
