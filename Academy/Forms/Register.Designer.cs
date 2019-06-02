namespace Academy.Forms
{
    partial class Register
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailTxtReg = new System.Windows.Forms.TextBox();
            this.PassReg = new System.Windows.Forms.TextBox();
            this.Pass2Reg = new System.Windows.Forms.TextBox();
            this.StudentRbtn = new System.Windows.Forms.RadioButton();
            this.TeacherRbtn = new System.Windows.Forms.RadioButton();
            this.CoordinatorRbtn = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.RegBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Re-enter your password";
            // 
            // EmailTxtReg
            // 
            this.EmailTxtReg.Location = new System.Drawing.Point(161, 107);
            this.EmailTxtReg.Name = "EmailTxtReg";
            this.EmailTxtReg.Size = new System.Drawing.Size(164, 20);
            this.EmailTxtReg.TabIndex = 0;
            this.EmailTxtReg.Validating += new System.ComponentModel.CancelEventHandler(this.EmailTxtReg_Validating);
            // 
            // PassReg
            // 
            this.PassReg.Location = new System.Drawing.Point(161, 158);
            this.PassReg.Name = "PassReg";
            this.PassReg.Size = new System.Drawing.Size(164, 20);
            this.PassReg.TabIndex = 1;
            this.PassReg.UseSystemPasswordChar = true;
            this.PassReg.Validating += new System.ComponentModel.CancelEventHandler(this.PassReg_Validating);
            // 
            // Pass2Reg
            // 
            this.Pass2Reg.Location = new System.Drawing.Point(161, 211);
            this.Pass2Reg.Name = "Pass2Reg";
            this.Pass2Reg.Size = new System.Drawing.Size(164, 20);
            this.Pass2Reg.TabIndex = 2;
            this.Pass2Reg.UseSystemPasswordChar = true;
            this.Pass2Reg.Validating += new System.ComponentModel.CancelEventHandler(this.Pass2Reg_Validating);
            // 
            // StudentRbtn
            // 
            this.StudentRbtn.AutoSize = true;
            this.StudentRbtn.Location = new System.Drawing.Point(161, 320);
            this.StudentRbtn.Name = "StudentRbtn";
            this.StudentRbtn.Size = new System.Drawing.Size(62, 17);
            this.StudentRbtn.TabIndex = 4;
            this.StudentRbtn.TabStop = true;
            this.StudentRbtn.Text = "Student";
            this.StudentRbtn.UseVisualStyleBackColor = true;
            // 
            // TeacherRbtn
            // 
            this.TeacherRbtn.AutoSize = true;
            this.TeacherRbtn.Location = new System.Drawing.Point(12, 320);
            this.TeacherRbtn.Name = "TeacherRbtn";
            this.TeacherRbtn.Size = new System.Drawing.Size(65, 17);
            this.TeacherRbtn.TabIndex = 3;
            this.TeacherRbtn.TabStop = true;
            this.TeacherRbtn.Text = "Teacher";
            this.TeacherRbtn.UseVisualStyleBackColor = true;
            // 
            // CoordinatorRbtn
            // 
            this.CoordinatorRbtn.AutoSize = true;
            this.CoordinatorRbtn.Location = new System.Drawing.Point(280, 320);
            this.CoordinatorRbtn.Name = "CoordinatorRbtn";
            this.CoordinatorRbtn.Size = new System.Drawing.Size(82, 17);
            this.CoordinatorRbtn.TabIndex = 5;
            this.CoordinatorRbtn.TabStop = true;
            this.CoordinatorRbtn.Text = "Co-ordinator";
            this.CoordinatorRbtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(147, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "You are :";
            // 
            // RegBtn
            // 
            this.RegBtn.Location = new System.Drawing.Point(152, 356);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(75, 32);
            this.RegBtn.TabIndex = 8;
            this.RegBtn.Text = "Register";
            this.RegBtn.UseVisualStyleBackColor = true;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(124, 406);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(132, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have an account?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(374, 439);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CoordinatorRbtn);
            this.Controls.Add(this.TeacherRbtn);
            this.Controls.Add(this.StudentRbtn);
            this.Controls.Add(this.Pass2Reg);
            this.Controls.Add(this.PassReg);
            this.Controls.Add(this.EmailTxtReg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmailTxtReg;
        private System.Windows.Forms.TextBox PassReg;
        private System.Windows.Forms.TextBox Pass2Reg;
        private System.Windows.Forms.RadioButton StudentRbtn;
        private System.Windows.Forms.RadioButton TeacherRbtn;
        private System.Windows.Forms.RadioButton CoordinatorRbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}