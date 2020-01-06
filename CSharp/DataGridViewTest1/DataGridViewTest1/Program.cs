using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewTest1
{
    static class Program
    {
        public static MainCharterForm aMainCharterForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            aMainCharterForm = new MainCharterForm();
            Application.Run(aMainCharterForm);
        }
    }
}
