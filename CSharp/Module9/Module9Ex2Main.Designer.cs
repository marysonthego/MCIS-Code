namespace Module9
{
    partial class Module9Ex2Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.foodManagerDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.foodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatGramsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carbGramsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proteinGramsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.foodManagerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // foodManagerDataGridView
            // 
            this.foodManagerDataGridView.AutoGenerateColumns = false;
            this.foodManagerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodManagerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodNameDataGridViewTextBoxColumn,
            this.fatGramsDataGridViewTextBoxColumn,
            this.carbGramsDataGridViewTextBoxColumn,
            this.proteinGramsDataGridViewTextBoxColumn,
            this.caloriesDataGridViewTextBoxColumn});
            this.foodManagerDataGridView.DataSource = this.foodManagerBindingSource;
            this.foodManagerDataGridView.Location = new System.Drawing.Point(-4, 1);
            this.foodManagerDataGridView.Name = "foodManagerDataGridView";
            this.foodManagerDataGridView.Size = new System.Drawing.Size(850, 398);
            this.foodManagerDataGridView.TabIndex = 1;
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(22, 413);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(202, 38);
            this.btnSummary.TabIndex = 2;
            this.btnSummary.Text = "Show Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(624, 413);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(202, 38);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // foodNameDataGridViewTextBoxColumn
            // 
            this.foodNameDataGridViewTextBoxColumn.DataPropertyName = "FoodName";
            dataGridViewCellStyle1.NullValue = null;
            this.foodNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.foodNameDataGridViewTextBoxColumn.HeaderText = "Food";
            this.foodNameDataGridViewTextBoxColumn.Name = "foodNameDataGridViewTextBoxColumn";
            this.foodNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // fatGramsDataGridViewTextBoxColumn
            // 
            this.fatGramsDataGridViewTextBoxColumn.DataPropertyName = "FatGrams";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.fatGramsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.fatGramsDataGridViewTextBoxColumn.HeaderText = "Fat";
            this.fatGramsDataGridViewTextBoxColumn.Name = "fatGramsDataGridViewTextBoxColumn";
            this.fatGramsDataGridViewTextBoxColumn.Width = 150;
            // 
            // carbGramsDataGridViewTextBoxColumn
            // 
            this.carbGramsDataGridViewTextBoxColumn.DataPropertyName = "CarbGrams";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.carbGramsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.carbGramsDataGridViewTextBoxColumn.HeaderText = "Carbs";
            this.carbGramsDataGridViewTextBoxColumn.Name = "carbGramsDataGridViewTextBoxColumn";
            this.carbGramsDataGridViewTextBoxColumn.Width = 150;
            // 
            // proteinGramsDataGridViewTextBoxColumn
            // 
            this.proteinGramsDataGridViewTextBoxColumn.DataPropertyName = "ProteinGrams";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.proteinGramsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.proteinGramsDataGridViewTextBoxColumn.HeaderText = "Protein";
            this.proteinGramsDataGridViewTextBoxColumn.Name = "proteinGramsDataGridViewTextBoxColumn";
            this.proteinGramsDataGridViewTextBoxColumn.Width = 150;
            // 
            // caloriesDataGridViewTextBoxColumn
            // 
            this.caloriesDataGridViewTextBoxColumn.DataPropertyName = "Calories";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.caloriesDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.caloriesDataGridViewTextBoxColumn.HeaderText = "Calories";
            this.caloriesDataGridViewTextBoxColumn.Name = "caloriesDataGridViewTextBoxColumn";
            this.caloriesDataGridViewTextBoxColumn.ReadOnly = true;
            this.caloriesDataGridViewTextBoxColumn.Width = 150;
            // 
            // foodManagerBindingSource
            // 
            this.foodManagerBindingSource.DataMember = "FoodList";
            this.foodManagerBindingSource.DataSource = typeof(Module9.FoodManager);
            // 
            // Module9Ex2Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 463);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.foodManagerDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Module9Ex2Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Module 9 - Example 2 (Main Form)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Module9Ex2_FormClosing);
            this.Load += new System.EventHandler(this.Module9Ex2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodManagerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodManagerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource foodManagerBindingSource;
        private System.Windows.Forms.DataGridView foodManagerDataGridView;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatGramsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carbGramsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteinGramsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloriesDataGridViewTextBoxColumn;
    }
}