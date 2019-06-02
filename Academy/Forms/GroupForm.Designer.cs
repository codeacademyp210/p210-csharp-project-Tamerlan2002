namespace Academy.Forms
{
    partial class GroupForm
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.GrNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GrCapacTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GrClassCmb = new System.Windows.Forms.ComboBox();
            this.GrTeacherCmb = new System.Windows.Forms.ComboBox();
            this.GrMentorCmb = new System.Windows.Forms.ComboBox();
            this.GrEducCmb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.GrSearchBtn = new System.Windows.Forms.Button();
            this.GroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupClassroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupMentor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupProgram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(126, 414);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 13);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(196, 374);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(70, 32);
            this.UpdateBtn.TabIndex = 24;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(196, 432);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(70, 32);
            this.Reset.TabIndex = 25;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(25, 432);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(70, 32);
            this.DeleteBtn.TabIndex = 26;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(25, 374);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(70, 32);
            this.SaveBtn.TabIndex = 27;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // dgvGroups
            // 
            this.dgvGroups.AllowUserToAddRows = false;
            this.dgvGroups.AllowUserToDeleteRows = false;
            this.dgvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupId,
            this.GroupName,
            this.GroupClassroom,
            this.GroupTeacher,
            this.GroupMentor,
            this.GroupCapacity,
            this.GroupProgram});
            this.dgvGroups.Location = new System.Drawing.Point(299, 119);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.ReadOnly = true;
            this.dgvGroups.Size = new System.Drawing.Size(474, 348);
            this.dgvGroups.TabIndex = 29;
            // 
            // GrNameTxt
            // 
            this.GrNameTxt.Location = new System.Drawing.Point(129, 128);
            this.GrNameTxt.Name = "GrNameTxt";
            this.GrNameTxt.Size = new System.Drawing.Size(137, 20);
            this.GrNameTxt.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Group Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Classroom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Teacher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Mentor";
            // 
            // GrCapacTxt
            // 
            this.GrCapacTxt.Location = new System.Drawing.Point(129, 277);
            this.GrCapacTxt.Name = "GrCapacTxt";
            this.GrCapacTxt.Size = new System.Drawing.Size(137, 20);
            this.GrCapacTxt.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Capacity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Education Program";
            // 
            // GrClassCmb
            // 
            this.GrClassCmb.FormattingEnabled = true;
            this.GrClassCmb.Items.AddRange(new object[] {
            "sasd"});
            this.GrClassCmb.Location = new System.Drawing.Point(129, 164);
            this.GrClassCmb.Name = "GrClassCmb";
            this.GrClassCmb.Size = new System.Drawing.Size(137, 21);
            this.GrClassCmb.TabIndex = 32;
            // 
            // GrTeacherCmb
            // 
            this.GrTeacherCmb.FormattingEnabled = true;
            this.GrTeacherCmb.Items.AddRange(new object[] {
            "asdf"});
            this.GrTeacherCmb.Location = new System.Drawing.Point(129, 200);
            this.GrTeacherCmb.Name = "GrTeacherCmb";
            this.GrTeacherCmb.Size = new System.Drawing.Size(137, 21);
            this.GrTeacherCmb.TabIndex = 32;
            // 
            // GrMentorCmb
            // 
            this.GrMentorCmb.FormattingEnabled = true;
            this.GrMentorCmb.Items.AddRange(new object[] {
            "asdfas"});
            this.GrMentorCmb.Location = new System.Drawing.Point(129, 237);
            this.GrMentorCmb.Name = "GrMentorCmb";
            this.GrMentorCmb.Size = new System.Drawing.Size(137, 21);
            this.GrMentorCmb.TabIndex = 32;
            // 
            // GrEducCmb
            // 
            this.GrEducCmb.FormattingEnabled = true;
            this.GrEducCmb.Items.AddRange(new object[] {
            "asdfasd"});
            this.GrEducCmb.Location = new System.Drawing.Point(129, 317);
            this.GrEducCmb.Name = "GrEducCmb";
            this.GrEducCmb.Size = new System.Drawing.Size(137, 21);
            this.GrEducCmb.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 31);
            this.label7.TabIndex = 33;
            this.label7.Text = "Groups";
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(299, 21);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(189, 20);
            this.SearchTxt.TabIndex = 34;
            // 
            // GrSearchBtn
            // 
            this.GrSearchBtn.Location = new System.Drawing.Point(494, 21);
            this.GrSearchBtn.Name = "GrSearchBtn";
            this.GrSearchBtn.Size = new System.Drawing.Size(75, 20);
            this.GrSearchBtn.TabIndex = 35;
            this.GrSearchBtn.Text = "Search";
            this.GrSearchBtn.UseVisualStyleBackColor = true;
            // 
            // GroupId
            // 
            this.GroupId.HeaderText = "Id";
            this.GroupId.Name = "GroupId";
            this.GroupId.ReadOnly = true;
            this.GroupId.Visible = false;
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "Name";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            this.GroupName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GroupClassroom
            // 
            this.GroupClassroom.HeaderText = "Classroom";
            this.GroupClassroom.Name = "GroupClassroom";
            this.GroupClassroom.ReadOnly = true;
            this.GroupClassroom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GroupClassroom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GroupTeacher
            // 
            this.GroupTeacher.HeaderText = "Teacher";
            this.GroupTeacher.Name = "GroupTeacher";
            this.GroupTeacher.ReadOnly = true;
            // 
            // GroupMentor
            // 
            this.GroupMentor.HeaderText = "Mentor";
            this.GroupMentor.Name = "GroupMentor";
            this.GroupMentor.ReadOnly = true;
            // 
            // GroupCapacity
            // 
            this.GroupCapacity.HeaderText = "Capacity";
            this.GroupCapacity.Name = "GroupCapacity";
            this.GroupCapacity.ReadOnly = true;
            // 
            // GroupProgram
            // 
            this.GroupProgram.HeaderText = "Education Program";
            this.GroupProgram.Name = "GroupProgram";
            this.GroupProgram.ReadOnly = true;
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 496);
            this.Controls.Add(this.GrSearchBtn);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GrEducCmb);
            this.Controls.Add(this.GrMentorCmb);
            this.Controls.Add(this.GrTeacherCmb);
            this.Controls.Add(this.GrClassCmb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrCapacTxt);
            this.Controls.Add(this.GrNameTxt);
            this.Controls.Add(this.dgvGroups);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Name = "GroupForm";
            this.Text = "GroupForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.TextBox GrNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GrCapacTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox GrClassCmb;
        private System.Windows.Forms.ComboBox GrTeacherCmb;
        private System.Windows.Forms.ComboBox GrMentorCmb;
        private System.Windows.Forms.ComboBox GrEducCmb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Button GrSearchBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupClassroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupMentor;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupProgram;
    }
}