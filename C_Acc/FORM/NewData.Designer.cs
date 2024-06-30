namespace CheonSeong_Accounting
{
    partial class NewData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewData));
            this.T_COMANTS = new System.Windows.Forms.TextBox();
            this.L_COMMENTS = new System.Windows.Forms.Label();
            this.CBO_NAME = new System.Windows.Forms.ComboBox();
            this.CBO_TYPE = new System.Windows.Forms.ComboBox();
            this.L_NAME = new System.Windows.Forms.Label();
            this.D_DATETIME = new System.Windows.Forms.DateTimePicker();
            this.L_TYPE = new System.Windows.Forms.Label();
            this.L_DATE = new System.Windows.Forms.Label();
            this.BT_INSERT = new System.Windows.Forms.Button();
            this.T_DONATION = new System.Windows.Forms.TextBox();
            this.L_DONATION = new System.Windows.Forms.Label();
            this.CBO_INOUT = new System.Windows.Forms.ComboBox();
            this.L_INOUT = new System.Windows.Forms.Label();
            this.BT_INSERTTYPE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // T_COMANTS
            // 
            this.T_COMANTS.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.T_COMANTS.Location = new System.Drawing.Point(83, 99);
            this.T_COMANTS.Name = "T_COMANTS";
            this.T_COMANTS.Size = new System.Drawing.Size(705, 29);
            this.T_COMANTS.TabIndex = 12;
            // 
            // L_COMMENTS
            // 
            this.L_COMMENTS.AutoSize = true;
            this.L_COMMENTS.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.L_COMMENTS.Location = new System.Drawing.Point(11, 104);
            this.L_COMMENTS.Name = "L_COMMENTS";
            this.L_COMMENTS.Size = new System.Drawing.Size(69, 19);
            this.L_COMMENTS.TabIndex = 5;
            this.L_COMMENTS.Text = "◆비고";
            // 
            // CBO_NAME
            // 
            this.CBO_NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBO_NAME.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CBO_NAME.FormattingEnabled = true;
            this.CBO_NAME.Location = new System.Drawing.Point(431, 56);
            this.CBO_NAME.Name = "CBO_NAME";
            this.CBO_NAME.Size = new System.Drawing.Size(121, 27);
            this.CBO_NAME.TabIndex = 10;
            // 
            // CBO_TYPE
            // 
            this.CBO_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBO_TYPE.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CBO_TYPE.FormattingEnabled = true;
            this.CBO_TYPE.Location = new System.Drawing.Point(83, 54);
            this.CBO_TYPE.Name = "CBO_TYPE";
            this.CBO_TYPE.Size = new System.Drawing.Size(255, 27);
            this.CBO_TYPE.TabIndex = 11;
            // 
            // L_NAME
            // 
            this.L_NAME.AutoSize = true;
            this.L_NAME.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.L_NAME.Location = new System.Drawing.Point(359, 59);
            this.L_NAME.Name = "L_NAME";
            this.L_NAME.Size = new System.Drawing.Size(69, 19);
            this.L_NAME.TabIndex = 6;
            this.L_NAME.Text = "◆이름";
            // 
            // D_DATETIME
            // 
            this.D_DATETIME.CustomFormat = "yyyyMMdd";
            this.D_DATETIME.Location = new System.Drawing.Point(83, 14);
            this.D_DATETIME.Name = "D_DATETIME";
            this.D_DATETIME.Size = new System.Drawing.Size(200, 21);
            this.D_DATETIME.TabIndex = 9;
            // 
            // L_TYPE
            // 
            this.L_TYPE.AutoSize = true;
            this.L_TYPE.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.L_TYPE.Location = new System.Drawing.Point(11, 57);
            this.L_TYPE.Name = "L_TYPE";
            this.L_TYPE.Size = new System.Drawing.Size(69, 19);
            this.L_TYPE.TabIndex = 7;
            this.L_TYPE.Text = "◆구분";
            // 
            // L_DATE
            // 
            this.L_DATE.AutoSize = true;
            this.L_DATE.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.L_DATE.Location = new System.Drawing.Point(11, 14);
            this.L_DATE.Name = "L_DATE";
            this.L_DATE.Size = new System.Drawing.Size(69, 19);
            this.L_DATE.TabIndex = 8;
            this.L_DATE.Text = "◆날자";
            // 
            // BT_INSERT
            // 
            this.BT_INSERT.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_INSERT.Location = new System.Drawing.Point(673, 134);
            this.BT_INSERT.Name = "BT_INSERT";
            this.BT_INSERT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BT_INSERT.Size = new System.Drawing.Size(115, 29);
            this.BT_INSERT.TabIndex = 13;
            this.BT_INSERT.Text = "입력";
            this.BT_INSERT.UseVisualStyleBackColor = true;
            // 
            // T_DONATION
            // 
            this.T_DONATION.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.T_DONATION.Location = new System.Drawing.Point(641, 54);
            this.T_DONATION.Name = "T_DONATION";
            this.T_DONATION.Size = new System.Drawing.Size(147, 29);
            this.T_DONATION.TabIndex = 15;
            // 
            // L_DONATION
            // 
            this.L_DONATION.AutoSize = true;
            this.L_DONATION.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.L_DONATION.Location = new System.Drawing.Point(569, 59);
            this.L_DONATION.Name = "L_DONATION";
            this.L_DONATION.Size = new System.Drawing.Size(69, 19);
            this.L_DONATION.TabIndex = 14;
            this.L_DONATION.Text = "◆금액";
            // 
            // CBO_INOUT
            // 
            this.CBO_INOUT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBO_INOUT.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CBO_INOUT.FormattingEnabled = true;
            this.CBO_INOUT.Items.AddRange(new object[] {
            "수입",
            "지출"});
            this.CBO_INOUT.Location = new System.Drawing.Point(444, 14);
            this.CBO_INOUT.Name = "CBO_INOUT";
            this.CBO_INOUT.Size = new System.Drawing.Size(121, 27);
            this.CBO_INOUT.TabIndex = 17;
            // 
            // L_INOUT
            // 
            this.L_INOUT.AutoSize = true;
            this.L_INOUT.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.L_INOUT.Location = new System.Drawing.Point(320, 16);
            this.L_INOUT.Name = "L_INOUT";
            this.L_INOUT.Size = new System.Drawing.Size(118, 19);
            this.L_INOUT.TabIndex = 16;
            this.L_INOUT.Text = "◆수입/지출";
            // 
            // BT_INSERTTYPE
            // 
            this.BT_INSERTTYPE.Location = new System.Drawing.Point(15, 134);
            this.BT_INSERTTYPE.Name = "BT_INSERTTYPE";
            this.BT_INSERTTYPE.Size = new System.Drawing.Size(87, 29);
            this.BT_INSERTTYPE.TabIndex = 18;
            this.BT_INSERTTYPE.Text = "구분추가";
            this.BT_INSERTTYPE.UseVisualStyleBackColor = true;
            // 
            // NewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 170);
            this.Controls.Add(this.BT_INSERTTYPE);
            this.Controls.Add(this.CBO_INOUT);
            this.Controls.Add(this.L_INOUT);
            this.Controls.Add(this.T_DONATION);
            this.Controls.Add(this.L_DONATION);
            this.Controls.Add(this.BT_INSERT);
            this.Controls.Add(this.T_COMANTS);
            this.Controls.Add(this.L_COMMENTS);
            this.Controls.Add(this.CBO_NAME);
            this.Controls.Add(this.CBO_TYPE);
            this.Controls.Add(this.L_NAME);
            this.Controls.Add(this.D_DATETIME);
            this.Controls.Add(this.L_TYPE);
            this.Controls.Add(this.L_DATE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewData";
            this.Text = "수입/지출 입력 -Made By EunGwang(Ver.1.0.0)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox T_COMANTS;
        private System.Windows.Forms.Label L_COMMENTS;
        private System.Windows.Forms.ComboBox CBO_NAME;
        private System.Windows.Forms.ComboBox CBO_TYPE;
        private System.Windows.Forms.Label L_NAME;
        private System.Windows.Forms.DateTimePicker D_DATETIME;
        private System.Windows.Forms.Label L_TYPE;
        private System.Windows.Forms.Label L_DATE;
        private System.Windows.Forms.Button BT_INSERT;
        private System.Windows.Forms.TextBox T_DONATION;
        private System.Windows.Forms.Label L_DONATION;
        private System.Windows.Forms.ComboBox CBO_INOUT;
        private System.Windows.Forms.Label L_INOUT;
        private System.Windows.Forms.Button BT_INSERTTYPE;
    }
}