namespace CheonSeong_Accounting.FORM
{
    partial class NewData_AddType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewData_AddType));
            this.BT_ADD = new System.Windows.Forms.Button();
            this.CBO_Colum = new System.Windows.Forms.ComboBox();
            this.L_NAME = new System.Windows.Forms.Label();
            this.T_Contents = new System.Windows.Forms.TextBox();
            this.L_COMMENTS = new System.Windows.Forms.Label();
            this.BT_CLOSE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_ADD
            // 
            this.BT_ADD.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_ADD.Location = new System.Drawing.Point(371, 8);
            this.BT_ADD.Name = "BT_ADD";
            this.BT_ADD.Size = new System.Drawing.Size(119, 54);
            this.BT_ADD.TabIndex = 8;
            this.BT_ADD.Text = "추가하기";
            this.BT_ADD.UseVisualStyleBackColor = true;
            // 
            // CBO_Colum
            // 
            this.CBO_Colum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBO_Colum.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CBO_Colum.FormattingEnabled = true;
            this.CBO_Colum.Items.AddRange(new object[] {
            "수입항목 추가",
            "지출항목 추가",
            "이름 추가"});
            this.CBO_Colum.Location = new System.Drawing.Point(137, 25);
            this.CBO_Colum.Name = "CBO_Colum";
            this.CBO_Colum.Size = new System.Drawing.Size(214, 27);
            this.CBO_Colum.TabIndex = 7;
            // 
            // L_NAME
            // 
            this.L_NAME.AutoSize = true;
            this.L_NAME.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.L_NAME.Location = new System.Drawing.Point(15, 28);
            this.L_NAME.Name = "L_NAME";
            this.L_NAME.Size = new System.Drawing.Size(116, 19);
            this.L_NAME.TabIndex = 6;
            this.L_NAME.Text = "◆추가 항목";
            // 
            // T_Contents
            // 
            this.T_Contents.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.T_Contents.Location = new System.Drawing.Point(137, 67);
            this.T_Contents.Name = "T_Contents";
            this.T_Contents.Size = new System.Drawing.Size(214, 29);
            this.T_Contents.TabIndex = 14;
            // 
            // L_COMMENTS
            // 
            this.L_COMMENTS.AutoSize = true;
            this.L_COMMENTS.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.L_COMMENTS.Location = new System.Drawing.Point(15, 70);
            this.L_COMMENTS.Name = "L_COMMENTS";
            this.L_COMMENTS.Size = new System.Drawing.Size(116, 19);
            this.L_COMMENTS.TabIndex = 13;
            this.L_COMMENTS.Text = "◆추가 내용";
            // 
            // BT_CLOSE
            // 
            this.BT_CLOSE.Location = new System.Drawing.Point(371, 68);
            this.BT_CLOSE.Name = "BT_CLOSE";
            this.BT_CLOSE.Size = new System.Drawing.Size(119, 35);
            this.BT_CLOSE.TabIndex = 30;
            this.BT_CLOSE.Text = "닫기";
            this.BT_CLOSE.UseVisualStyleBackColor = true;
            // 
            // NewData_AddType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 115);
            this.Controls.Add(this.BT_CLOSE);
            this.Controls.Add(this.T_Contents);
            this.Controls.Add(this.L_COMMENTS);
            this.Controls.Add(this.BT_ADD);
            this.Controls.Add(this.CBO_Colum);
            this.Controls.Add(this.L_NAME);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewData_AddType";
            this.Text = "구분추가 -Made By EunGwang(Ver.1.0.0)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_ADD;
        private System.Windows.Forms.ComboBox CBO_Colum;
        private System.Windows.Forms.Label L_NAME;
        private System.Windows.Forms.TextBox T_Contents;
        private System.Windows.Forms.Label L_COMMENTS;
        private System.Windows.Forms.Button BT_CLOSE;
    }
}