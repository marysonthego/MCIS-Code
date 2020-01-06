namespace Module9
{
    partial class Module9Ex1
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
            this.lblCount = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.grpFoodInfo = new System.Windows.Forms.GroupBox();
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
            this.foodManagerDataGridView = new System.Windows.Forms.DataGridView();
            this.foodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatGramsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carbGramsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proteinGramsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.grpFoodStats.SuspendLayout();
            this.grpFoodInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).BeginInit();
            this.grpTriggers.SuspendLayout();
            this.tabView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodManagerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodManagerBindingSource)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(782, 425);
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
            this.tabAdd.Size = new System.Drawing.Size(774, 383);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Add Food";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // grpFoodStats
            // 
            this.grpFoodStats.Controls.Add(this.lblTotalCalories);
            this.grpFoodStats.Controls.Add(this.btnTotal);
            this.grpFoodStats.Controls.Add(this.lblCount);
            this.grpFoodStats.Controls.Add(this.btnCount);
            this.grpFoodStats.Enabled = false;
            this.grpFoodStats.Location = new System.Drawing.Point(402, 18);
            this.grpFoodStats.Name = "grpFoodStats";
            this.grpFoodStats.Size = new System.Drawing.Size(361, 168);
            this.grpFoodStats.TabIndex = 8;
            this.grpFoodStats.TabStop = false;
            this.grpFoodStats.Text = "Food Summary";
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCalories.Location = new System.Drawing.Point(215, 99);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(116, 39);
            this.lblTotalCalories.TabIndex = 18;
            this.lblTotalCalories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(18, 99);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(175, 40);
            this.btnTotal.TabIndex = 17;
            this.btnTotal.Text = "Total Calories";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblCount
            // 
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.Location = new System.Drawing.Point(215, 36);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(116, 39);
            this.lblCount.TabIndex = 13;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(18, 38);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(175, 40);
            this.btnCount.TabIndex = 0;
            this.btnCount.Text = "How Many?";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // grpFoodInfo
            // 
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
            this.grpFoodInfo.Size = new System.Drawing.Size(388, 357);
            this.grpFoodInfo.TabIndex = 6;
            this.grpFoodInfo.TabStop = false;
            this.grpFoodInfo.Text = "Food Info:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(141, 299);
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
            this.lblCalories.Location = new System.Drawing.Point(141, 247);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(116, 39);
            this.lblCalories.TabIndex = 12;
            this.lblCalories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 247);
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
            this.nudProtein.Location = new System.Drawing.Point(141, 186);
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
            this.nudCarbs.Location = new System.Drawing.Point(141, 134);
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
            this.nudFat.Location = new System.Drawing.Point(141, 86);
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
            this.label3.Location = new System.Drawing.Point(7, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Protein:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carbs:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fat:";
            // 
            // grpTriggers
            // 
            this.grpTriggers.Controls.Add(this.btnExit);
            this.grpTriggers.Controls.Add(this.btnReset);
            this.grpTriggers.Location = new System.Drawing.Point(494, 204);
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
            this.tabView.Controls.Add(this.foodManagerDataGridView);
            this.tabView.Location = new System.Drawing.Point(4, 38);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(774, 383);
            this.tabView.TabIndex = 1;
            this.tabView.Text = "View Food";
            this.tabView.UseVisualStyleBackColor = true;
            // 
            // foodManagerDataGridView
            // 
            this.foodManagerDataGridView.AllowUserToAddRows = false;
            this.foodManagerDataGridView.AllowUserToDeleteRows = false;
            this.foodManagerDataGridView.AutoGenerateColumns = false;
            this.foodManagerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodManagerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodNameDataGridViewTextBoxColumn,
            this.fatGramsDataGridViewTextBoxColumn,
            this.carbGramsDataGridViewTextBoxColumn,
            this.proteinGramsDataGridViewTextBoxColumn,
            this.caloriesDataGridViewTextBoxColumn});
            this.foodManagerDataGridView.DataSource = this.foodManagerBindingSource;
            this.foodManagerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodManagerDataGridView.Location = new System.Drawing.Point(3, 3);
            this.foodManagerDataGridView.Name = "foodManagerDataGridView";
            this.foodManagerDataGridView.ReadOnly = true;
            this.foodManagerDataGridView.Size = new System.Drawing.Size(768, 377);
            this.foodManagerDataGridView.TabIndex = 0;
            // 
            // foodNameDataGridViewTextBoxColumn
            // 
            this.foodNameDataGridViewTextBoxColumn.DataPropertyName = "FoodName";
            this.foodNameDataGridViewTextBoxColumn.HeaderText = "Food";
            this.foodNameDataGridViewTextBoxColumn.Name = "foodNameDataGridViewTextBoxColumn";
            this.foodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.foodNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // fatGramsDataGridViewTextBoxColumn
            // 
            this.fatGramsDataGridViewTextBoxColumn.DataPropertyName = "FatGrams";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.fatGramsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.fatGramsDataGridViewTextBoxColumn.HeaderText = "Fat";
            this.fatGramsDataGridViewTextBoxColumn.Name = "fatGramsDataGridViewTextBoxColumn";
            this.fatGramsDataGridViewTextBoxColumn.ReadOnly = true;
            this.fatGramsDataGridViewTextBoxColumn.Width = 125;
            // 
            // carbGramsDataGridViewTextBoxColumn
            // 
            this.carbGramsDataGridViewTextBoxColumn.DataPropertyName = "CarbGrams";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.carbGramsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.carbGramsDataGridViewTextBoxColumn.HeaderText = "Carbs";
            this.carbGramsDataGridViewTextBoxColumn.Name = "carbGramsDataGridViewTextBoxColumn";
            this.carbGramsDataGridViewTextBoxColumn.ReadOnly = true;
            this.carbGramsDataGridViewTextBoxColumn.Width = 125;
            // 
            // proteinGramsDataGridViewTextBoxColumn
            // 
            this.proteinGramsDataGridViewTextBoxColumn.DataPropertyName = "ProteinGrams";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.proteinGramsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.proteinGramsDataGridViewTextBoxColumn.HeaderText = "Protein";
            this.proteinGramsDataGridViewTextBoxColumn.Name = "proteinGramsDataGridViewTextBoxColumn";
            this.proteinGramsDataGridViewTextBoxColumn.ReadOnly = true;
            this.proteinGramsDataGridViewTextBoxColumn.Width = 125;
            // 
            // caloriesDataGridViewTextBoxColumn
            // 
            this.caloriesDataGridViewTextBoxColumn.DataPropertyName = "Calories";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.caloriesDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.caloriesDataGridViewTextBoxColumn.HeaderText = "Calories";
            this.caloriesDataGridViewTextBoxColumn.Name = "caloriesDataGridViewTextBoxColumn";
            this.caloriesDataGridViewTextBoxColumn.ReadOnly = true;
            this.caloriesDataGridViewTextBoxColumn.Width = 125;
            // 
            // foodManagerBindingSource
            // 
            this.foodManagerBindingSource.DataMember = "FoodList";
            this.foodManagerBindingSource.DataSource = typeof(Module9.FoodManager);
            // 
            // Module9Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 425);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Module9Ex1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Module 9 - Example 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Module9Ex1_FormClosing);
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
            ((System.ComponentModel.ISupportInitialize)(this.foodManagerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodManagerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.GroupBox grpFoodInfo;
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
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.DataGridView foodManagerDataGridView;
        private System.Windows.Forms.BindingSource foodManagerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatGramsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carbGramsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteinGramsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloriesDataGridViewTextBoxColumn;
    }
}

