namespace Module6
{
    partial class Module6Ex2
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
            this.grpStockInfo = new System.Windows.Forms.GroupBox();
            this.txtPrices = new System.Windows.Forms.TextBox();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.grpTriggers = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpAnalysis = new System.Windows.Forms.GroupBox();
            this.lblMedian = new System.Windows.Forms.Label();
            this.btnMedian = new System.Windows.Forms.Button();
            this.lblStdDeviation = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.btnStdPrice = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnMaximum = new System.Windows.Forms.Button();
            this.btnMinimum = new System.Windows.Forms.Button();
            this.grpStockInfo.SuspendLayout();
            this.grpTriggers.SuspendLayout();
            this.grpAnalysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStockInfo
            // 
            this.grpStockInfo.Controls.Add(this.txtPrices);
            this.grpStockInfo.Controls.Add(this.txtSymbol);
            this.grpStockInfo.Controls.Add(this.btnCreate);
            this.grpStockInfo.Controls.Add(this.label2);
            this.grpStockInfo.Controls.Add(this.label1);
            this.grpStockInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpStockInfo.Location = new System.Drawing.Point(15, 72);
            this.grpStockInfo.Name = "grpStockInfo";
            this.grpStockInfo.Size = new System.Drawing.Size(353, 712);
            this.grpStockInfo.TabIndex = 0;
            this.grpStockInfo.TabStop = false;
            this.grpStockInfo.Text = "Stock Info:";
            // 
            // txtPrices
            // 
            this.txtPrices.Location = new System.Drawing.Point(196, 100);
            this.txtPrices.Multiline = true;
            this.txtPrices.Name = "txtPrices";
            this.txtPrices.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrices.Size = new System.Drawing.Size(138, 587);
            this.txtPrices.TabIndex = 10;
            this.txtPrices.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(196, 42);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(138, 32);
            this.txtSymbol.TabIndex = 9;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(15, 606);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(161, 81);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "&Create StockAnalyzer";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock Prices:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticker Symbol:";
            // 
            // lblMinimum
            // 
            this.lblMinimum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMinimum.Location = new System.Drawing.Point(247, 36);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(166, 41);
            this.lblMinimum.TabIndex = 16;
            this.lblMinimum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpTriggers
            // 
            this.grpTriggers.Controls.Add(this.btnExit);
            this.grpTriggers.Controls.Add(this.btnReset);
            this.grpTriggers.Location = new System.Drawing.Point(384, 411);
            this.grpTriggers.Name = "grpTriggers";
            this.grpTriggers.Size = new System.Drawing.Size(419, 86);
            this.grpTriggers.TabIndex = 1;
            this.grpTriggers.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(227, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(44, 21);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(148, 45);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(304, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "Test StockAnalyzer";
            // 
            // grpAnalysis
            // 
            this.grpAnalysis.Controls.Add(this.lblMedian);
            this.grpAnalysis.Controls.Add(this.btnMedian);
            this.grpAnalysis.Controls.Add(this.lblStdDeviation);
            this.grpAnalysis.Controls.Add(this.lblAverage);
            this.grpAnalysis.Controls.Add(this.lblMaximum);
            this.grpAnalysis.Controls.Add(this.btnStdPrice);
            this.grpAnalysis.Controls.Add(this.btnAverage);
            this.grpAnalysis.Controls.Add(this.btnMaximum);
            this.grpAnalysis.Controls.Add(this.btnMinimum);
            this.grpAnalysis.Controls.Add(this.lblMinimum);
            this.grpAnalysis.Enabled = false;
            this.grpAnalysis.Location = new System.Drawing.Point(384, 72);
            this.grpAnalysis.Name = "grpAnalysis";
            this.grpAnalysis.Size = new System.Drawing.Size(419, 333);
            this.grpAnalysis.TabIndex = 17;
            this.grpAnalysis.TabStop = false;
            this.grpAnalysis.Text = "Display Stats:";
            // 
            // lblMedian
            // 
            this.lblMedian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMedian.Location = new System.Drawing.Point(247, 217);
            this.lblMedian.Name = "lblMedian";
            this.lblMedian.Size = new System.Drawing.Size(166, 41);
            this.lblMedian.TabIndex = 24;
            this.lblMedian.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMedian
            // 
            this.btnMedian.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMedian.Location = new System.Drawing.Point(6, 215);
            this.btnMedian.Name = "btnMedian";
            this.btnMedian.Size = new System.Drawing.Size(220, 45);
            this.btnMedian.TabIndex = 23;
            this.btnMedian.Text = "Median";
            this.btnMedian.UseVisualStyleBackColor = true;
            this.btnMedian.Click += new System.EventHandler(this.btnMedian_Click);
            // 
            // lblStdDeviation
            // 
            this.lblStdDeviation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStdDeviation.Location = new System.Drawing.Point(247, 279);
            this.lblStdDeviation.Name = "lblStdDeviation";
            this.lblStdDeviation.Size = new System.Drawing.Size(166, 41);
            this.lblStdDeviation.TabIndex = 22;
            this.lblStdDeviation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAverage
            // 
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage.Location = new System.Drawing.Point(247, 158);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(166, 41);
            this.lblAverage.TabIndex = 21;
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaximum
            // 
            this.lblMaximum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaximum.Location = new System.Drawing.Point(247, 100);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(166, 41);
            this.lblMaximum.TabIndex = 20;
            this.lblMaximum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStdPrice
            // 
            this.btnStdPrice.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStdPrice.Location = new System.Drawing.Point(6, 279);
            this.btnStdPrice.Name = "btnStdPrice";
            this.btnStdPrice.Size = new System.Drawing.Size(220, 45);
            this.btnStdPrice.TabIndex = 19;
            this.btnStdPrice.Text = "Standard Deviation";
            this.btnStdPrice.UseVisualStyleBackColor = true;
            this.btnStdPrice.Click += new System.EventHandler(this.btnStdDeviation_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAverage.Location = new System.Drawing.Point(6, 154);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(220, 45);
            this.btnAverage.TabIndex = 18;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnMaximum
            // 
            this.btnMaximum.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMaximum.Location = new System.Drawing.Point(6, 95);
            this.btnMaximum.Name = "btnMaximum";
            this.btnMaximum.Size = new System.Drawing.Size(220, 45);
            this.btnMaximum.TabIndex = 17;
            this.btnMaximum.Text = "Maximum";
            this.btnMaximum.UseVisualStyleBackColor = true;
            this.btnMaximum.Click += new System.EventHandler(this.btnMaximum_Click);
            // 
            // btnMinimum
            // 
            this.btnMinimum.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMinimum.Location = new System.Drawing.Point(6, 36);
            this.btnMinimum.Name = "btnMinimum";
            this.btnMinimum.Size = new System.Drawing.Size(220, 45);
            this.btnMinimum.TabIndex = 1;
            this.btnMinimum.Text = "Minimum";
            this.btnMinimum.UseVisualStyleBackColor = true;
            this.btnMinimum.Click += new System.EventHandler(this.btnMinimum_Click);
            // 
            // Module6Ex2
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(829, 792);
            this.Controls.Add(this.grpAnalysis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpTriggers);
            this.Controls.Add(this.grpStockInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Module6Ex2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Module 6 - Example 2";
            this.grpStockInfo.ResumeLayout(false);
            this.grpStockInfo.PerformLayout();
            this.grpTriggers.ResumeLayout(false);
            this.grpAnalysis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStockInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTriggers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.TextBox txtPrices;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.GroupBox grpAnalysis;
        private System.Windows.Forms.Button btnMinimum;
        private System.Windows.Forms.Label lblMedian;
        private System.Windows.Forms.Button btnMedian;
        private System.Windows.Forms.Label lblStdDeviation;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.Button btnStdPrice;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnMaximum;
    }
}

