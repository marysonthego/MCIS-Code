/*
 * Class Name: MClarkAssignmentSet3.Program
 * Class Description: Program is the main entry point for the Walk application. 
 * By Default, Visual Studio generates this file with class name 'Program'.
 * 
 * The Program class is static, meaning it cannot be instantiated, and all its members 
 * must also be static. The only member of Program is Main(), which must be static 
 * since it is the entry point to the program. As a static member, it exists before any
 * instance objects are created. Note that Program can be the entry point, but does not itself
 * have to be static.
 * 
 * The Program class instantiates a Program6Form object and passes control to it.
 * Developer Name: Mary Clark
 * Date Created: 9/30/2018
 * Date Last Modified: 9/30/2018
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MClarkAssignmentSet3
{
    static class Program
    {
        /*
        * The main entry point for the application.
        */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*
             * Create a new instance of Program6Form and pass control to it.
             */
            Application.Run(new Program6Form());
        }
    }
}
