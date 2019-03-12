using System;

namespace HireACarUI
{
    partial class HomePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contactT = new System.Windows.Forms.TextBox();
            this.emailT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusT = new System.Windows.Forms.TextBox();
            this.regT = new System.Windows.Forms.TextBox();
            this.lastT = new System.Windows.Forms.TextBox();
            this.firstT = new System.Windows.Forms.TextBox();
            this.idT = new System.Windows.Forms.TextBox();
            this.addStudent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deletebtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "f";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student management system";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 327);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.deletebtn);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.contactT);
            this.tabPage1.Controls.Add(this.emailT);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.statusT);
            this.tabPage1.Controls.Add(this.regT);
            this.tabPage1.Controls.Add(this.lastT);
            this.tabPage1.Controls.Add(this.firstT);
            this.tabPage1.Controls.Add(this.idT);
            this.tabPage1.Controls.Add(this.addStudent);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(825, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "STUDENTS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "E-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(594, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(595, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Registeration No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            // 
            // contactT
            // 
            this.contactT.Location = new System.Drawing.Point(689, 108);
            this.contactT.Name = "contactT";
            this.contactT.Size = new System.Drawing.Size(100, 20);
            this.contactT.TabIndex = 2;
            // 
            // emailT
            // 
            this.emailT.Location = new System.Drawing.Point(689, 134);
            this.emailT.Name = "emailT";
            this.emailT.Size = new System.Drawing.Size(100, 20);
            this.emailT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student ID";
            // 
            // statusT
            // 
            this.statusT.Location = new System.Drawing.Point(689, 195);
            this.statusT.Name = "statusT";
            this.statusT.Size = new System.Drawing.Size(100, 20);
            this.statusT.TabIndex = 2;
            // 
            // regT
            // 
            this.regT.Location = new System.Drawing.Point(689, 167);
            this.regT.Name = "regT";
            this.regT.Size = new System.Drawing.Size(100, 20);
            this.regT.TabIndex = 2;
            // 
            // lastT
            // 
            this.lastT.Location = new System.Drawing.Point(689, 80);
            this.lastT.Name = "lastT";
            this.lastT.Size = new System.Drawing.Size(100, 20);
            this.lastT.TabIndex = 2;
            // 
            // firstT
            // 
            this.firstT.Location = new System.Drawing.Point(689, 54);
            this.firstT.Name = "firstT";
            this.firstT.Size = new System.Drawing.Size(100, 20);
            this.firstT.TabIndex = 2;
            // 
            // idT
            // 
            this.idT.Location = new System.Drawing.Point(689, 28);
            this.idT.Name = "idT";
            this.idT.Size = new System.Drawing.Size(100, 20);
            this.idT.TabIndex = 2;
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(689, 231);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(100, 24);
            this.addStudent.TabIndex = 1;
            this.addStudent.Text = "Add Student";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(825, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CLO";
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(597, 232);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 4;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 416);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contactT;
        private System.Windows.Forms.TextBox emailT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox regT;
        private System.Windows.Forms.TextBox lastT;
        private System.Windows.Forms.TextBox firstT;
        private System.Windows.Forms.TextBox idT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox statusT;
        private System.Windows.Forms.Button deletebtn;
    }
}

