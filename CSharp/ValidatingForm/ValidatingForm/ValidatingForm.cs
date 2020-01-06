
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ValidatingForm
{
        public class Form1 : System.Windows.Forms.Form
        {
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.TextBox textBox1;
            private System.Windows.Forms.TextBox textBox2;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.DateTimePicker dateTimePicker1;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.ErrorProvider errorProvider1;
            public Form1()
            {
                this.label1 = new System.Windows.Forms.Label();
                this.textBox1 = new System.Windows.Forms.TextBox();
                this.textBox2 = new System.Windows.Forms.TextBox();
                this.label2 = new System.Windows.Forms.Label();
                this.label3 = new System.Windows.Forms.Label();
                this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
                this.label4 = new System.Windows.Forms.Label();
                this.button1 = new System.Windows.Forms.Button();
                this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
                this.SuspendLayout();
                this.label1.Location = new System.Drawing.Point(8, 40);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(80, 16);
                this.label1.TabIndex = 0;
                this.label1.Text = "Name";
                this.label1.Click += new System.EventHandler(this.label1_Click);
                this.textBox1.Location = new System.Drawing.Point(96, 40);
                this.textBox1.Name = "textBox1";
                this.textBox1.Size = new System.Drawing.Size(104, 20);
                this.textBox1.TabIndex = 1;
                this.textBox1.Text = "";
                this.textBox1.Validating += new System.ComponentModel.CancelEventHandler (this.textBox1_Validating);
                this.label2.Location = new System.Drawing.Point(8, 64);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(80, 16);
                this.label2.TabIndex = 3;
                this.label2.Text = "Age";
                this.textBox2.Location = new System.Drawing.Point(96, 64);
                this.textBox2.Name = "textBox2";
                this.textBox2.Size = new System.Drawing.Size(104, 20);
                this.textBox2.TabIndex = 4;
                this.textBox2.Text = "";
                this.textBox2.Validating += new System.ComponentModel.CancelEventHandler (this.textBox2_Validating);
                this.label3.Location = new System.Drawing.Point(8, 88);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(80, 16);
                this.label3.TabIndex = 5;
                this.label3.Text = "Test Date";
                this.dateTimePicker1.Location = new System.Drawing.Point(96, 88);
                this.dateTimePicker1.Name = "dateTimePicker1";
                this.dateTimePicker1.TabIndex = 6;
                this.dateTimePicker1.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker1_Validating);
                this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                this.label4.Location = new System.Drawing.Point(16, 8);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(184, 23);
                this.label4.TabIndex = 7;
                this.label4.Text = "Setup Driving Test Appointment";
                this.button1.Location = new System.Drawing.Point(80, 128);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(120, 23);
                this.button1.TabIndex = 8;
                this.button1.Text = "Create Appointment";
                this.button1.Click += new System.EventHandler(this.button1_Click);
                this.errorProvider1.DataMember = null;
                this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
                this.ClientSize = new System.Drawing.Size(320, 173);
                this.Controls.AddRange(new System.Windows.Forms.Control[] { this.button1, this.label4, this.dateTimePicker1, this.label3, this.label2, this.textBox2, this.textBox1, this.label1 });
                this.Name = "Form1";
                this.Text = "Form1";
                this.Load += new System.EventHandler(this.Form1_Load);
                this.ResumeLayout(false);
            }
            [STAThread]
            static void Main()
            {
                Application.Run(new Form1());
            }
            private void label1_Click(object sender, System.EventArgs e)
            {
            }
            private void Form1_Load(object sender, System.EventArgs e)
            {
                errorProvider1.ContainerControl = this;
            }
            private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
            {
                ValidateName();
            }
            private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
            {
                ValidateAge();
            }
            private void dateTimePicker1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
            {
                ValidateTestDate();
            }
            private void button1_Click(object sender, System.EventArgs e)
            {
                ValidateForm();
            }
            private void ValidateForm()
            {
                bool bValidName = ValidateName();
                bool bValidAge = ValidateAge();
                bool bValidTestDate = ValidateTestDate();
                if (bValidName && bValidAge && bValidTestDate)
                    MessageBox.Show("Appointment will be created now");
                else
                    MessageBox.Show("Please enter valid data");
            }
            private bool ValidateName()
            {
                bool bStatus = true;
                if (textBox1.Text == "")
                {
                    errorProvider1.SetError(textBox1, "Please enter your Name");
                    bStatus = false;
                }
                else
                    errorProvider1.SetError(textBox1, "");
                return bStatus;
            }
            private bool ValidateAge()
            {
                bool bStatus = true;
                if (textBox2.Text == "")
                {
                    errorProvider1.SetError(textBox2, "Please enter your Age");
                    bStatus = false;
                }
                else
                {
                    errorProvider1.SetError(textBox2, "");
                    try
                    {
                        int temp = int.Parse(textBox2.Text);
                        errorProvider1.SetError(textBox2, "");
                        if (temp < 18)
                        {
                            errorProvider1.SetError(textBox2, "You must be atleast 18 years old to setup a test");
                            bStatus = false;
                        }
                        else
                        {
                            errorProvider1.SetError(textBox2, "");
                        }
                    }
                    catch
                    {
                        errorProvider1.SetError(textBox2, "Please enter your age as a number");
                        bStatus = false;
                    }
                }
                return bStatus;
            }
            private bool ValidateTestDate()
            {
                bool bStatus = true;
                if ((dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday) ||
                (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Saturday))
                {
                    errorProvider1.SetError(dateTimePicker1, "Appointment cannot be scheduled in the weekend. Please select a weekday");
                    bStatus = false;
                }
                else
                    errorProvider1.SetError(dateTimePicker1, "");
                return bStatus;
            }
        }
}
