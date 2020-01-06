namespace Program12
{
    partial class ProjectileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectileForm));
            this.lblInfoInitialHeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfoMaxHeight = new System.Windows.Forms.Label();
            this.lblMaxHeight = new System.Windows.Forms.Label();
            this.lblInfoLandTime = new System.Windows.Forms.Label();
            this.lblLandTime = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDev = new System.Windows.Forms.Label();
            this.nudInitialHeight = new System.Windows.Forms.NumericUpDown();
            this.nudInitialVelocity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialVelocity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfoInitialHeight
            // 
            resources.ApplyResources(this.lblInfoInitialHeight, "lblInfoInitialHeight");
            this.lblInfoInitialHeight.Name = "lblInfoInitialHeight";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblInfoMaxHeight
            // 
            resources.ApplyResources(this.lblInfoMaxHeight, "lblInfoMaxHeight");
            this.lblInfoMaxHeight.Name = "lblInfoMaxHeight";
            // 
            // lblMaxHeight
            // 
            resources.ApplyResources(this.lblMaxHeight, "lblMaxHeight");
            this.lblMaxHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaxHeight.Name = "lblMaxHeight";
            // 
            // lblInfoLandTime
            // 
            resources.ApplyResources(this.lblInfoLandTime, "lblInfoLandTime");
            this.lblInfoLandTime.Name = "lblInfoLandTime";
            // 
            // lblLandTime
            // 
            resources.ApplyResources(this.lblLandTime, "lblLandTime");
            this.lblLandTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLandTime.Name = "lblLandTime";
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDev
            // 
            resources.ApplyResources(this.lblDev, "lblDev");
            this.lblDev.Name = "lblDev";
            // 
            // nudInitialHeight
            // 
            resources.ApplyResources(this.nudInitialHeight, "nudInitialHeight");
            this.nudInitialHeight.Name = "nudInitialHeight";
            this.nudInitialHeight.ValueChanged += new System.EventHandler(this.nudInitialHeight_ValueChanged);
            // 
            // nudInitialVelocity
            // 
            this.nudInitialVelocity.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            resources.ApplyResources(this.nudInitialVelocity, "nudInitialVelocity");
            this.nudInitialVelocity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudInitialVelocity.Name = "nudInitialVelocity";
            this.nudInitialVelocity.ValueChanged += new System.EventHandler(this.nudInitialVelocity_ValueChanged);
            // 
            // ProjectileForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudInitialVelocity);
            this.Controls.Add(this.nudInitialHeight);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblLandTime);
            this.Controls.Add(this.lblInfoLandTime);
            this.Controls.Add(this.lblMaxHeight);
            this.Controls.Add(this.lblInfoMaxHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInfoInitialHeight);
            this.Name = "ProjectileForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialVelocity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInfoInitialHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfoMaxHeight;
        private System.Windows.Forms.Label lblMaxHeight;
        private System.Windows.Forms.Label lblInfoLandTime;
        private System.Windows.Forms.Label lblLandTime;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.NumericUpDown nudInitialHeight;
        private System.Windows.Forms.NumericUpDown nudInitialVelocity;
    }
}

