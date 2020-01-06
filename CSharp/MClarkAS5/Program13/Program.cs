/*
 * Class Name: MClarkAS5.Program13.Program
 * Class Description: Main entry point for NFLWinnersForm
 * 
 * Developer Name: Mary Clark
 * Date Created: 10/26/2018
 * Date Last Modified: 10/30/2018
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program13
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NFLWinnersForm());
        }
    }
}
