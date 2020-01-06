/*
 * Class Name: MClarkAssignmentSet2.Program4.Program
 * Class Description: Class Program is the main entry point for the Investment application. 
 * By Default, Visual Studio generates this file with class name 'Program'.
 * The program class instantiates an InvestmentForm object and passes control to it.
 * Developer Name: Mary Clark
 * Date Created: 9/9/2018
 * Date Last Modified: 9/14/2018
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4
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
            Application.Run(new InvestmentForm());
        }
    }
}
