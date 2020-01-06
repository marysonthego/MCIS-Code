namespace Module8
{
    partial class Module8Ex2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.grpFoodStats = new System.Windows.Forms.GroupBox();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.cboFoodType = new System.Windows.Forms.ComboBox();
            this.lblCountOf = new System.Windows.Forms.Label();
            this.btnCountOfType = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.grpFoodInfo = new System.Windows.Forms.GroupBox();
            this.cboFoodGroup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblCalories = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudProtein = new System.Windows.Forms.NumericUpDown();
            this.nudCarbs = new System.Windows.Forms.NumericUpDown();
            this.nudFat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTriggers = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabView = new System.Windows.Forms.TabPage();
            this.foodObjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.grpFoodStats.SuspendLayout();
            this.grpFoodInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).BeginInit();
            this.grpTriggers.SuspendLayout();
            this.tabView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodObjectsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAdd);
            this.tabControl1.Controls.Add(this.tabView);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(862, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.grpFoodStats);
            this.tabAdd.Controls.Add(this.grpFoodInfo);
            this.tabAdd.Controls.Add(this.grpTriggers);
            this.tabAdd.Location = new System.Drawing.Point(4, 38);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(854, 418);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Add Food";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // grpFoodStats
            // 
            this.grpFoodStats.Controls.Add(this.lblTotalCalories);
            this.grpFoodStats.Controls.Add(this.btnTotal);
            this.grpFoodStats.Controls.Add(this.cboFoodType);
            this.grpFoodStats.Controls.Add(this.lblCountOf);
            this.grpFoodStats.Controls.Add(this.btnCountOfType);
            this.grpFoodStats.Controls.Add(this.lblCount);
            this.grpFoodStats.Controls.Add(this.btnCount);
            this.grpFoodStats.Enabled = false;
            this.grpFoodStats.Location = new System.Drawing.Point(419, 18);
            this.grpFoodStats.Name = "grpFoodStats";
            this.grpFoodStats.Size = new System.Drawing.Size(425, 261);
            this.grpFoodStats.TabIndex = 8;
            this.grpFoodStats.TabStop = false;
            this.grpFoodStats.Text = "Food Summary";
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCalories.Location = new System.Drawing.Point(182, 205);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(116, 39);
            this.lblTotalCalories.TabIndex = 18;
            this.lblTotalCalories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(18, 204);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(142, 40);
            this.btnTotal.TabIndex = 17;
            this.btnTotal.Text = "Total Calories";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // cboFoodType
            // 
            this.cboFoodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFoodType.FormattingEnabled = true;
            this.cboFoodType.Location = new System.Drawing.Point(182, 100);
            this.cboFoodType.Name = "cboFoodType";
            this.cboFoodType.Size = new System.Drawing.Size(237, 37);
            this.cboFoodType.TabIndex = 16;
            // 
            // lblCountOf
            // 
            this.lblCountOf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCountOf.Location = new System.Drawing.Point(182, 152);
            this.lblCountOf.Name = "lblCountOf";
            this.lblCountOf.Size = new System.Drawing.Size(116, 39);
            this.lblCountOf.TabIndex = 15;
            this.lblCountOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCountOfType
            // 
            this.btnCountOfType.Location = new System.Drawing.Point(18, 95);
            this.btnCountOfType.Name = "btnCountOfType";
            this.btnCountOfType.Size = new System.Drawing.Size(142, 40);
            this.btnCountOfType.TabIndex = 14;
            this.btnCountOfType.Text = "How Many of?";
            this.btnCountOfType.UseVisualStyleBackColor = true;
            this.btnCountOfType.Click += new System.EventHandler(this.btnCountOfType_Click);
            // 
            // lblCount
            // 
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.Location = new System.Drawing.Point(182, 39);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(116, 39);
            this.lblCount.TabIndex = 13;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(18, 38);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(142, 40);
            this.btnCount.TabIndex = 0;
            this.btnCount.Text = "How Many?";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // grpFoodInfo
            // 
            this.grpFoodInfo.Controls.Add(this.cboFoodGroup);
            this.grpFoodInfo.Controls.Add(this.label5);
            this.grpFoodInfo.Controls.Add(this.btnCreate);
            this.grpFoodInfo.Controls.Add(this.lblCalories);
            this.grpFoodInfo.Controls.Add(this.label6);
            this.grpFoodInfo.Controls.Add(this.txtFoodName);
            this.grpFoodInfo.Controls.Add(this.label4);
            this.grpFoodInfo.Controls.Add(this.nudProtein);
            this.grpFoodInfo.Controls.Add(this.nudCarbs);
            this.grpFoodInfo.Controls.Add(this.nudFat);
            this.grpFoodInfo.Controls.Add(this.label3);
            this.grpFoodInfo.Controls.Add(this.label2);
            this.grpFoodInfo.Controls.Add(this.label1);
            this.grpFoodInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpFoodInfo.Location = new System.Drawing.Point(8, 18);
            this.grpFoodInfo.Name = "grpFoodInfo";
            this.grpFoodInfo.Size = new System.Drawing.Size(388, 393);
            this.grpFoodInfo.TabIndex = 6;
            this.grpFoodInfo.TabStop = false;
            this.grpFoodInfo.Text = "Food Info:";
            // 
            // cboFoodGroup
            // 
            this.cboFoodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFoodGroup.FormattingEnabled = true;
            this.cboFoodGroup.Location = new System.Drawing.Point(141, 85);
            this.cboFoodGroup.Name = "cboFoodGroup";
            this.cboFoodGroup.Size = new System.Drawing.Size(237, 37);
            this.cboFoodGroup.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Food Group:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(141, 345);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(183, 42);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "&Create Food Object";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblCalories
            // 
            this.lblCalories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCalories.Location = new System.Drawing.Point(141, 293);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(116, 39);
            this.lblCalories.TabIndex = 12;
            this.lblCalories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Calories";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(141, 38);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(241, 34);
            this.txtFoodName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name:";
            // 
            // nudProtein
            // 
            this.nudProtein.Location = new System.Drawing.Point(141, 232);
            this.nudProtein.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudProtein.Name = "nudProtein";
            this.nudProtein.Size = new System.Drawing.Size(116, 34);
            this.nudProtein.TabIndex = 8;
            this.nudProtein.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudCarbs
            // 
            this.nudCarbs.Location = new System.Drawing.Point(141, 180);
            this.nudCarbs.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudCarbs.Name = "nudCarbs";
            this.nudCarbs.Size = new System.Drawing.Size(116, 34);
            this.nudCarbs.TabIndex = 7;
            this.nudCarbs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudFat
            // 
            this.nudFat.Location = new System.Drawing.Point(141, 132);
            this.nudFat.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudFat.Name = "nudFat";
            this.nudFat.Size = new System.Drawing.Size(116, 34);
            this.nudFat.TabIndex = 6;
            this.nudFat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Protein:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carbs:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fat:";
            // 
            // grpTriggers
            // 
            this.grpTriggers.Controls.Add(this.btnExit);
            this.grpTriggers.Controls.Add(this.btnReset);
            this.grpTriggers.Location = new System.Drawing.Point(575, 285);
            this.grpTriggers.Name = "grpTriggers";
            this.grpTriggers.Size = new System.Drawing.Size(269, 72);
            this.grpTriggers.TabIndex = 7;
            this.grpTriggers.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(138, 24);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 42);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(6, 24);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 42);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.foodObjectsDataGridView);
            this.tabView.Location = new System.Drawing.Point(4, 38);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(854, 418);
            this.tabView.TabIndex = 1;
            this.tabView.Text = "View Food";
            this.tabView.UseVisualStyleBackColor = true;
            // 
            // foodObjectsDataGridView
            // 
            this.foodObjectsDataGridView.AllowUserToAddRows = false;
            this.foodObjectsDataGridView.AllowUserToDeleteRows = false;
            this.foodObjectsDataGridView.AutoGenerateColumns = false;
            this.foodObjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodObjectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6});
            this.foodObjectsDataGridView.DataSource = this.foodListBindingSource;
            this.foodObjectsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodObjectsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.foodObjectsDataGridView.Name = "foodObjectsDataGridView";
            this.foodObjectsDataGridView.ReadOnly = true;
            this.foodObjectsDataGridView.Size = new System.Drawing.Size(848, 428);
            this.foodObjectsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FoodName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Food";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FoodType";
            this.dataGridViewTextBoxColumn5.HeaderText = "Group";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FatGrams";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "Fat";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CarbGrams";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Carbs";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProteinGrams";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "Protein";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Calories";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn6.HeaderText = "Calories";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // foodListBindingSource
            // 
            this.foodListBindingSource.DataSource = typeof(Module8.Food);
            // 
            // Module8Ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 460);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Module8Ex2";
            this.Text = "Module 8 - Example 2";
            this.Load += new System.EventHandler(this.Module8Ex2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.grpFoodStats.ResumeLayout(false);
            this.grpFoodInfo.ResumeLayout(false);
            this.grpFoodInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).EndInit();
            this.grpTriggers.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodObjectsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.GroupBox grpFoodInfo;
        private System.Windows.Forms.ComboBox cboFoodGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudProtein;
        private System.Windows.Forms.NumericUpDown nudCarbs;
        private System.Windows.Forms.NumericUpDown nudFat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTriggers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.GroupBox grpFoodStats;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.ComboBox cboFoodType;
        private System.Windows.Forms.Label lblCountOf;
        private System.Windows.Forms.Button btnCountOfType;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.DataGridView foodObjectsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource foodListBindingSource;
    }
}

