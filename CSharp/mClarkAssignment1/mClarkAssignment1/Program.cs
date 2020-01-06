/// Class Name: mClarkAssignment1.Program
/// Class Description: The main entry point for the Movie application.
/// Developer Name: Mary Clark
/// Date Created: 9/2/2018
/// Date Last Modified: 9/9/2018
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mClarkAssignment1
{
    static class Program
    {
        ///
        /// The main entry point for the application.
        ///
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ///
            /// Instantiate an object of type mClarkAssignment1.FrmMovie
            /// 
            Application.Run(new FrmMovie());
        }
    }
}
