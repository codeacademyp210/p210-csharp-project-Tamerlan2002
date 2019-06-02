namespace Academy.Forms
{
    partial class ClassroomForm
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
            this.ClassroomTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClassroom = new System.Windows.Forms.DataGridView();
            this.ClassroomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassroomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassroomCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassCapTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassroom)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(120, 372);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(182, 333);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(70, 32);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(182, 391);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(70, 32);
            this.Reset.TabIndex = 10;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(19, 391);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(70, 32);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(19, 333);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(70, 32);
            this.SaveBtn.TabIndex = 12;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ClassroomTxt
            // 
            this.ClassroomTxt.Location = new System.Drawing.Point(123, 73);
            this.ClassroomTxt.Name = "ClassroomTxt";
            this.ClassroomTxt.Size = new System.Drawing.Size(129, 20);
            this.ClassroomTxt.TabIndex = 8;
            this.ClassroomTxt.Validating += new System.ComponentModel.CancelEventHandler(this.PositionTxt_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Add Classroom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Classroom";
            // 
            // dgvClassroom
            // 
            this.dgvClassroom.AllowUserToAddRows = false;
            this.dgvClassroom.AllowUserToDeleteRows = false;
            this.dgvClassroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassroom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassroomId,
            this.ClassroomName,
            this.ClassroomCapacity});
            this.dgvClassroom.Location = new System.Drawing.Point(303, 73);
            this.dgvClassroom.Name = "dgvClassroom";
            this.dgvClassroom.ReadOnly = true;
            this.dgvClassroom.Size = new System.Drawing.Size(476, 350);
            this.dgvClassroom.TabIndex = 14;
            this.dgvClassroom.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClassroom_RowHeaderMouseDoubleClick);
            // 
            // ClassroomId
            // 
            this.ClassroomId.HeaderText = "Id";
            this.ClassroomId.Name = "ClassroomId";
            this.ClassroomId.ReadOnly = true;
            this.ClassroomId.Visible = false;
            // 
            // ClassroomName
            // 
            this.ClassroomName.HeaderText = "Classroom";
            this.ClassroomName.Name = "ClassroomName";
            this.ClassroomName.ReadOnly = true;
            // 
            // ClassroomCapacity
            // 
            this.ClassroomCapacity.HeaderText = "Capacity";
            this.ClassroomCapacity.Name = "ClassroomCapacity";
            this.ClassroomCapacity.ReadOnly = true;
            // 
            // ClassCapTxt
            // 
            this.ClassCapTxt.Location = new System.Drawing.Point(123, 99);
            this.ClassCapTxt.Name = "ClassCapTxt";
            this.ClassCapTxt.Size = new System.Drawing.Size(129, 20);
            this.ClassCapTxt.TabIndex = 16;
            this.ClassCapTxt.Validating += new System.ComponentModel.CancelEventHandler(this.ClassCapTxt_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Add capacity";
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(303, 20);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(212, 20);
            this.SearchTxt.TabIndex = 17;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(532, 20);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 20);
            this.SearchBtn.TabIndex = 18;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // ClassroomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(791, 462);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.ClassCapTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvClassroom);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ClassroomTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClassroomForm";
            this.Text = "Classroom";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassroom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox ClassroomTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClassroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassroomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassroomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassroomCapacity;
        private System.Windows.Forms.TextBox ClassCapTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Button SearchBtn;
    }
}