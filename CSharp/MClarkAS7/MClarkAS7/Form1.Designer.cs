﻿namespace MClarkAS7
{
    partial class Form1
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
            System.Windows.Forms.BindingSource charterManagerBindingSource;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.charterListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.charterFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charterHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yachtSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yachtTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            charterManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charterListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(charterManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.charterFeeDataGridViewTextBoxColumn,
            this.charterHoursDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.yachtSizeDataGridViewTextBoxColumn,
            this.yachtTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.charterListBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(126, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(662, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // charterListBindingSource
            // 
            //this.charterListBindingSource.DataMember = "CharterList";
            //this.charterListBindingSource.DataSource = charterManagerBindingSource;
            //this.charterListBindingSource.DataSource = aCharterManager.CharterList;
            this.charterListBindingSource.DataSource = typeof(MClarkAS7.CharterManager);
            // 
            // charterFeeDataGridViewTextBoxColumn
            // 
            this.charterFeeDataGridViewTextBoxColumn.DataPropertyName = "CharterFee";
            this.charterFeeDataGridViewTextBoxColumn.HeaderText = "CharterFee";
            this.charterFeeDataGridViewTextBoxColumn.Name = "charterFeeDataGridViewTextBoxColumn";
            this.charterFeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // charterHoursDataGridViewTextBoxColumn
            // 
            this.charterHoursDataGridViewTextBoxColumn.DataPropertyName = "CharterHours";
            this.charterHoursDataGridViewTextBoxColumn.HeaderText = "CharterHours";
            this.charterHoursDataGridViewTextBoxColumn.Name = "charterHoursDataGridViewTextBoxColumn";
            this.charterHoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yachtSizeDataGridViewTextBoxColumn
            // 
            this.yachtSizeDataGridViewTextBoxColumn.DataPropertyName = "YachtSize";
            this.yachtSizeDataGridViewTextBoxColumn.HeaderText = "YachtSize";
            this.yachtSizeDataGridViewTextBoxColumn.Name = "yachtSizeDataGridViewTextBoxColumn";
            this.yachtSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yachtTypeDataGridViewTextBoxColumn
            // 
            this.yachtTypeDataGridViewTextBoxColumn.DataPropertyName = "YachtType";
            this.yachtTypeDataGridViewTextBoxColumn.HeaderText = "YachtType";
            this.yachtTypeDataGridViewTextBoxColumn.Name = "yachtTypeDataGridViewTextBoxColumn";
            this.yachtTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // charterManagerBindingSource
            // 
            //charterManagerBindingSource.DataSource = typeof(MClarkAS7.CharterManager);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charterListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(charterManagerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn charterFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charterHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yachtSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yachtTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource charterListBindingSource;
    }
}