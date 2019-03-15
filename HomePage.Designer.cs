//@@ -0,0 +1,306 @@
﻿using System;

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
            this.Rubric = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUpdateStd = new System.Windows.Forms.Button();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.searchDropdown = new System.Windows.Forms.ComboBox();
            this.seatchbtn = new System.Windows.Forms.Button();
            this.searchT = new System.Windows.Forms.TextBox();
            this.deleteAllbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contactT = new System.Windows.Forms.TextBox();
            this.emailT = new System.Windows.Forms.TextBox();
            this.statusT = new System.Windows.Forms.TextBox();
            this.regT = new System.Windows.Forms.TextBox();
            this.lastT = new System.Windows.Forms.TextBox();
            this.firstT = new System.Windows.Forms.TextBox();
            this.addStudent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deleteCLObtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.cloRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CloSearchText = new System.Windows.Forms.TextBox();
            this.cloCreatebtn = new System.Windows.Forms.Button();
            this.cloSearchbtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CLOidLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cloSearchRubricbtn = new System.Windows.Forms.Button();
            this.deleteRubricbtn = new System.Windows.Forms.Button();
            this.updateRubricbtn = new System.Windows.Forms.Button();
            this.addRubricbtn = new System.Windows.Forms.Button();
            this.rubricText = new System.Windows.Forms.TextBox();
            this.searchCLoRubric = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Rubric.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            // Rubric
            // 
            this.Rubric.Controls.Add(this.tabPage1);
            this.Rubric.Controls.Add(this.tabPage2);
            this.Rubric.Controls.Add(this.tabPage3);
            this.Rubric.Location = new System.Drawing.Point(12, 74);
            this.Rubric.Name = "Rubric";
            this.Rubric.RightToLeftLayout = true;
            this.Rubric.SelectedIndex = 0;
            this.Rubric.Size = new System.Drawing.Size(867, 330);
            this.Rubric.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.btnUpdateStd);
            this.tabPage1.Controls.Add(this.Refreshbtn);
            this.tabPage1.Controls.Add(this.searchDropdown);
            this.tabPage1.Controls.Add(this.seatchbtn);
            this.tabPage1.Controls.Add(this.searchT);
            this.tabPage1.Controls.Add(this.deleteAllbtn);
            this.tabPage1.Controls.Add(this.deletebtn);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.contactT);
            this.tabPage1.Controls.Add(this.emailT);
            this.tabPage1.Controls.Add(this.statusT);
            this.tabPage1.Controls.Add(this.regT);
            this.tabPage1.Controls.Add(this.lastT);
            this.tabPage1.Controls.Add(this.firstT);
            this.tabPage1.Controls.Add(this.addStudent);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(859, 304);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "STUDENTS";
            // 
            // btnUpdateStd
            // 
            this.btnUpdateStd.Location = new System.Drawing.Point(759, 272);
            this.btnUpdateStd.Name = "btnUpdateStd";
            this.btnUpdateStd.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateStd.TabIndex = 12;
            this.btnUpdateStd.Text = "Update";
            this.btnUpdateStd.UseVisualStyleBackColor = true;
            this.btnUpdateStd.Click += new System.EventHandler(this.btnUpdateStd_Click);
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Location = new System.Drawing.Point(569, 6);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(284, 28);
            this.Refreshbtn.TabIndex = 11;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = true;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // searchDropdown
            // 
            this.searchDropdown.FormattingEnabled = true;
            this.searchDropdown.Items.AddRange(new object[] {
            "Registeration number",
            "First name",
            "Last name",
            "E-mail",
            "Contact",
            "Status"});
            this.searchDropdown.Location = new System.Drawing.Point(569, 40);
            this.searchDropdown.Name = "searchDropdown";
            this.searchDropdown.Size = new System.Drawing.Size(40, 21);
            this.searchDropdown.TabIndex = 10;
            // 
            // seatchbtn
            // 
            this.seatchbtn.Location = new System.Drawing.Point(775, 39);
            this.seatchbtn.Name = "seatchbtn";
            this.seatchbtn.Size = new System.Drawing.Size(75, 23);
            this.seatchbtn.TabIndex = 8;
            this.seatchbtn.Text = "search";
            this.seatchbtn.UseVisualStyleBackColor = true;
            this.seatchbtn.Click += new System.EventHandler(this.seatchbtn_Click);
            // 
            // searchT
            // 
            this.searchT.Location = new System.Drawing.Point(614, 41);
            this.searchT.Name = "searchT";
            this.searchT.Size = new System.Drawing.Size(155, 20);
            this.searchT.TabIndex = 7;
            // 
            // deleteAllbtn
            // 
            this.deleteAllbtn.Location = new System.Drawing.Point(678, 272);
            this.deleteAllbtn.Name = "deleteAllbtn";
            this.deleteAllbtn.Size = new System.Drawing.Size(75, 23);
            this.deleteAllbtn.TabIndex = 5;
            this.deleteAllbtn.Text = "Delter all";
            this.deleteAllbtn.UseVisualStyleBackColor = true;
            this.deleteAllbtn.Click += new System.EventHandler(this.deleteAllbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(597, 272);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 4;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "E-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(594, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(595, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Registeration No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            // 
            // contactT
            // 
            this.contactT.Location = new System.Drawing.Point(689, 127);
            this.contactT.Name = "contactT";
            this.contactT.Size = new System.Drawing.Size(100, 20);
            this.contactT.TabIndex = 2;
            // 
            // emailT
            // 
            this.emailT.Location = new System.Drawing.Point(689, 153);
            this.emailT.Name = "emailT";
            this.emailT.Size = new System.Drawing.Size(100, 20);
            this.emailT.TabIndex = 2;
            // 
            // statusT
            // 
            this.statusT.Location = new System.Drawing.Point(689, 214);
            this.statusT.Name = "statusT";
            this.statusT.Size = new System.Drawing.Size(100, 20);
            this.statusT.TabIndex = 2;
            // 
            // regT
            // 
            this.regT.Location = new System.Drawing.Point(689, 186);
            this.regT.Name = "regT";
            this.regT.Size = new System.Drawing.Size(100, 20);
            this.regT.TabIndex = 2;
            // 
            // lastT
            // 
            this.lastT.Location = new System.Drawing.Point(689, 99);
            this.lastT.Name = "lastT";
            this.lastT.Size = new System.Drawing.Size(100, 20);
            this.lastT.TabIndex = 2;
            // 
            // firstT
            // 
            this.firstT.Location = new System.Drawing.Point(689, 73);
            this.firstT.Name = "firstT";
            this.firstT.Size = new System.Drawing.Size(100, 20);
            this.firstT.TabIndex = 2;
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(598, 243);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(191, 24);
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
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.deleteCLObtn);
            this.tabPage2.Controls.Add(this.updatebtn);
            this.tabPage2.Controls.Add(this.cloRefresh);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.CloSearchText);
            this.tabPage2.Controls.Add(this.cloCreatebtn);
            this.tabPage2.Controls.Add(this.cloSearchbtn);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(859, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CLO";
            // 
            // deleteCLObtn
            // 
            this.deleteCLObtn.Location = new System.Drawing.Point(528, 96);
            this.deleteCLObtn.Name = "deleteCLObtn";
            this.deleteCLObtn.Size = new System.Drawing.Size(75, 23);
            this.deleteCLObtn.TabIndex = 8;
            this.deleteCLObtn.Text = "delete";
            this.deleteCLObtn.UseVisualStyleBackColor = true;
            this.deleteCLObtn.Click += new System.EventHandler(this.deleteCLObtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(690, 96);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 5;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // cloRefresh
            // 
            this.cloRefresh.Location = new System.Drawing.Point(549, 16);
            this.cloRefresh.Name = "cloRefresh";
            this.cloRefresh.Size = new System.Drawing.Size(270, 27);
            this.cloRefresh.TabIndex = 4;
            this.cloRefresh.Text = "Refresh";
            this.cloRefresh.UseVisualStyleBackColor = true;
            this.cloRefresh.Click += new System.EventHandler(this.cloRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CLO Name";
            // 
            // CloSearchText
            // 
            this.CloSearchText.Location = new System.Drawing.Point(628, 58);
            this.CloSearchText.Name = "CloSearchText";
            this.CloSearchText.Size = new System.Drawing.Size(191, 20);
            this.CloSearchText.TabIndex = 2;
            // 
            // cloCreatebtn
            // 
            this.cloCreatebtn.Location = new System.Drawing.Point(609, 96);
            this.cloCreatebtn.Name = "cloCreatebtn";
            this.cloCreatebtn.Size = new System.Drawing.Size(75, 23);
            this.cloCreatebtn.TabIndex = 1;
            this.cloCreatebtn.Text = "Create";
            this.cloCreatebtn.UseVisualStyleBackColor = true;
            this.cloCreatebtn.Click += new System.EventHandler(this.cloCreatebtn_Click);
            // 
            // cloSearchbtn
            // 
            this.cloSearchbtn.Location = new System.Drawing.Point(771, 96);
            this.cloSearchbtn.Name = "cloSearchbtn";
            this.cloSearchbtn.Size = new System.Drawing.Size(75, 23);
            this.cloSearchbtn.TabIndex = 1;
            this.cloSearchbtn.Text = "Search";
            this.cloSearchbtn.UseVisualStyleBackColor = true;
            this.cloSearchbtn.Click += new System.EventHandler(this.cloSearchbtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(506, 292);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.CLOidLabel);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.cloSearchRubricbtn);
            this.tabPage3.Controls.Add(this.deleteRubricbtn);
            this.tabPage3.Controls.Add(this.updateRubricbtn);
            this.tabPage3.Controls.Add(this.addRubricbtn);
            this.tabPage3.Controls.Add(this.rubricText);
            this.tabPage3.Controls.Add(this.searchCLoRubric);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(859, 304);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rubric";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(557, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Search clo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(559, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Rubric";
            // 
            // CLOidLabel
            // 
            this.CLOidLabel.AutoSize = true;
            this.CLOidLabel.Location = new System.Drawing.Point(629, 57);
            this.CLOidLabel.Name = "CLOidLabel";
            this.CLOidLabel.Size = new System.Drawing.Size(13, 13);
            this.CLOidLabel.TabIndex = 7;
            this.CLOidLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(560, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "CLO id";
            // 
            // cloSearchRubricbtn
            // 
            this.cloSearchRubricbtn.Location = new System.Drawing.Point(800, 23);
            this.cloSearchRubricbtn.Name = "cloSearchRubricbtn";
            this.cloSearchRubricbtn.Size = new System.Drawing.Size(50, 23);
            this.cloSearchRubricbtn.TabIndex = 5;
            this.cloSearchRubricbtn.Text = "Search";
            this.cloSearchRubricbtn.UseVisualStyleBackColor = true;
            this.cloSearchRubricbtn.Click += new System.EventHandler(this.cloSearchRubricbtn_Click);
            // 
            // deleteRubricbtn
            // 
            this.deleteRubricbtn.Location = new System.Drawing.Point(630, 121);
            this.deleteRubricbtn.Name = "deleteRubricbtn";
            this.deleteRubricbtn.Size = new System.Drawing.Size(58, 23);
            this.deleteRubricbtn.TabIndex = 4;
            this.deleteRubricbtn.Text = "Delete";
            this.deleteRubricbtn.UseVisualStyleBackColor = true;
            // 
            // updateRubricbtn
            // 
            this.updateRubricbtn.Location = new System.Drawing.Point(705, 121);
            this.updateRubricbtn.Name = "updateRubricbtn";
            this.updateRubricbtn.Size = new System.Drawing.Size(64, 23);
            this.updateRubricbtn.TabIndex = 4;
            this.updateRubricbtn.Text = "Update";
            this.updateRubricbtn.UseVisualStyleBackColor = true;
            // 
            // addRubricbtn
            // 
            this.addRubricbtn.Location = new System.Drawing.Point(787, 121);
            this.addRubricbtn.Name = "addRubricbtn";
            this.addRubricbtn.Size = new System.Drawing.Size(63, 23);
            this.addRubricbtn.TabIndex = 3;
            this.addRubricbtn.Text = "Add";
            this.addRubricbtn.UseVisualStyleBackColor = true;
            // 
            // rubricText
            // 
            this.rubricText.Location = new System.Drawing.Point(630, 83);
            this.rubricText.Name = "rubricText";
            this.rubricText.Size = new System.Drawing.Size(220, 20);
            this.rubricText.TabIndex = 2;
            // 
            // searchCLoRubric
            // 
            this.searchCLoRubric.Location = new System.Drawing.Point(630, 25);
            this.searchCLoRubric.Name = "searchCLoRubric";
            this.searchCLoRubric.Size = new System.Drawing.Size(164, 20);
            this.searchCLoRubric.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(545, 292);
            this.dataGridView3.TabIndex = 0;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 416);
            this.Controls.Add(this.Rubric);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.Rubric.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Rubric;
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
        private System.Windows.Forms.TextBox regT;
        private System.Windows.Forms.TextBox lastT;
        private System.Windows.Forms.TextBox firstT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox statusT;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button deleteAllbtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button seatchbtn;
        private System.Windows.Forms.TextBox searchT;
        private System.Windows.Forms.ComboBox searchDropdown;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CloSearchText;
        private System.Windows.Forms.Button cloCreatebtn;
        private System.Windows.Forms.Button cloSearchbtn;
        private System.Windows.Forms.Button cloRefresh;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deleteCLObtn;
        private System.Windows.Forms.Button btnUpdateStd;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label CLOidLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cloSearchRubricbtn;
        private System.Windows.Forms.Button deleteRubricbtn;
        private System.Windows.Forms.Button updateRubricbtn;
        private System.Windows.Forms.Button addRubricbtn;
        private System.Windows.Forms.TextBox rubricText;
        private System.Windows.Forms.TextBox searchCLoRubric;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}
