/*
 * Class Name: MClarkAssignmentSet2.Program5.StartPaintJob
 * Class Description: The StartPaintJob class is the entry point into the PaintJob program. Main() instantiates a PaintJobForm.
 * Developer Name: Mary Clark
 * Date Created: 9/9/2018
 * Date Last Modified: 9/15/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program5
{
    /*
     * Internal is the default access level for a class declared directly in a namespace.
     * Declare internal static class StartPaintjob to start the PaintJob program by creating a new PaintJobForm
     */
    static class StartPaintJob
    {
        /*
        * The main entry point for the application.
        */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PaintJobForm());
        }
    }
}
