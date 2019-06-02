namespace Academy.Forms
{
    partial class EducationProgramsForm
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
            this.EPNameTxt = new System.Windows.Forms.TextBox();
            this.EPPriceTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPrograms = new System.Windows.Forms.DataGridView();
            this.EPId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(124, 368);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 13);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(186, 329);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(70, 32);
            this.UpdateBtn.TabIndex = 14;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(186, 387);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(70, 32);
            this.Reset.TabIndex = 15;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(23, 387);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(70, 32);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(23, 329);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(70, 32);
            this.SaveBtn.TabIndex = 17;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // EPNameTxt
            // 
            this.EPNameTxt.Location = new System.Drawing.Point(147, 75);
            this.EPNameTxt.Name = "EPNameTxt";
            this.EPNameTxt.Size = new System.Drawing.Size(110, 20);
            this.EPNameTxt.TabIndex = 19;
            this.EPNameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.EPNameTxt_Validating);
            // 
            // EPPriceTxt
            // 
            this.EPPriceTxt.Location = new System.Drawing.Point(147, 113);
            this.EPPriceTxt.Name = "EPPriceTxt";
            this.EPPriceTxt.Size = new System.Drawing.Size(110, 20);
            this.EPPriceTxt.TabIndex = 19;
            this.EPPriceTxt.Validating += new System.ComponentModel.CancelEventHandler(this.EPPriceTxt_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Add education program";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Price of the program";
            // 
            // dgvPrograms
            // 
            this.dgvPrograms.AllowUserToAddRows = false;
            this.dgvPrograms.AllowUserToDeleteRows = false;
            this.dgvPrograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrograms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EPId,
            this.EPName,
            this.EPPrice});
            this.dgvPrograms.Location = new System.Drawing.Point(336, 75);
            this.dgvPrograms.Name = "dgvPrograms";
            this.dgvPrograms.ReadOnly = true;
            this.dgvPrograms.Size = new System.Drawing.Size(441, 344);
            this.dgvPrograms.TabIndex = 21;
            this.dgvPrograms.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPrograms_RowHeaderMouseDoubleClick);
            // 
            // EPId
            // 
            this.EPId.HeaderText = "Id";
            this.EPId.Name = "EPId";
            this.EPId.ReadOnly = true;
            this.EPId.Visible = false;
            // 
            // EPName
            // 
            this.EPName.HeaderText = "Education Program";
            this.EPName.Name = "EPName";
            this.EPName.ReadOnly = true;
            // 
            // EPPrice
            // 
            this.EPPrice.HeaderText = "Price";
            this.EPPrice.Name = "EPPrice";
            this.EPPrice.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "Education Program";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(336, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 23;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(497, 18);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 20);
            this.SearchBtn.TabIndex = 24;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // EducationProgramsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPrograms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EPPriceTxt);
            this.Controls.Add(this.EPNameTxt);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Name = "EducationProgramsForm";
            this.Text = "EducationProgramsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox EPNameTxt;
        private System.Windows.Forms.TextBox EPPriceTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPrograms;
        private System.Windows.Forms.DataGridViewTextBoxColumn EPId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EPPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchBtn;
    }
}