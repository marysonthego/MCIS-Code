namespace Program11
{
    partial class WaterTankForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaterTankForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblInfoCurrentLevel = new System.Windows.Forms.Label();
            this.lblCurrentLevel = new System.Windows.Forms.Label();
            this.lblInfoMaxLevel = new System.Windows.Forms.Label();
            this.lblMaxLevel = new System.Windows.Forms.Label();
            this.lblInfoGalAddOrGet = new System.Windows.Forms.Label();
            this.lblResultMessage = new System.Windows.Forms.Label();
            this.btnAddWater = new System.Windows.Forms.Button();
            this.btnWithdrawWater = new System.Windows.Forms.Button();
            this.btnFillTank = new System.Windows.Forms.Button();
            this.btnEmptyTank = new System.Windows.Forms.Button();
            this.lblInfoGalPerSecond = new System.Windows.Forms.Label();
            this.tBoxTankReading = new System.Windows.Forms.TextBox();
            this.lblInfoTankReading = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            this.lblInfoRadius = new System.Windows.Forms.Label();
            this.lblInfoDepth = new System.Windows.Forms.Label();
            this.tBoxRadius = new System.Windows.Forms.TextBox();
            this.tBoxDepth = new System.Windows.Forms.TextBox();
            this.tBoxGalPerSecond = new System.Windows.Forms.TextBox();
            this.tBoxGalAddOrGet = new System.Windows.Forms.TextBox();
            this.pBoxErrorRadius = new System.Windows.Forms.PictureBox();
            this.pBoxErrorDepth = new System.Windows.Forms.PictureBox();
            this.tBoxDebug = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxErrorRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxErrorDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(439, 496);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 33);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(320, 495);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 34);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblInfoCurrentLevel
            // 
            this.lblInfoCurrentLevel.AutoSize = true;
            this.lblInfoCurrentLevel.CausesValidation = false;
            this.lblInfoCurrentLevel.Location = new System.Drawing.Point(278, 15);
            this.lblInfoCurrentLevel.Name = "lblInfoCurrentLevel";
            this.lblInfoCurrentLevel.Size = new System.Drawing.Size(139, 18);
            this.lblInfoCurrentLevel.TabIndex = 99;
            this.lblInfoCurrentLevel.Text = "Current Water Level";
            // 
            // lblCurrentLevel
            // 
            this.lblCurrentLevel.AutoSize = true;
            this.lblCurrentLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentLevel.CausesValidation = false;
            this.lblCurrentLevel.Location = new System.Drawing.Point(439, 13);
            this.lblCurrentLevel.MinimumSize = new System.Drawing.Size(50, 20);
            this.lblCurrentLevel.Name = "lblCurrentLevel";
            this.lblCurrentLevel.Size = new System.Drawing.Size(50, 20);
            this.lblCurrentLevel.TabIndex = 99;
            this.lblCurrentLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInfoMaxLevel
            // 
            this.lblInfoMaxLevel.AutoSize = true;
            this.lblInfoMaxLevel.CausesValidation = false;
            this.lblInfoMaxLevel.Location = new System.Drawing.Point(278, 54);
            this.lblInfoMaxLevel.Name = "lblInfoMaxLevel";
            this.lblInfoMaxLevel.Size = new System.Drawing.Size(155, 18);
            this.lblInfoMaxLevel.TabIndex = 99;
            this.lblInfoMaxLevel.Text = "Maximum Water Level";
            // 
            // lblMaxLevel
            // 
            this.lblMaxLevel.AutoSize = true;
            this.lblMaxLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaxLevel.CausesValidation = false;
            this.lblMaxLevel.Location = new System.Drawing.Point(439, 54);
            this.lblMaxLevel.MinimumSize = new System.Drawing.Size(50, 20);
            this.lblMaxLevel.Name = "lblMaxLevel";
            this.lblMaxLevel.Size = new System.Drawing.Size(50, 20);
            this.lblMaxLevel.TabIndex = 99;
            this.lblMaxLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInfoGalAddOrGet
            // 
            this.lblInfoGalAddOrGet.AutoSize = true;
            this.lblInfoGalAddOrGet.Location = new System.Drawing.Point(278, 153);
            this.lblInfoGalAddOrGet.Name = "lblInfoGalAddOrGet";
            this.lblInfoGalAddOrGet.Size = new System.Drawing.Size(0, 18);
            this.lblInfoGalAddOrGet.TabIndex = 22;
            this.lblInfoGalAddOrGet.Visible = false;
            // 
            // lblResultMessage
            // 
            this.lblResultMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultMessage.ForeColor = System.Drawing.Color.Red;
            this.lblResultMessage.Location = new System.Drawing.Point(18, 100);
            this.lblResultMessage.MinimumSize = new System.Drawing.Size(239, 224);
            this.lblResultMessage.Name = "lblResultMessage";
            this.lblResultMessage.Size = new System.Drawing.Size(239, 224);
            this.lblResultMessage.TabIndex = 99;
            this.lblResultMessage.Visible = false;
            // 
            // btnAddWater
            // 
            this.btnAddWater.Location = new System.Drawing.Point(291, 100);
            this.btnAddWater.Name = "btnAddWater";
            this.btnAddWater.Size = new System.Drawing.Size(89, 30);
            this.btnAddWater.TabIndex = 5;
            this.btnAddWater.Text = "&Add Water";
            this.btnAddWater.UseVisualStyleBackColor = true;
            this.btnAddWater.Click += new System.EventHandler(this.btnAddWater_Click);
            // 
            // btnWithdrawWater
            // 
            this.btnWithdrawWater.Location = new System.Drawing.Point(428, 100);
            this.btnWithdrawWater.Name = "btnWithdrawWater";
            this.btnWithdrawWater.Size = new System.Drawing.Size(86, 30);
            this.btnWithdrawWater.TabIndex = 7;
            this.btnWithdrawWater.Text = "&Get Water";
            this.btnWithdrawWater.UseVisualStyleBackColor = true;
            this.btnWithdrawWater.Click += new System.EventHandler(this.btnWithdrawWater_Click);
            // 
            // btnFillTank
            // 
            this.btnFillTank.Location = new System.Drawing.Point(13, 336);
            this.btnFillTank.Name = "btnFillTank";
            this.btnFillTank.Size = new System.Drawing.Size(75, 32);
            this.btnFillTank.TabIndex = 2;
            this.btnFillTank.Text = "&Fill Tank";
            this.btnFillTank.UseVisualStyleBackColor = true;
            this.btnFillTank.Click += new System.EventHandler(this.btnFillTank_Click);
            // 
            // btnEmptyTank
            // 
            this.btnEmptyTank.Location = new System.Drawing.Point(151, 336);
            this.btnEmptyTank.Name = "btnEmptyTank";
            this.btnEmptyTank.Size = new System.Drawing.Size(106, 32);
            this.btnEmptyTank.TabIndex = 5;
            this.btnEmptyTank.Text = "&Empty Tank";
            this.btnEmptyTank.UseVisualStyleBackColor = true;
            this.btnEmptyTank.Click += new System.EventHandler(this.btnEmptyTank_Click);
            // 
            // lblInfoGalPerSecond
            // 
            this.lblInfoGalPerSecond.AutoSize = true;
            this.lblInfoGalPerSecond.CausesValidation = false;
            this.lblInfoGalPerSecond.Location = new System.Drawing.Point(15, 388);
            this.lblInfoGalPerSecond.MinimumSize = new System.Drawing.Size(170, 18);
            this.lblInfoGalPerSecond.Name = "lblInfoGalPerSecond";
            this.lblInfoGalPerSecond.Size = new System.Drawing.Size(170, 18);
            this.lblInfoGalPerSecond.TabIndex = 22;
            this.lblInfoGalPerSecond.Visible = false;
            // 
            // tBoxTankReading
            // 
            this.tBoxTankReading.AcceptsReturn = true;
            this.tBoxTankReading.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tBoxTankReading.Location = new System.Drawing.Point(124, 423);
            this.tBoxTankReading.MinimumSize = new System.Drawing.Size(106, 66);
            this.tBoxTankReading.Multiline = true;
            this.tBoxTankReading.Name = "tBoxTankReading";
            this.tBoxTankReading.ReadOnly = true;
            this.tBoxTankReading.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxTankReading.Size = new System.Drawing.Size(106, 66);
            this.tBoxTankReading.TabIndex = 4;
            this.tBoxTankReading.Text = "0";
            this.tBoxTankReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblInfoTankReading
            // 
            this.lblInfoTankReading.AutoSize = true;
            this.lblInfoTankReading.Location = new System.Drawing.Point(15, 449);
            this.lblInfoTankReading.Name = "lblInfoTankReading";
            this.lblInfoTankReading.Size = new System.Drawing.Size(103, 18);
            this.lblInfoTankReading.TabIndex = 99;
            this.lblInfoTankReading.Text = "Tank Reading:";
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.CausesValidation = false;
            this.lblDev.Location = new System.Drawing.Point(12, 511);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(173, 18);
            this.lblDev.TabIndex = 99;
            this.lblDev.Text = "Developed by Mary Clark";
            // 
            // lblInfoRadius
            // 
            this.lblInfoRadius.AutoSize = true;
            this.lblInfoRadius.CausesValidation = false;
            this.lblInfoRadius.Location = new System.Drawing.Point(15, 15);
            this.lblInfoRadius.Name = "lblInfoRadius";
            this.lblInfoRadius.Size = new System.Drawing.Size(162, 18);
            this.lblInfoRadius.TabIndex = 99;
            this.lblInfoRadius.Text = "Enter tank radius in feet";
            // 
            // lblInfoDepth
            // 
            this.lblInfoDepth.AutoSize = true;
            this.lblInfoDepth.CausesValidation = false;
            this.lblInfoDepth.Location = new System.Drawing.Point(15, 54);
            this.lblInfoDepth.Name = "lblInfoDepth";
            this.lblInfoDepth.Size = new System.Drawing.Size(158, 18);
            this.lblInfoDepth.TabIndex = 99;
            this.lblInfoDepth.Text = "Enter tank depth in feet";
            // 
            // tBoxRadius
            // 
            this.tBoxRadius.Location = new System.Drawing.Point(175, 12);
            this.tBoxRadius.MaxLength = 2;
            this.tBoxRadius.Name = "tBoxRadius";
            this.tBoxRadius.Size = new System.Drawing.Size(39, 24);
            this.tBoxRadius.TabIndex = 0;
            this.tBoxRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBoxRadius.WordWrap = false;
            this.tBoxRadius.Leave += new System.EventHandler(this.tBoxRadius_Leave);
            // 
            // tBoxDepth
            // 
            this.tBoxDepth.Location = new System.Drawing.Point(175, 51);
            this.tBoxDepth.MaxLength = 2;
            this.tBoxDepth.Name = "tBoxDepth";
            this.tBoxDepth.Size = new System.Drawing.Size(39, 24);
            this.tBoxDepth.TabIndex = 1;
            this.tBoxDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBoxDepth.WordWrap = false;
            this.tBoxDepth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tBoxDepth_KeyUp);
            this.tBoxDepth.Leave += new System.EventHandler(this.tBoxDepth_Leave);
            // 
            // tBoxGalPerSecond
            // 
            this.tBoxGalPerSecond.Location = new System.Drawing.Point(220, 385);
            this.tBoxGalPerSecond.MaxLength = 999;
            this.tBoxGalPerSecond.MinimumSize = new System.Drawing.Size(50, 24);
            this.tBoxGalPerSecond.Name = "tBoxGalPerSecond";
            this.tBoxGalPerSecond.Size = new System.Drawing.Size(50, 24);
            this.tBoxGalPerSecond.TabIndex = 3;
            this.tBoxGalPerSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBoxGalPerSecond.Visible = false;
            this.tBoxGalPerSecond.WordWrap = false;
            this.tBoxGalPerSecond.Validating += new System.ComponentModel.CancelEventHandler(this.tBoxGalPerSecond_Validating);
            this.tBoxGalPerSecond.Validated += new System.EventHandler(this.tBoxGalPerSecond_Validated);
            // 
            // tBoxGalAddOrGet
            // 
            this.tBoxGalAddOrGet.Location = new System.Drawing.Point(444, 147);
            this.tBoxGalAddOrGet.MinimumSize = new System.Drawing.Size(50, 20);
            this.tBoxGalAddOrGet.Name = "tBoxGalAddOrGet";
            this.tBoxGalAddOrGet.Size = new System.Drawing.Size(70, 24);
            this.tBoxGalAddOrGet.TabIndex = 6;
            this.tBoxGalAddOrGet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBoxGalAddOrGet.Visible = false;
            this.tBoxGalAddOrGet.WordWrap = false;
            this.tBoxGalAddOrGet.Leave += new System.EventHandler(this.tBoxGalAddOrGet_Leave);
            // 
            // pBoxErrorRadius
            // 
            this.pBoxErrorRadius.Image = ((System.Drawing.Image)(resources.GetObject("pBoxErrorRadius.Image")));
            this.pBoxErrorRadius.InitialImage = null;
            this.pBoxErrorRadius.Location = new System.Drawing.Point(220, 15);
            this.pBoxErrorRadius.MaximumSize = new System.Drawing.Size(16, 16);
            this.pBoxErrorRadius.MinimumSize = new System.Drawing.Size(16, 16);
            this.pBoxErrorRadius.Name = "pBoxErrorRadius";
            this.pBoxErrorRadius.Size = new System.Drawing.Size(16, 16);
            this.pBoxErrorRadius.TabIndex = 24;
            this.pBoxErrorRadius.TabStop = false;
            this.pBoxErrorRadius.Visible = false;
            // 
            // pBoxErrorDepth
            // 
            this.pBoxErrorDepth.Image = ((System.Drawing.Image)(resources.GetObject("pBoxErrorDepth.Image")));
            this.pBoxErrorDepth.InitialImage = null;
            this.pBoxErrorDepth.Location = new System.Drawing.Point(220, 56);
            this.pBoxErrorDepth.MaximumSize = new System.Drawing.Size(16, 16);
            this.pBoxErrorDepth.MinimumSize = new System.Drawing.Size(16, 16);
            this.pBoxErrorDepth.Name = "pBoxErrorDepth";
            this.pBoxErrorDepth.Size = new System.Drawing.Size(16, 16);
            this.pBoxErrorDepth.TabIndex = 25;
            this.pBoxErrorDepth.TabStop = false;
            this.pBoxErrorDepth.Visible = false;
            // 
            // tBoxDebug
            // 
            this.tBoxDebug.AcceptsReturn = true;
            this.tBoxDebug.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tBoxDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxDebug.Location = new System.Drawing.Point(291, 177);
            this.tBoxDebug.MinimumSize = new System.Drawing.Size(223, 310);
            this.tBoxDebug.Multiline = true;
            this.tBoxDebug.Name = "tBoxDebug";
            this.tBoxDebug.ReadOnly = true;
            this.tBoxDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxDebug.Size = new System.Drawing.Size(223, 310);
            this.tBoxDebug.TabIndex = 100;
            this.tBoxDebug.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // WaterTankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(532, 554);
            this.Controls.Add(this.tBoxDebug);
            this.Controls.Add(this.pBoxErrorDepth);
            this.Controls.Add(this.pBoxErrorRadius);
            this.Controls.Add(this.tBoxGalAddOrGet);
            this.Controls.Add(this.tBoxGalPerSecond);
            this.Controls.Add(this.tBoxDepth);
            this.Controls.Add(this.tBoxRadius);
            this.Controls.Add(this.lblInfoDepth);
            this.Controls.Add(this.lblInfoRadius);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.lblInfoTankReading);
            this.Controls.Add(this.tBoxTankReading);
            this.Controls.Add(this.lblInfoGalPerSecond);
            this.Controls.Add(this.btnEmptyTank);
            this.Controls.Add(this.btnFillTank);
            this.Controls.Add(this.btnWithdrawWater);
            this.Controls.Add(this.btnAddWater);
            this.Controls.Add(this.lblResultMessage);
            this.Controls.Add(this.lblInfoGalAddOrGet);
            this.Controls.Add(this.lblMaxLevel);
            this.Controls.Add(this.lblInfoMaxLevel);
            this.Controls.Add(this.lblCurrentLevel);
            this.Controls.Add(this.lblInfoCurrentLevel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WaterTankForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Water Tank Control";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxErrorRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxErrorDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblInfoCurrentLevel;
        private System.Windows.Forms.Label lblCurrentLevel;
        private System.Windows.Forms.Label lblInfoMaxLevel;
        private System.Windows.Forms.Label lblMaxLevel;
        private System.Windows.Forms.Label lblInfoGalAddOrGet;
        private System.Windows.Forms.Label lblResultMessage;
        private System.Windows.Forms.Button btnAddWater;
        private System.Windows.Forms.Button btnWithdrawWater;
        private System.Windows.Forms.Button btnFillTank;
        private System.Windows.Forms.Button btnEmptyTank;
        private System.Windows.Forms.Label lblInfoGalPerSecond;
        private System.Windows.Forms.TextBox tBoxTankReading;
        private System.Windows.Forms.Label lblInfoTankReading;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Label lblInfoRadius;
        private System.Windows.Forms.Label lblInfoDepth;
        private System.Windows.Forms.TextBox tBoxRadius;
        private System.Windows.Forms.TextBox tBoxDepth;
        private System.Windows.Forms.TextBox tBoxGalPerSecond;
        private System.Windows.Forms.TextBox tBoxGalAddOrGet;
        private System.Windows.Forms.PictureBox pBoxErrorRadius;
        private System.Windows.Forms.PictureBox pBoxErrorDepth;
        private System.Windows.Forms.TextBox tBoxDebug;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

