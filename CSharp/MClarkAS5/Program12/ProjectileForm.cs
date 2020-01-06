/*
 * Class Name: MClarkAS5.Program12.ProjectileForm
 * Class Description: ProjectileForm instantiates a ProjectileForm to accept user
 * input for the initial height in feet and initial velocity in feet/second for a projectile. 
 * 
 * The class instantiates a Projectile object and displays the maximum height in feet 
 * the projectile will reach from the Projectile.MaxHeight property. The amount of time the projectile will be in the air in seconds is displayed from the Projectile.LandTime property. 
 * 
 * ProjectileForm instantiates a new Projectile object when the user changes the initial height, the initial velocity, or clicks the reset button. The exit button terminates the application.
 * 
 * 
 * Developer Name: Mary Clark
 * Date Created: 10/26/18
 * Date Last Modified: 10/30/18
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program12
{
    public partial class ProjectileForm : Form
    {

        /*
         * The constructor for ProjectileForm
         */
        public ProjectileForm()
        {
            InitializeComponent();
        }

        /*
         * The event handler for the reset button.
         * All values on the form are set to zero.
         * A new Projectile object is instantiated with zero initial height and velocity.
         */
        private void btnReset_Click(object sender, EventArgs e)
        {
            nudInitialHeight.Value = 0;
            nudInitialVelocity.Value = 0;
            int initialHeight = 0;
            int initialVelocity = 0;
            Projectile aProjectile = new Projectile(initialHeight, initialVelocity);
            lblMaxHeight.Text = aProjectile.MaxHeight.ToString("n0") + " feet";
            lblLandTime.Text = aProjectile.LandTime.ToString("n2") + " seconds";
        }

        /*
         * Event handler for the exit button.
         * The application is terminated when the exit button is clicked.
         */
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*
         * The event handler for the initial height numeric up/down control.
         * When the user changes the initial height value:
         *   A new projectile object is instantiated with 
         *   the new height and existing velocity.
         *   The maximum height label is updated with Projectile.MaxHeight
         *   the time in the air label is updated with Projectile.LandTime
         */
        private void nudInitialHeight_ValueChanged(object sender, EventArgs e)
        {
            int initialHeight = (int)nudInitialHeight.Value;
            int initialVelocity = (int)nudInitialVelocity.Value;
            Projectile aProjectile = new Projectile(initialHeight, initialVelocity);
            lblMaxHeight.Text = aProjectile.MaxHeight.ToString("n0") + " feet";
            lblLandTime.Text = aProjectile.LandTime.ToString("n2") + " seconds";
        }

        /*
         * The event handler for the initial velocity numeric up/down control.
         * When the user changes the initial velocity value:
         *   A new projectile object is instantiated with 
         *   the existing height and new velocity.
         *   The maximum height label is updated with Projectile.MaxHeight
         *   the time in the air label is updated with Projectile.LandTime
         */
        private void nudInitialVelocity_ValueChanged(object sender, EventArgs e)
        {
            int initialHeight = (int)nudInitialHeight.Value;
            int initialVelocity = (int)nudInitialVelocity.Value;
            Projectile aProjectile = new Projectile(initialHeight, initialVelocity);
            lblMaxHeight.Text = aProjectile.MaxHeight.ToString("n0") + " feet";
            lblLandTime.Text = aProjectile.LandTime.ToString("n2") + " seconds";
        }
    }
}
