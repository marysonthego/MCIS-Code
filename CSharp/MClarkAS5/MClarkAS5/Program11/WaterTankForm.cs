/*
 * Class Name: MClarkAS5.Program11.WaterTankForm
 * Class Description: The WaterTankForm takes a tank radius in feet and an tank depth in feet entered by the user and creates a WaterTank object using the radius and depth provided.
 * The Maximum Water Level is calculated by using methods in the WaterTank class.
 * The current Water Level is calculated by using methods in the WaterTank class.
 * The user can add water, get water, fill the tank, or empty the tank by clicking buttons
 * on the form. User input is validated. Users are not allowed to add or fill a full tank,
 * nor can they get water from or empty an empty tank. Messages are displayed in an result
 * message label or (in the case of the fill and empty tank features) by an Error Provider.
 * The user can reset the form to create a new tank with different dimensions. The exit button terminates the program.
 * 
 * Developer Name: Mary Clark
 * Date Created: 10/17/18
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

namespace Program11
{
    public partial class WaterTankForm : Form
    {
        /*
         * Instance variables used by controls on a WaterTankForm
         */
        WaterTank aTank;
        bool radiusValid = false, depthValid = false, stringValid = false;
        int radius = 0, depth = 0;
        bool addWater = false, fill = false;
        int amount = 0;
        string errorMsg;

        /*
         * Constructor for WaterTankForm
         * Set focus to the radius entry textbox
         */
        public WaterTankForm()
        {
            InitializeComponent();
            tBoxRadius.Focus();
        }

        /*
         * Event handler for the Exit button
         * Terminate the application when exit is clicked.
         */
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /*
         * Event handler for the Reset button
         * Creates a new form with default values
         */
        private void btnReset_Click(object sender, EventArgs e)
        {
            WaterTankForm NewForm = new WaterTankForm();
            NewForm.Show();
        }

        /*
         * Event handler for the Radius textbox where the user enters
         * the radius of the water tank.
         * If the textbox loses focus, call ValidateRadius() to
         * check for a valid entry for the radius.
         */
        private void tBoxRadius_Leave(object sender, EventArgs e)
        {
            ValidateRadius();
        }

        /*
         * Event handler for the Radius textbox where the user enters
         * the radius of the water tank.
         * If the user has pressed the Enter key while the
         * radius textbox has focus, call ValidateRadius() to
         * check for a valid entry for the radius.
         */
        private void tBoxRadius_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateRadius();
            }
        } 

        /*
         * ValidateRadius is called when an event occurs on the tBoxRadius
         * input textbox. The method ensures that the user has entered
         * an integer between 1 and 99.
         * 
         * If the entry is invalid
         *   - lblResultMessage displays in red the message "<entry>" 
         *     is invalid.
         *     Enter the radius as an integer between 1 and 99".
         *   - An error icon is displayed next to tBoxRadius.
         *   -  tBoxRadius is cleared.
         *   - tBoxRadius is given the focus.
         * Else
         *   - depthValid is called to see if the depth is also valid.
         *     If the depth is valid
         *       - Instantiate a new WaterTank object
         *       - Display WaterTank.MaxCapacity in lblMaxLevel
         *       - Display zero in lblCurrentLevel
         */
        private void ValidateRadius()
        {
            radiusValid = int.TryParse(s: tBoxRadius.Text, result: out int aRadius);

            if (!radiusValid) //Invalid entry
            {
                lblResultMessage.Text = $"\"{tBoxRadius.Text}\" is invalid. \n\nEnter the radius as an integer between 1 and 99.";
                pBoxErrorRadius.Visible = true;
                lblResultMessage.ForeColor = Color.Red;
                lblResultMessage.Visible = true;
                tBoxRadius.Text = "";
                tBoxRadius.Focus();
            }
            else //Valid entry
            {
                pBoxErrorRadius.Visible = false;
                lblResultMessage.Visible = false;
                radius = aRadius;
                if (depthValid)
                {
                    aTank = new WaterTank(radius, depth);
                    lblMaxLevel.Text = aTank.MaxCapacity.ToString("n0");
                    lblCurrentLevel.Text = "0";
                    tBoxDebug.AppendText("\r\n\r\nValidateRadius\r\n");
                    tBoxDebug.AppendText(aTank.ToString());
                }
            }

        }

        /*
         * Event handler for the Depth textbox where the user enters
         * the depth of the water tank.
         * If the textbox loses focus, call ValidateDepth() to
         * check for a valid entry for the depth.
         */
        private void tBoxDepth_Leave(object sender, EventArgs e)
        {
            ValidateDepth();
        }

        /*
         * Event handler for the Depth textbox where the user enters
         * the depth of the water tank.
         * If the user has pressed the Enter key while the
         * depth textbox has focus, call ValidateDepth() to
         * check for a valid entry for the depth.
         */
        private void tBoxDepth_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateDepth();
            }
        }

        /*
         * ValidateDepth is called when an event occurs on the tBoxDepth
         * input textbox. The method ensures that the user has entered
         * an integer between 1 and 99.
         * 
         * If the entry is invalid
         *   - lblResultMessage displays in red the message "<entry>" 
         *     is invalid.
         *     Enter the depth as an integer between 1 and 99".
         *   - An error icon is displayed next to tBoxDepth.
         *   -  tBoxDepth is cleared.
         *   - tBoxDepth is given the focus.
         * Else
         *   - radiusValid is called to see if the radius is also valid.
         *     If the radius is valid
         *       - Instantiate a new WaterTank object
         *       - Display WaterTank.MaxCapacity in lblMaxLevel
         *       - Display zero in lblCurrentLevel
         */
        private void ValidateDepth()
        {
            depthValid = int.TryParse(s: tBoxDepth.Text, result: out int aDepth);

            if (!depthValid) //Bad entry
            {
                lblResultMessage.Text = $"\"{tBoxDepth.Text}\" is invalid." + Environment.NewLine + "Enter the depth as an integer between 1 and 99.";
                pBoxErrorDepth.Visible = true;
                lblResultMessage.ForeColor = Color.Red;
                lblResultMessage.Visible = true;
                tBoxDepth.Text = "";
                tBoxDepth.Focus();
            }
            else  //Good entry
            {
                pBoxErrorDepth.Visible = false;
                lblResultMessage.Visible = false;
                depth = aDepth;
                if (radiusValid)
                {
                    aTank = new WaterTank(radius, depth);
                    lblMaxLevel.Text = aTank.MaxCapacity.ToString("n0");
                    lblCurrentLevel.Text = "0";
                    tBoxDebug.AppendText("\r\n\r\nValidateDepth\r\n");
                    tBoxDebug.AppendText(aTank.ToString());
                }
            }
        }

        /* 
         * Event handler for tBoxGalAddOrGet. this textbox accepts
         * the number of gallons the user wants to add or remove
         * from the water tank.
         * When tBoxGalAddOrGet loses focus, call AddOrGetWater(). 
         */
        private void tBoxGalAddOrGet_Leave(object sender, EventArgs e)
        {
            AddOrGetWater();
        }

        /* The AddOrGetWater method first checks to see which button
         * was clicked - Add Water or Get Water.
         * 
         * If the Add Water button was clicked:
         *   Test the string entered in tBoxGalAddOrGet. 
         *   
         *     If the string is a valid integer,
         *       Call WaterTank.Addwater.
         *       
         *         If the result message contains the word "overflow", 
         *         We are trying to add too much water.
         *             Inform the user in lblResultMessage
         *             Put the amount that can be added in tBoxGalAddOrGet.
         *             Set focus to tBoxGalAddOrGet.
         *             Inform the user to press TAB to add that amount.
         *             
         *         If the result message from WaterTank.Addwater is good,
         *           Display the result in lblResultMessage.
         *           Append the new level to tBoxTankReading.
         *           Set lblCurrentlevel to the new level.
         *           
         *         if the tank is full, 
         *           tell the user in lblResultMessage.
         *           Hide the add water prompt.
         *           Hide tBoxGalAddOrGet.
         * 
         * Else the Get Water button was clicked:
         *   Test the string entered in tBoxGalAddOrGet.
         *   
         *     If the string is a valid integer
         *       Call WaterTank.WithdrawWater.
         *       
         *         If the result message contains the word "exceeds",
         *         we are trying to withdraw too much water.
         *         
         *           If the tank is empty,
         *             Tell the user in lblResultMessage.
         *             Hide the get water prompt.
         *             Hide tBoxGalAddOrGet.
         *           else
         *             Inform the user in lblResultMessage
         *             Put the amount that can be withdrawn in tBoxGalAddOrGet.
         *             Set focus to tBoxGalAddOrGet.
         *             Tell the user to press TAB to get that amount.
         *           
         *         Else the water was withdrawn
         *           Display the result message in lblResultMessage.
         *           Append the new water level to tBoxTankReading.
         *           Set lblCurrentLevel to the new level.
         *           Hide the get water prompt.
         *           Hide tBoxGalAddOrGet.
         */
        private void AddOrGetWater()
        {
            string theResult;
            string addOrGetString = tBoxGalAddOrGet.Text;

            stringValid = int.TryParse(addOrGetString, out int amount);

            if (addWater) //The Add button was clicked
            {
                if (stringValid) //User entered a valid integer to add
                {
                    theResult = aTank.AddWater(amount);
                    if (theResult.Contains("overflow")) //Too much water to add
                    {
                        int maxAddInt = aTank.MaxCanAdd;
                        string maxAdd = maxAddInt.ToString();

                        if (maxAddInt > 0)
                        {
                            lblResultMessage.Text = $"{theResult}\n\nClick TAB to add {maxAdd} gallons to the tank.";
                            tBoxGalAddOrGet.Text = maxAdd;
                            tBoxGalAddOrGet.Focus();
                        }
                        else //Tank is full
                        {
                            lblResultMessage.Text = "The tank is full." + Environment.NewLine + "Water cannot be added at this time.";
                            lblInfoGalAddOrGet.Visible = false;
                            tBoxGalAddOrGet.Visible = false;
                        }
                        lblResultMessage.ForeColor = Color.Red;
                        lblResultMessage.Visible = true;
                        lblCurrentLevel.Text = aTank.CurrentWaterLevel.ToString("n0");
                    }
                    else //water was added
                    {
                        lblResultMessage.Text = theResult;
                        lblResultMessage.ForeColor = Color.Black;
                        lblResultMessage.Visible = true;
                        lblCurrentLevel.Text = aTank.CurrentWaterLevel.ToString("n0");
                        tBoxTankReading.AppendText("\r\n" + aTank.CurrentWaterLevel.ToString("n0")); 
                        lblInfoGalAddOrGet.Visible = false;
                        tBoxGalAddOrGet.Visible = false;
                    }
                    tBoxDebug.AppendText("\r\n\r\naddWater\r\n");
                    tBoxDebug.AppendText(aTank.ToString());
                }
            }
            else  //The Get Water button was clicked
            {
                if (stringValid) //User entered a valid integer to get
                {
                    theResult = aTank.WithdrawWater(amount);

                    string maxGet = aTank.CurrentWaterLevel.ToString();

                    if (theResult.Contains("exceeds")) //Get too much water
                    {
                        lblResultMessage.ForeColor = Color.Red;
                        lblResultMessage.Visible = true;

                        if (aTank.CurrentWaterLevel == 0) //Tank is empty
                        {
                            lblResultMessage.Text = $"The current water level is {maxGet}." + Environment.NewLine + "The tank is empty.";
                            lblInfoGalAddOrGet.Visible = false;
                            tBoxGalAddOrGet.Visible = false;
                        }
                        else //Tank is not empty
                        {
                            lblResultMessage.Text = $"{theResult} \n\n Click TAB to get the maximum of {maxGet} gallons from the tank.";
                            tBoxGalAddOrGet.Text = maxGet;
                            tBoxGalAddOrGet.Focus();
                        }
                    }
                    else //water withdrawn
                    {
                        lblResultMessage.Text = theResult;
                        lblResultMessage.ForeColor = Color.Black;
                        lblResultMessage.Visible = true;
                        lblCurrentLevel.Text = aTank.CurrentWaterLevel.ToString("n0");
                        tBoxTankReading.AppendText("\r\n" + aTank.CurrentWaterLevel.ToString("n0"));
                        lblInfoGalAddOrGet.Visible = false;
                        tBoxGalAddOrGet.Visible = false;
                    }
                    tBoxDebug.AppendText("\r\n\r\ngetWater\r\n");
                    tBoxDebug.AppendText(aTank.ToString());
                }
            }
        }


        /*
         * Handler for the Add Water button
         * If a water tank has been created, the text box is displayed to enter the 
         * number of gallons to add.
         * If a water tank has not been created, NoTank is called.
         */
        private void btnAddWater_Click(object sender, EventArgs e)
        {
            addWater = true;

            if (aTank != null) //Tank exists
            {
                lblResultMessage.Visible = false;
                lblInfoGalAddOrGet.Text = "Enter gallons to add";
                lblInfoGalAddOrGet.Visible = true;
                tBoxGalAddOrGet.Text = "";
                tBoxGalAddOrGet.Visible = true;
                tBoxGalAddOrGet.Focus();
            }
            else //Tank does not exist
            {
                NoTank();
            }
        }
        
        /*
         * Event handler for the Get Water button
         * 
         * If a WaterTank exists
         *   
         *   If the tank is not empty
         *     The prompt to enter the gallons to withdraw is displayed
         *     tBoxGalAddOrGet is displayed for the user to enter the gallons
         *     Focus is set to tBoxGalAddOrGet
         *   
         *   Else, if the tank is empty
         *     A message is displayed in lblResultMessage
         *     The prompt to enter the gallons to withdraw is hidden
         *     tBoxGalAddOrGet is hidden
         *   
         * Else if a WaterTank does not exist
         *   NoTank() is called.
         */
        private void btnWithdrawWater_Click(object sender, EventArgs e)
        {
            addWater = false;
            string maxGetStr = aTank.CurrentWaterLevel.ToString();

            if (aTank != null) //aTank exists
            {
                if (aTank.CurrentWaterLevel > 0) //There is water in the tank
                {
                    lblResultMessage.Visible = false;
                    lblInfoGalAddOrGet.Text = "Enter gallons to withdraw";
                    lblInfoGalAddOrGet.Visible = true;
                    tBoxGalAddOrGet.Text = "";
                    tBoxGalAddOrGet.Visible = true;
                    tBoxGalAddOrGet.Focus();
                }
                else if (aTank.CurrentWaterLevel <= 0) //aTank is empty
                {
                    lblResultMessage.Text = $"The current water level in the tank is {maxGetStr}" + Environment.NewLine + "The tank is empty.";
                    lblResultMessage.ForeColor = Color.Red;
                    lblResultMessage.Visible = true;
                    lblInfoGalAddOrGet.Visible = false;
                    tBoxGalAddOrGet.Visible = false;
                }
            }
            else //aTank does not exist
            {
                NoTank();
            }
        }

        /*
         * Event handler for the Fill Tank button.
         * 
         * If a WaterTank exists
         * 
         *   If the tank is full
         *     Display a message in lblResultMessage
         *     Hide the prompt to add or get water 
         *     Hide tBoxGalPerSecond 
         *     
         *   Else the tank is not full
         *     Display a prompt to enter the fill rate in Gal/Sec
         *     Display tBoxGalPerSecond to enter the fill rate
         *     Put focus on tBoxGalPerSecond
         *     
         * Else a WaterTank does not exist
         *   Call NoTank()
         */
        private void btnFillTank_Click(object sender, EventArgs e)
        {
            fill = true;
            lblResultMessage.Visible = false;

            if (aTank != null) //Tank exists
            {
                if (aTank.CurrentWaterLevel == aTank.MaxCapacity)
                {
                    lblResultMessage.Text = "Cannot fill tank. The tank is already full.";
                    lblResultMessage.ForeColor = Color.Red;
                    lblResultMessage.Visible = true;
                    lblInfoGalPerSecond.Visible = false;
                    tBoxGalPerSecond.Visible = false;
                    return;
                }
                lblInfoGalPerSecond.Text = "Enter fill rate in Gal/Sec";
                lblInfoGalPerSecond.Visible = true;
                tBoxGalPerSecond.Text = "";
                tBoxGalPerSecond.Visible = true;
                tBoxGalPerSecond.Focus();
            }
            else //Tank does not exist
            {
                NoTank();
            }
        }

        /*
         * Event handler for the Empty Tank button.
         * 
         * If a WaterTank exists
         * 
         *   If the tank is empty
         *     Display a message in lblResultMessage
         *     Hide the prompt to add or get water 
         *     Hide tBoxGalPerSecond 
         *     
         *   Else the tank is not empty
         *     Display a prompt to enter the drain rate in Gal/Sec
         *     Display tBoxGalPerSecond to enter the drain rate
         *     Put focus on tBoxGalPerSecond
         *     
         * Else a WaterTank does not exist
         *   Call NoTank()
         */
        private void btnEmptyTank_Click(object sender, EventArgs e)
        {
            fill = false;
            lblResultMessage.Visible = false;

            if (aTank != null) //Tank exists
            {
                if (aTank.CurrentWaterLevel == 0) //Tank is empty
                {
                    lblResultMessage.Text = "Cannot empty tank. The tank is already empty.";
                    lblResultMessage.ForeColor = Color.Red;
                    lblResultMessage.Visible = true;
                    lblInfoGalPerSecond.Visible = false;
                    tBoxGalPerSecond.Visible = false;
                    return;
                }

                lblInfoGalPerSecond.Text = "Enter empty rate in Gal/Sec";
                lblInfoGalPerSecond.Visible = true;
                tBoxGalPerSecond.Text = "";
                tBoxGalPerSecond.Visible = true;
                tBoxGalPerSecond.Focus();
            }
            else //Tank does not exist
            {
                NoTank();
            }
        }

        /*
         * Event handler for tBoxGalPerSecond Validating event.
         *  
         * ErrorProvider1 handles errors in tBoxGalPerSecond instead of
         * reporting messages in lblResultMessage like all the other
         * controls.
         * 
         * This is a proof of concept.
         * 
         * tBoxGalPerSecond receives a Validating event every time
         * the user enters a new value in tBoxGalPerSecond.Text.
         * 
         * When tBoxGalPerSecond receives a Validating event,
         *   Call ValidGalPerSecond()
         *   
         *     If ValidGalPerSecond returns false, the entry was not valid,
         *        however, ValidGalPerSecond has already invoked the 
         *        error provider with an error message and error icon. 
         *        
         *        When the user enters a new value in response to a message
         *        from the error provider, we are in a new
         *        Validating event.
         *       
         *       This means, that upon return from ValidGalPerSecond(), 
         *       we must always cancel the previous error by setting 
         *       e.Cancel to true. 
         */
        private void tBoxGalPerSecond_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidGalPerSecond(tBoxGalPerSecond.Text, out errorMsg))
            {
                e.Cancel = true;
                tBoxGalPerSecond.Select(0, tBoxGalPerSecond.Text.Length);
                errorProvider1.SetError(tBoxGalPerSecond, errorMsg);
            }
        }

        /*
         * ValidGalPerSecond is called by tBoxGalPerSecond_Validating
         * to validate the user input using an error provider.
         */
        private bool ValidGalPerSecond(string entry, out string errorMsg)
        {
            int maxRate;
            if (fill)
                maxRate = aTank.MaxCanAdd;
            else
                maxRate = aTank.CurrentWaterLevel;

            if (entry.Length == 0) //tBoxGalPerSecond is blank
            {
                errorMsg = "Gallons per Second cannot be blank";
                return false;
            }

            stringValid = int.TryParse(s: entry, result: out amount);


            if (!stringValid)
            {
                errorMsg = "Enter a number";
                return false;
            }
            else
            {
                if (amount <= 0)
                {
                    errorMsg = "Gallons per Second cannot be less than 1";
                    return false;
                }
                else if (amount > maxRate)
                {
                    errorMsg = $"Rate cannot exceed {maxRate}";
                    return false;
                }
                else
                {
                    errorMsg = "";
                    return true;
                }
            }

        }

        /*
         * Event handler in response to tBoxGalPerSecond Validated events.
         * 
         * Set the error provider message to null.
         * If we are filling the tank call TankReadingFill()
         * If we are emptying the tank call TankReadingEmpty()
         * Hide the prompt to enter gal/sec
         * Hide tBoxGalPerSecond
         */
        private void tBoxGalPerSecond_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tBoxGalPerSecond, "");
            if (fill)
                TankReadingFill();
            else
                TankReadingEmpty();
            lblInfoGalPerSecond.Visible = false;
            tBoxGalPerSecond.Visible = false;
        }

        /*
         * TankReadingFill uses a while loop to append the current water level
         * to tBoxTankReading until we stop filling the tank.
         */
        private void TankReadingFill()
        {
            while (fill)
            {
                fill = aTank.FillTank(amount);
                tBoxTankReading.AppendText("\r\n" + aTank.CurrentWaterLevel.ToString("n0"));
                tBoxDebug.AppendText("\r\n\r\nTankReadingFill\r\n");
                tBoxDebug.AppendText(aTank.ToString());
            }
            lblCurrentLevel.Text = aTank.CurrentWaterLevel.ToString("n0");
        }

        /*
         * TankReadingEmpty uses a while loop to append the current water level
         * to tBoxTankReading until we stop emptying the tank.
         */
        private void TankReadingEmpty()
        {
            bool empty = true;
            while (empty)
            {
                empty = aTank.DrainTank(amount);
                tBoxTankReading.AppendText("\r\n" + aTank.CurrentWaterLevel.ToString("n0"));
                tBoxDebug.AppendText("\r\n\r\nTankReadingEmpty\r\n");
                tBoxDebug.AppendText(aTank.ToString());
            }
            lblCurrentLevel.Text = aTank.CurrentWaterLevel.ToString("n0");
        }
        
        /* NoTank displays an error in lblResultMessage and displays error icons next to radius and depth if the user attempts to add, get, 
         * fill, or empty a non-existent tank.
         */
        private void NoTank()
        {
            lblResultMessage.Text = "A tank does not exist.\n\nSpecify the size of the tank." + Environment.NewLine + "Enter the radius and depth of the tank in feet between 1 and 99.";
            lblResultMessage.ForeColor = Color.Red;
            lblResultMessage.Visible = true;
            pBoxErrorRadius.Visible = true;
            pBoxErrorDepth.Visible = true;
            tBoxGalPerSecond.Visible = false;
            lblInfoGalPerSecond.Visible = false;
            lblInfoGalPerSecond.Visible = false;
            tBoxGalPerSecond.Visible = false;
            tBoxRadius.Focus();
        }
    }
}
