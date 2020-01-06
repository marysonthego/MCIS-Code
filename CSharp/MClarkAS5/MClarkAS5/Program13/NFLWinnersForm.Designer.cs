namespace Program13
{
    partial class NFLWinnersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NFLWinnersForm));
            this.cBoxAllTeams = new System.Windows.Forms.ComboBox();
            this.cBoxWinners = new System.Windows.Forms.ComboBox();
            this.btnWins = new System.Windows.Forms.Button();
            this.btnB2B = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTeams = new System.Windows.Forms.Label();
            this.lblChamps = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxAllTeams
            // 
            this.cBoxAllTeams.FormattingEnabled = true;
            this.cBoxAllTeams.Items.AddRange(new object[] {
            "49ers",
            "Bears",
            "Bengals",
            "Bills",
            "Broncos",
            "Browns",
            "Buccaneers",
            "Cardinals",
            "Chargers",
            "Chiefs",
            "Colts",
            "Cowboys",
            "Dolphins",
            "Eagles",
            "Falcons",
            "Giants",
            "Jaguars",
            "Jets",
            "Lions",
            "Packers",
            "Panthers",
            "Patriots",
            "Raiders",
            "Rams",
            "Ravens",
            "Redskins",
            "Saints",
            "Seahawks",
            "Steelers",
            "Texans",
            "Titans",
            "Vikings"});
            this.cBoxAllTeams.Location = new System.Drawing.Point(12, 36);
            this.cBoxAllTeams.Name = "cBoxAllTeams";
            this.cBoxAllTeams.Size = new System.Drawing.Size(121, 23);
            this.cBoxAllTeams.Sorted = true;
            this.cBoxAllTeams.TabIndex = 0;
            this.cBoxAllTeams.SelectedIndexChanged += new System.EventHandler(this.cBoxAllTeams_SelectedIndexChanged);
            // 
            // cBoxWinners
            // 
            this.cBoxWinners.Enabled = false;
            this.cBoxWinners.FormattingEnabled = true;
            this.cBoxWinners.Items.AddRange(new object[] {
            "Packers",
            "Packers",
            "Jets",
            "Chiefs",
            "Colts",
            "Cowboys",
            "Dolphins",
            "Dolphins",
            "Steelers",
            "Steelers",
            "Raiders",
            "Cowboys",
            "Steelers",
            "Steelers",
            "Raiders",
            "49ers",
            "Redskins",
            "Raiders",
            "49ers",
            "Bears",
            "Giants",
            "Redskins",
            "49ers",
            "49ers",
            "Giants",
            "Redskins",
            "Cowboys",
            "Cowboys",
            "49ers",
            "Cowboys",
            "Packers",
            "Broncos",
            "Broncos",
            "Rams",
            "Ravens",
            "Patriots",
            "Buccaneers",
            "Patriots",
            "Patriots",
            "Steelers",
            "Colts",
            "Giants",
            "Steelers",
            "Saints",
            "Packers",
            "Giants",
            "Ravens",
            "Seahawks",
            "Patriots",
            "Broncos",
            "Patriots",
            "Eagles"});
            this.cBoxWinners.Location = new System.Drawing.Point(166, 36);
            this.cBoxWinners.Name = "cBoxWinners";
            this.cBoxWinners.Size = new System.Drawing.Size(121, 23);
            this.cBoxWinners.TabIndex = 1;
           // this.cBoxWinners.SelectedIndexChanged += new System.EventHandler(this.cBoxWinners_SelectedIndexChanged);
            // 
            // btnWins
            // 
            this.btnWins.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnWins.Location = new System.Drawing.Point(411, 36);
            this.btnWins.Name = "btnWins";
            this.btnWins.Size = new System.Drawing.Size(127, 23);
            this.btnWins.TabIndex = 2;
            this.btnWins.Text = "How Many Wins?";
            this.btnWins.UseVisualStyleBackColor = true;
            this.btnWins.Click += new System.EventHandler(this.btnWins_Click);
            // 
            // btnB2B
            // 
            this.btnB2B.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnB2B.Location = new System.Drawing.Point(563, 36);
            this.btnB2B.Name = "btnB2B";
            this.btnB2B.Size = new System.Drawing.Size(199, 23);
            this.btnB2B.TabIndex = 3;
            this.btnB2B.Text = "How Many back-to-back Wins?";
            this.btnB2B.UseVisualStyleBackColor = true;
            this.btnB2B.Click += new System.EventHandler(this.btnB2B_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Location = new System.Drawing.Point(687, 349);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTeams.Location = new System.Drawing.Point(36, 9);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(72, 15);
            this.lblTeams.TabIndex = 5;
            this.lblTeams.Text = "NFL Teams";
            // 
            // lblChamps
            // 
            this.lblChamps.AutoSize = true;
            this.lblChamps.Enabled = false;
            this.lblChamps.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblChamps.Location = new System.Drawing.Point(188, 9);
            this.lblChamps.Name = "lblChamps";
            this.lblChamps.Size = new System.Drawing.Size(71, 15);
            this.lblChamps.TabIndex = 6;
            this.lblChamps.Text = "Champions";
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.BackColor = System.Drawing.Color.Transparent;
            this.lblDev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDev.Location = new System.Drawing.Point(12, 349);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(146, 15);
            this.lblDev.TabIndex = 7;
            this.lblDev.Text = "Developed by Mary Clark";
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.Color.Transparent;
            this.pBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pBox.InitialImage = null;
            this.pBox.Location = new System.Drawing.Point(483, 144);
            this.pBox.MaximumSize = new System.Drawing.Size(150, 100);
            this.pBox.MinimumSize = new System.Drawing.Size(150, 100);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(150, 100);
            this.pBox.TabIndex = 8;
            this.pBox.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResult.Location = new System.Drawing.Point(333, 87);
            this.lblResult.MinimumSize = new System.Drawing.Size(300, 23);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(300, 23);
            this.lblResult.TabIndex = 9;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblResult.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Program13.Properties.Resources.NFLlogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(104, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 114);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // NFLWinnersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Program13.Properties.Resources.super_bowl_play;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 384);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.lblChamps);
            this.Controls.Add(this.lblTeams);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnB2B);
            this.Controls.Add(this.btnWins);
            this.Controls.Add(this.cBoxWinners);
            this.Controls.Add(this.cBoxAllTeams);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(626, 340);
            this.Name = "NFLWinnersForm";
            this.Text = "NFL Super Bowl Winners";
          //  this.Load += new System.EventHandler(this.NFLWinnersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxAllTeams;
        private System.Windows.Forms.ComboBox cBoxWinners;
        private System.Windows.Forms.Button btnWins;
        private System.Windows.Forms.Button btnB2B;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.Label lblChamps;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

