/*
 * Class CharterSummaryForm 
 * A secondary form that displays the lowest charter fee
 * The total of all charter fees
 * The average charter fee
 * The total count of charters in CharterList
 * Developer: Mary Clark
 * December, 2018 for CIS605
 */

namespace MClarkAssignment7
{
    partial class CharterSummaryForm
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
            this.lblLowestCharterFeePrompt = new System.Windows.Forms.Label();
            this.lblTotalFeesPrompt = new System.Windows.Forms.Label();
            this.lblAverageFeePrompt = new System.Windows.Forms.Label();
            this.lblLowestCharterFee = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblAverageFee = new System.Windows.Forms.Label();
            this.lblCharterCount = new System.Windows.Forms.Label();
            this.lblCharterCountPrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLowestCharterFeePrompt
            // 
            this.lblLowestCharterFeePrompt.AutoSize = true;
            this.lblLowestCharterFeePrompt.Location = new System.Drawing.Point(29, 38);
            this.lblLowestCharterFeePrompt.Name = "lblLowestCharterFeePrompt";
            this.lblLowestCharterFeePrompt.Size = new System.Drawing.Size(134, 20);
            this.lblLowestCharterFeePrompt.TabIndex = 0;
            this.lblLowestCharterFeePrompt.Text = "Lowest Charter Fee";
            // 
            // lblTotalFeesPrompt
            // 
            this.lblTotalFeesPrompt.AutoSize = true;
            this.lblTotalFeesPrompt.Location = new System.Drawing.Point(29, 85);
            this.lblTotalFeesPrompt.Name = "lblTotalFeesPrompt";
            this.lblTotalFeesPrompt.Size = new System.Drawing.Size(189, 20);
            this.lblTotalFeesPrompt.TabIndex = 1;
            this.lblTotalFeesPrompt.Text = "Total Fees from all Charters";
            // 
            // lblAverageFeePrompt
            // 
            this.lblAverageFeePrompt.AutoSize = true;
            this.lblAverageFeePrompt.Location = new System.Drawing.Point(29, 128);
            this.lblAverageFeePrompt.Name = "lblAverageFeePrompt";
            this.lblAverageFeePrompt.Size = new System.Drawing.Size(192, 20);
            this.lblAverageFeePrompt.TabIndex = 2;
            this.lblAverageFeePrompt.Text = "Average Fee for all Charters";
            // 
            // lblLowestCharterFee
            // 
            this.lblLowestCharterFee.AutoSize = true;
            this.lblLowestCharterFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLowestCharterFee.Location = new System.Drawing.Point(308, 36);
            this.lblLowestCharterFee.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblLowestCharterFee.Name = "lblLowestCharterFee";
            this.lblLowestCharterFee.Size = new System.Drawing.Size(100, 22);
            this.lblLowestCharterFee.TabIndex = 3;
            this.lblLowestCharterFee.Text = "0.00";
            this.lblLowestCharterFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalFees.Location = new System.Drawing.Point(308, 77);
            this.lblTotalFees.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(100, 22);
            this.lblTotalFees.TabIndex = 4;
            this.lblTotalFees.Text = "0.00";
            this.lblTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAverageFee
            // 
            this.lblAverageFee.AutoSize = true;
            this.lblAverageFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAverageFee.Location = new System.Drawing.Point(308, 126);
            this.lblAverageFee.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblAverageFee.Name = "lblAverageFee";
            this.lblAverageFee.Size = new System.Drawing.Size(100, 22);
            this.lblAverageFee.TabIndex = 5;
            this.lblAverageFee.Text = "0.00";
            this.lblAverageFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCharterCount
            // 
            this.lblCharterCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCharterCount.Location = new System.Drawing.Point(308, 171);
            this.lblCharterCount.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblCharterCount.Name = "lblCharterCount";
            this.lblCharterCount.Size = new System.Drawing.Size(100, 22);
            this.lblCharterCount.TabIndex = 6;
            this.lblCharterCount.Text = "0";
            this.lblCharterCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCharterCountPrompt
            // 
            this.lblCharterCountPrompt.AutoSize = true;
            this.lblCharterCountPrompt.Location = new System.Drawing.Point(29, 173);
            this.lblCharterCountPrompt.Name = "lblCharterCountPrompt";
            this.lblCharterCountPrompt.Size = new System.Drawing.Size(100, 20);
            this.lblCharterCountPrompt.TabIndex = 7;
            this.lblCharterCountPrompt.Text = "Charter Count";
            // 
            // CharterSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 234);
            this.Controls.Add(this.lblCharterCountPrompt);
            this.Controls.Add(this.lblCharterCount);
            this.Controls.Add(this.lblAverageFee);
            this.Controls.Add(this.lblTotalFees);
            this.Controls.Add(this.lblLowestCharterFee);
            this.Controls.Add(this.lblAverageFeePrompt);
            this.Controls.Add(this.lblTotalFeesPrompt);
            this.Controls.Add(this.lblLowestCharterFeePrompt);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CharterSummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Charter Summary - Mary Clark";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLowestCharterFeePrompt;
        private System.Windows.Forms.Label lblTotalFeesPrompt;
        private System.Windows.Forms.Label lblAverageFeePrompt;
        internal System.Windows.Forms.Label lblLowestCharterFee;
        internal System.Windows.Forms.Label lblTotalFees;
        internal System.Windows.Forms.Label lblAverageFee;
        internal System.Windows.Forms.Label lblCharterCount;
        private System.Windows.Forms.Label lblCharterCountPrompt;
    }
}