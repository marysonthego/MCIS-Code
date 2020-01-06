/// Class Name: mClarkAssignment1.FrmMovie
/// Class Description: This part of the FrmMovie class is automatically generated 
/// by Visual Studio. It creates the form and
/// the controls on the form with the properties I have specified.
/// Developer Name: Mary Clark
/// Date Created: 9/2/2018
/// Date Last Modified: 9/9/2018
/// 

namespace mClarkAssignment1
{
    partial class FrmMovie
    {
        /// 
        /// Required designer variable.
        ///
        private System.ComponentModel.IContainer components = null;

        /// 
        /// Clean up any resources being used.
        /// 
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

        ///
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        ///
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovie));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnActor = new System.Windows.Forms.Button();
            this.btnActress = new System.Windows.Forms.Button();
            this.btnDirector = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblActorResult = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblActressResult = new System.Windows.Forms.Label();
            this.lblDirectorResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(254, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(313, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "The CIS 605 Movie";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.lblTitle, "Welcome to the CIS 605 Movie! Can you guess who\r\nthe lead actor, actress, and dir" +
        "ector are? Click each\r\nbutton to find out!");
            // 
            // btnActor
            // 
            this.btnActor.AutoSize = true;
            this.btnActor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnActor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActor.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActor.Location = new System.Drawing.Point(104, 200);
            this.btnActor.Name = "btnActor";
            this.btnActor.Size = new System.Drawing.Size(155, 40);
            this.btnActor.TabIndex = 1;
            this.btnActor.Text = "Lead Actor";
            this.toolTip1.SetToolTip(this.btnActor, "Click here to reveal the Lead Actor");
            this.btnActor.UseVisualStyleBackColor = false;
            this.btnActor.Click += new System.EventHandler(this.BtnActor_Click);
            // 
            // btnActress
            // 
            this.btnActress.AutoSize = true;
            this.btnActress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnActress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActress.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActress.Location = new System.Drawing.Point(104, 264);
            this.btnActress.Name = "btnActress";
            this.btnActress.Size = new System.Drawing.Size(155, 40);
            this.btnActress.TabIndex = 2;
            this.btnActress.Text = "Lead Actress";
            this.toolTip1.SetToolTip(this.btnActress, "Click here to reveal the Lead Actress");
            this.btnActress.UseVisualStyleBackColor = false;
            this.btnActress.Click += new System.EventHandler(this.BtnActress_Click);
            // 
            // btnDirector
            // 
            this.btnDirector.AutoSize = true;
            this.btnDirector.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDirector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDirector.CausesValidation = false;
            this.btnDirector.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirector.Location = new System.Drawing.Point(104, 328);
            this.btnDirector.Name = "btnDirector";
            this.btnDirector.Size = new System.Drawing.Size(155, 40);
            this.btnDirector.TabIndex = 3;
            this.btnDirector.Text = "Director";
            this.toolTip1.SetToolTip(this.btnDirector, "Click here to reveal the Director");
            this.btnDirector.UseVisualStyleBackColor = false;
            this.btnDirector.Click += new System.EventHandler(this.BtnDirector_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(688, 360);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Click here to exit the program.");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblActorResult
            // 
            this.lblActorResult.BackColor = System.Drawing.Color.Transparent;
            this.lblActorResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblActorResult.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActorResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblActorResult.Location = new System.Drawing.Point(400, 200);
            this.lblActorResult.Name = "lblActorResult";
            this.lblActorResult.Size = new System.Drawing.Size(200, 40);
            this.lblActorResult.TabIndex = 7;
            this.toolTip1.SetToolTip(this.lblActorResult, "The name of the lead actor is displayed here\r\nwhen you click the \"Lead Actor\" but" +
        "ton.\r\n");
            this.lblActorResult.UseMnemonic = false;
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblDeveloper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeveloper.CausesValidation = false;
            this.lblDeveloper.Location = new System.Drawing.Point(635, 408);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(128, 15);
            this.lblDeveloper.TabIndex = 8;
            this.lblDeveloper.Text = "Developed by Mary Clark";
            this.lblDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblDeveloper, resources.GetString("lblDeveloper.ToolTip"));
            // 
            // lblActressResult
            // 
            this.lblActressResult.BackColor = System.Drawing.Color.Transparent;
            this.lblActressResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblActressResult.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActressResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblActressResult.Location = new System.Drawing.Point(400, 264);
            this.lblActressResult.Name = "lblActressResult";
            this.lblActressResult.Size = new System.Drawing.Size(200, 40);
            this.lblActressResult.TabIndex = 9;
            this.toolTip1.SetToolTip(this.lblActressResult, "The name of the lead actress is displayed here\r\nwhen you click the \"Lead Actress\"" +
        " button.\r\n");
            this.lblActressResult.UseMnemonic = false;
            // 
            // lblDirectorResult
            // 
            this.lblDirectorResult.BackColor = System.Drawing.Color.Transparent;
            this.lblDirectorResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDirectorResult.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectorResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDirectorResult.Location = new System.Drawing.Point(400, 328);
            this.lblDirectorResult.Name = "lblDirectorResult";
            this.lblDirectorResult.Size = new System.Drawing.Size(200, 40);
            this.lblDirectorResult.TabIndex = 10;
            this.toolTip1.SetToolTip(this.lblDirectorResult, "The name of the director is displayed here\r\nwhen you click the \"Director\" button." +
        "\r\n");
            this.lblDirectorResult.UseMnemonic = false;
            // 
            // FrmMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.Controls.Add(this.lblDirectorResult);
            this.Controls.Add(this.lblActressResult);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.lblActorResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDirector);
            this.Controls.Add(this.btnActress);
            this.Controls.Add(this.btnActor);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmMovie";
            this.Text = "Movie";
            this.Load += new System.EventHandler(this.FrmMovie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnActor;
        private System.Windows.Forms.Button btnActress;
        private System.Windows.Forms.Button btnDirector;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblActorResult;
        private System.Windows.Forms.Label lblActressResult;
        private System.Windows.Forms.Label lblDirectorResult;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDeveloper;
        
        
    }
}