namespace CheonSeong_Accounting
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.L_DATE = new System.Windows.Forms.Label();
            this.D_startDate = new System.Windows.Forms.DateTimePicker();
            this.L_TYPE = new System.Windows.Forms.Label();
            this.CBO_TYPE = new System.Windows.Forms.ComboBox();
            this.L_NAME = new System.Windows.Forms.Label();
            this.L_DONATION = new System.Windows.Forms.Label();
            this.CBO_NAME = new System.Windows.Forms.ComboBox();
            this.T_DONATION = new System.Windows.Forms.TextBox();
            this.BT_SEARCH = new System.Windows.Forms.Button();
            this.BT_NEW = new System.Windows.Forms.Button();
            this.BT_MODIFY = new System.Windows.Forms.Button();
            this.BT_CALCULATE = new System.Windows.Forms.Button();
            this.L_INOUT = new System.Windows.Forms.Label();
            this.CBO_INOUT = new System.Windows.Forms.ComboBox();
            this.BT_SEARCHALL = new System.Windows.Forms.Button();
            this.BT_CLOSE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(946, 508);
            this.dataGridView1.TabIndex = 0;
            // 
            // L_DATE
            // 
            this.L_DATE.AutoSize = true;
            this.L_DATE.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.L_DATE.Location = new System.Drawing.Point(23, 19);
            this.L_DATE.Name = "L_DATE";
            this.L_DATE.Size = new System.Drawing.Size(69, 19);
            this.L_DATE.TabIndex = 1;
            this.L_DATE.Text = "◆날자";
            // 
            // D_startDate
            // 
            this.D_startDate.CustomFormat = "yyyyMMdd";
            this.D_startDate.Location = new System.Drawing.Point(95, 19);
            this.D_startDate.Name = "D_startDate";
            this.D_startDate.Size = new System.Drawing.Size(266, 21);
            this.D_startDate.TabIndex = 2;
            // 
            // L_TYPE
            // 
            this.L_TYPE.AutoSize = true;
            this.L_TYPE.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.L_TYPE.Location = new System.Drawing.Point(23, 62);
            this.L_TYPE.Name = "L_TYPE";
            this.L_TYPE.Size = new System.Drawing.Size(69, 19);
            this.L_TYPE.TabIndex = 1;
            this.L_TYPE.Text = "◆구분";
            // 
            // CBO_TYPE
            // 
            this.CBO_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBO_TYPE.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CBO_TYPE.FormattingEnabled = true;
            this.CBO_TYPE.Location = new System.Drawing.Point(95, 59);
            this.CBO_TYPE.Name = "CBO_TYPE";
            this.CBO_TYPE.Size = new System.Drawing.Size(266, 27);
            this.CBO_TYPE.TabIndex = 3;
            // 
            // L_NAME
            // 
            this.L_NAME.AutoSize = true;
            this.L_NAME.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.L_NAME.Location = new System.Drawing.Point(367, 62);
            this.L_NAME.Name = "L_NAME";
            this.L_NAME.Size = new System.Drawing.Size(69, 19);
            this.L_NAME.TabIndex = 1;
            this.L_NAME.Text = "◆이름";
            // 
            // L_DONATION
            // 
            this.L_DONATION.AutoSize = true;
            this.L_DONATION.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.L_DONATION.Location = new System.Drawing.Point(566, 62);
            this.L_DONATION.Name = "L_DONATION";
            this.L_DONATION.Size = new System.Drawing.Size(69, 19);
            this.L_DONATION.TabIndex = 1;
            this.L_DONATION.Text = "◆금액";
            // 
            // CBO_NAME
            // 
            this.CBO_NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBO_NAME.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CBO_NAME.FormattingEnabled = true;
            this.CBO_NAME.Location = new System.Drawing.Point(439, 59);
            this.CBO_NAME.Name = "CBO_NAME";
            this.CBO_NAME.Size = new System.Drawing.Size(121, 27);
            this.CBO_NAME.TabIndex = 3;
            // 
            // T_DONATION
            // 
            this.T_DONATION.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.T_DONATION.Location = new System.Drawing.Point(638, 57);
            this.T_DONATION.Name = "T_DONATION";
            this.T_DONATION.Size = new System.Drawing.Size(147, 29);
            this.T_DONATION.TabIndex = 4;
            // 
            // BT_SEARCH
            // 
            this.BT_SEARCH.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_SEARCH.Location = new System.Drawing.Point(804, 12);
            this.BT_SEARCH.Name = "BT_SEARCH";
            this.BT_SEARCH.Size = new System.Drawing.Size(154, 34);
            this.BT_SEARCH.TabIndex = 5;
            this.BT_SEARCH.Text = "조건조회";
            this.BT_SEARCH.UseVisualStyleBackColor = true;
            // 
            // BT_NEW
            // 
            this.BT_NEW.Location = new System.Drawing.Point(694, 606);
            this.BT_NEW.Name = "BT_NEW";
            this.BT_NEW.Size = new System.Drawing.Size(85, 33);
            this.BT_NEW.TabIndex = 6;
            this.BT_NEW.Text = "신규입력";
            this.BT_NEW.UseVisualStyleBackColor = true;
            // 
            // BT_MODIFY
            // 
            this.BT_MODIFY.Location = new System.Drawing.Point(782, 606);
            this.BT_MODIFY.Name = "BT_MODIFY";
            this.BT_MODIFY.Size = new System.Drawing.Size(85, 33);
            this.BT_MODIFY.TabIndex = 6;
            this.BT_MODIFY.Text = "수정";
            this.BT_MODIFY.UseVisualStyleBackColor = true;
            // 
            // BT_CALCULATE
            // 
            this.BT_CALCULATE.Location = new System.Drawing.Point(12, 606);
            this.BT_CALCULATE.Name = "BT_CALCULATE";
            this.BT_CALCULATE.Size = new System.Drawing.Size(85, 33);
            this.BT_CALCULATE.TabIndex = 6;
            this.BT_CALCULATE.Text = "정산하기";
            this.BT_CALCULATE.UseVisualStyleBackColor = true;
            // 
            // L_INOUT
            // 
            this.L_INOUT.AutoSize = true;
            this.L_INOUT.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.L_INOUT.Location = new System.Drawing.Point(426, 21);
            this.L_INOUT.Name = "L_INOUT";
            this.L_INOUT.Size = new System.Drawing.Size(118, 19);
            this.L_INOUT.TabIndex = 1;
            this.L_INOUT.Text = "◆수입/지출";
            // 
            // CBO_INOUT
            // 
            this.CBO_INOUT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBO_INOUT.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CBO_INOUT.FormattingEnabled = true;
            this.CBO_INOUT.Items.AddRange(new object[] {
            "<<전체>>",
            "수입",
            "지출"});
            this.CBO_INOUT.Location = new System.Drawing.Point(550, 19);
            this.CBO_INOUT.Name = "CBO_INOUT";
            this.CBO_INOUT.Size = new System.Drawing.Size(121, 27);
            this.CBO_INOUT.TabIndex = 3;
            // 
            // BT_SEARCHALL
            // 
            this.BT_SEARCHALL.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_SEARCHALL.Location = new System.Drawing.Point(804, 52);
            this.BT_SEARCHALL.Name = "BT_SEARCHALL";
            this.BT_SEARCHALL.Size = new System.Drawing.Size(154, 34);
            this.BT_SEARCHALL.TabIndex = 5;
            this.BT_SEARCHALL.Text = "전체조회";
            this.BT_SEARCHALL.UseVisualStyleBackColor = true;
            // 
            // BT_CLOSE
            // 
            this.BT_CLOSE.Location = new System.Drawing.Point(873, 606);
            this.BT_CLOSE.Name = "BT_CLOSE";
            this.BT_CLOSE.Size = new System.Drawing.Size(85, 33);
            this.BT_CLOSE.TabIndex = 6;
            this.BT_CLOSE.Text = "닫기";
            this.BT_CLOSE.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 643);
            this.Controls.Add(this.BT_CLOSE);
            this.Controls.Add(this.BT_MODIFY);
            this.Controls.Add(this.BT_CALCULATE);
            this.Controls.Add(this.BT_NEW);
            this.Controls.Add(this.BT_SEARCHALL);
            this.Controls.Add(this.BT_SEARCH);
            this.Controls.Add(this.T_DONATION);
            this.Controls.Add(this.CBO_INOUT);
            this.Controls.Add(this.CBO_NAME);
            this.Controls.Add(this.L_DONATION);
            this.Controls.Add(this.L_INOUT);
            this.Controls.Add(this.CBO_TYPE);
            this.Controls.Add(this.L_NAME);
            this.Controls.Add(this.D_startDate);
            this.Controls.Add(this.L_TYPE);
            this.Controls.Add(this.L_DATE);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "천성교회 회계 -Made By EunGwang(Ver.1.0.0)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label L_DATE;
        private System.Windows.Forms.DateTimePicker D_startDate;
        private System.Windows.Forms.Label L_TYPE;
        private System.Windows.Forms.ComboBox CBO_TYPE;
        private System.Windows.Forms.Label L_NAME;
        private System.Windows.Forms.Label L_DONATION;
        private System.Windows.Forms.ComboBox CBO_NAME;
        private System.Windows.Forms.TextBox T_DONATION;
        private System.Windows.Forms.Button BT_SEARCH;
        private System.Windows.Forms.Button BT_NEW;
        private System.Windows.Forms.Button BT_MODIFY;
        private System.Windows.Forms.Button BT_CALCULATE;
        private System.Windows.Forms.Label L_INOUT;
        private System.Windows.Forms.ComboBox CBO_INOUT;
        private System.Windows.Forms.Button BT_SEARCHALL;
        private System.Windows.Forms.Button BT_CLOSE;
    }
}

