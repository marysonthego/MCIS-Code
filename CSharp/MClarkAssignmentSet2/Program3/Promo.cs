/*
 * Class Name: MClarkAssignmentSet2.Program3.Promo
 * Class Description: Promo is the main entry point for the Promo application. 
 * By Default, Visual Studio generates this file with class name 'Program'.
 * 
 * The Promo class is static, meaning it cannot be instantiated, and all its members 
 * must also be static. The only member of Promo is Main(), which must be static 
 * since it is the entry point to the program. As a static member, it exists before any
 * instance objects are created. Note that Promo can be the entry point, but does not itself
 * have to be static.
 * 
 * The Promo class instantiates a PromoForm object and passes control to it.
 * Developer Name: Mary Clark
 * Date Created: 9/9/2018
 * Date Last Modified: 9/14/2018
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3
{
    static class Promo
    {
        /*
         * The main entry point for the Promo application.
         */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*
             * Create a new instance of PromoForm and pass control to it.
             */
            Application.Run(new PromoForm());
        }
    }
}
