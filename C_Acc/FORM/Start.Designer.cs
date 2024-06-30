namespace CheonSeong_Accounting.FORM
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.L_COMMENTS = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.T_FILENAME = new System.Windows.Forms.TextBox();
            this.BT_FIND = new System.Windows.Forms.Button();
            this.BT_INFILE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // L_COMMENTS
            // 
            this.L_COMMENTS.AutoSize = true;
            this.L_COMMENTS.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.L_COMMENTS.Location = new System.Drawing.Point(12, 25);
            this.L_COMMENTS.Name = "L_COMMENTS";
            this.L_COMMENTS.Size = new System.Drawing.Size(498, 19);
            this.L_COMMENTS.TabIndex = 17;
            this.L_COMMENTS.Text = "★연결할 엑셀파일을 선택해주세요.(.xls 파일만 가능!)";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.xlsx";
            this.openFileDialog1.Filter = "[엑셀 파일(*.xlsx)|*.xlsx]";
            this.openFileDialog1.Title = "엑셀파일을 선택해주세요.";
            // 
            // T_FILENAME
            // 
            this.T_FILENAME.CausesValidation = false;
            this.T_FILENAME.Location = new System.Drawing.Point(12, 62);
            this.T_FILENAME.Name = "T_FILENAME";
            this.T_FILENAME.ReadOnly = true;
            this.T_FILENAME.Size = new System.Drawing.Size(371, 21);
            this.T_FILENAME.TabIndex = 18;
            this.T_FILENAME.TabStop = false;
            this.T_FILENAME.WordWrap = false;
            // 
            // BT_FIND
            // 
            this.BT_FIND.Location = new System.Drawing.Point(389, 62);
            this.BT_FIND.Name = "BT_FIND";
            this.BT_FIND.Size = new System.Drawing.Size(70, 23);
            this.BT_FIND.TabIndex = 19;
            this.BT_FIND.Text = "찾기";
            this.BT_FIND.UseVisualStyleBackColor = true;
            // 
            // BT_INFILE
            // 
            this.BT_INFILE.Location = new System.Drawing.Point(465, 62);
            this.BT_INFILE.Name = "BT_INFILE";
            this.BT_INFILE.Size = new System.Drawing.Size(70, 23);
            this.BT_INFILE.TabIndex = 19;
            this.BT_INFILE.Text = "연결";
            this.BT_INFILE.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(9, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "-Made By EunGwang(Ver.1.0.0)";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 113);
            this.Controls.Add(this.BT_INFILE);
            this.Controls.Add(this.BT_FIND);
            this.Controls.Add(this.T_FILENAME);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_COMMENTS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.Text = "엑셀연결 -Made By EunGwang(Ver.1.0.0)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_COMMENTS;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox T_FILENAME;
        private System.Windows.Forms.Button BT_FIND;
        private System.Windows.Forms.Button BT_INFILE;
        private System.Windows.Forms.Label label1;
    }
}