namespace Academy.Forms
{
    partial class Teachers
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
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherSpeciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TNameTxt = new System.Windows.Forms.TextBox();
            this.TSurnameTxt = new System.Windows.Forms.TextBox();
            this.TEmailTxt = new System.Windows.Forms.TextBox();
            this.TPhoneTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TSpecialityCmb = new System.Windows.Forms.ComboBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.AllowUserToAddRows = false;
            this.dgvTeachers.AllowUserToDeleteRows = false;
            this.dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherId,
            this.TeacherName,
            this.TeacherSurname,
            this.TeacherSpeciality,
            this.TeacherEmail,
            this.TeacherPhone,
            this.TeacherGroup});
            this.dgvTeachers.Location = new System.Drawing.Point(269, 165);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.ReadOnly = true;
            this.dgvTeachers.Size = new System.Drawing.Size(504, 244);
            this.dgvTeachers.TabIndex = 0;
            this.dgvTeachers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTeachers_RowHeaderMouseDoubleClick);
            // 
            // TeacherId
            // 
            this.TeacherId.HeaderText = "TeacherId";
            this.TeacherId.Name = "TeacherId";
            this.TeacherId.ReadOnly = true;
            this.TeacherId.Visible = false;
            // 
            // TeacherName
            // 
            this.TeacherName.HeaderText = "Name";
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            // 
            // TeacherSurname
            // 
            this.TeacherSurname.HeaderText = "Surname";
            this.TeacherSurname.Name = "TeacherSurname";
            this.TeacherSurname.ReadOnly = true;
            // 
            // TeacherSpeciality
            // 
            this.TeacherSpeciality.HeaderText = "Speciality";
            this.TeacherSpeciality.Name = "TeacherSpeciality";
            this.TeacherSpeciality.ReadOnly = true;
            // 
            // TeacherEmail
            // 
            this.TeacherEmail.HeaderText = "Email";
            this.TeacherEmail.Name = "TeacherEmail";
            this.TeacherEmail.ReadOnly = true;
            // 
            // TeacherPhone
            // 
            this.TeacherPhone.HeaderText = "Phone";
            this.TeacherPhone.Name = "TeacherPhone";
            this.TeacherPhone.ReadOnly = true;
            // 
            // TeacherGroup
            // 
            this.TeacherGroup.HeaderText = "Group";
            this.TeacherGroup.Name = "TeacherGroup";
            this.TeacherGroup.ReadOnly = true;
            // 
            // TNameTxt
            // 
            this.TNameTxt.Location = new System.Drawing.Point(125, 76);
            this.TNameTxt.Name = "TNameTxt";
            this.TNameTxt.Size = new System.Drawing.Size(111, 20);
            this.TNameTxt.TabIndex = 0;
            this.TNameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.TNameTxt_Validating);
            // 
            // TSurnameTxt
            // 
            this.TSurnameTxt.Location = new System.Drawing.Point(125, 121);
            this.TSurnameTxt.Name = "TSurnameTxt";
            this.TSurnameTxt.Size = new System.Drawing.Size(111, 20);
            this.TSurnameTxt.TabIndex = 1;
            this.TSurnameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.TSurnameTxt_Validating);
            // 
            // TEmailTxt
            // 
            this.TEmailTxt.Location = new System.Drawing.Point(125, 206);
            this.TEmailTxt.Name = "TEmailTxt";
            this.TEmailTxt.Size = new System.Drawing.Size(111, 20);
            this.TEmailTxt.TabIndex = 3;
            this.TEmailTxt.Validating += new System.ComponentModel.CancelEventHandler(this.TEmailTxt_Validating);
            // 
            // TPhoneTxt
            // 
            this.TPhoneTxt.Location = new System.Drawing.Point(125, 247);
            this.TPhoneTxt.Name = "TPhoneTxt";
            this.TPhoneTxt.Size = new System.Drawing.Size(111, 20);
            this.TPhoneTxt.TabIndex = 4;
            this.TPhoneTxt.Validating += new System.ComponentModel.CancelEventHandler(this.TPhoneTxt_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speciality";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Phone";
            // 
            // TSpecialityCmb
            // 
            this.TSpecialityCmb.AllowDrop = true;
            this.TSpecialityCmb.Location = new System.Drawing.Point(125, 165);
            this.TSpecialityCmb.MaxDropDownItems = 100;
            this.TSpecialityCmb.Name = "TSpecialityCmb";
            this.TSpecialityCmb.Size = new System.Drawing.Size(111, 21);
            this.TSpecialityCmb.TabIndex = 2;
            this.TSpecialityCmb.Validating += new System.ComponentModel.CancelEventHandler(this.TSpecialityCmb_Validating);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(17, 313);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 39);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(17, 368);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 41);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(161, 368);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 41);
            this.ResetBtn.TabIndex = 8;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(110, 356);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(269, 21);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(130, 20);
            this.SearchTxt.TabIndex = 10;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(405, 21);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 20);
            this.SearchBtn.TabIndex = 11;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(11, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Teacher";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(161, 313);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 39);
            this.UpdateBtn.TabIndex = 13;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(785, 463);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.TSpecialityCmb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TPhoneTxt);
            this.Controls.Add(this.TEmailTxt);
            this.Controls.Add(this.TSurnameTxt);
            this.Controls.Add(this.TNameTxt);
            this.Controls.Add(this.dgvTeachers);
            this.Name = "Teachers";
            this.Text = "Teachers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.TextBox TNameTxt;
        private System.Windows.Forms.TextBox TSurnameTxt;
        private System.Windows.Forms.TextBox TEmailTxt;
        private System.Windows.Forms.TextBox TPhoneTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherSpeciality;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherGroup;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.ComboBox TSpecialityCmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button UpdateBtn;
    }
}