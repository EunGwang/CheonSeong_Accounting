namespace CheonSeong_Accounting
{
    partial class Calculate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculate));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BT_DAY_IN = new System.Windows.Forms.Button();
            this.L_STATE = new System.Windows.Forms.Label();
            this.BT_DAY_OUT = new System.Windows.Forms.Button();
            this.BT_MON_IN = new System.Windows.Forms.Button();
            this.BT_MON_OUT = new System.Windows.Forms.Button();
            this.BT_YEAR_IN = new System.Windows.Forms.Button();
            this.BT_YEAR_OUT = new System.Windows.Forms.Button();
            this.BT_PERSON = new System.Windows.Forms.Button();
            this.D_startDate = new System.Windows.Forms.DateTimePicker();
            this.L_DATE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(824, 459);
            this.dataGridView1.TabIndex = 13;
            // 
            // BT_DAY_IN
            // 
            this.BT_DAY_IN.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_DAY_IN.Location = new System.Drawing.Point(17, 12);
            this.BT_DAY_IN.Name = "BT_DAY_IN";
            this.BT_DAY_IN.Size = new System.Drawing.Size(109, 42);
            this.BT_DAY_IN.TabIndex = 11;
            this.BT_DAY_IN.Text = "일일 수입 정산";
            this.BT_DAY_IN.UseVisualStyleBackColor = true;
            // 
            // L_STATE
            // 
            this.L_STATE.AutoSize = true;
            this.L_STATE.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.L_STATE.Location = new System.Drawing.Point(12, 58);
            this.L_STATE.Name = "L_STATE";
            this.L_STATE.Size = new System.Drawing.Size(275, 29);
            this.L_STATE.TabIndex = 8;
            this.L_STATE.Text = "※일일 정산입니다.";
            // 
            // BT_DAY_OUT
            // 
            this.BT_DAY_OUT.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_DAY_OUT.Location = new System.Drawing.Point(132, 12);
            this.BT_DAY_OUT.Name = "BT_DAY_OUT";
            this.BT_DAY_OUT.Size = new System.Drawing.Size(109, 42);
            this.BT_DAY_OUT.TabIndex = 11;
            this.BT_DAY_OUT.Text = "일일 지출 정산";
            this.BT_DAY_OUT.UseVisualStyleBackColor = true;
            // 
            // BT_MON_IN
            // 
            this.BT_MON_IN.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_MON_IN.Location = new System.Drawing.Point(247, 12);
            this.BT_MON_IN.Name = "BT_MON_IN";
            this.BT_MON_IN.Size = new System.Drawing.Size(109, 42);
            this.BT_MON_IN.TabIndex = 11;
            this.BT_MON_IN.Text = "월말 수입 정산";
            this.BT_MON_IN.UseVisualStyleBackColor = true;
            // 
            // BT_MON_OUT
            // 
            this.BT_MON_OUT.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_MON_OUT.Location = new System.Drawing.Point(362, 12);
            this.BT_MON_OUT.Name = "BT_MON_OUT";
            this.BT_MON_OUT.Size = new System.Drawing.Size(109, 42);
            this.BT_MON_OUT.TabIndex = 11;
            this.BT_MON_OUT.Text = "월말 지출 정산";
            this.BT_MON_OUT.UseVisualStyleBackColor = true;
            // 
            // BT_YEAR_IN
            // 
            this.BT_YEAR_IN.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_YEAR_IN.Location = new System.Drawing.Point(477, 12);
            this.BT_YEAR_IN.Name = "BT_YEAR_IN";
            this.BT_YEAR_IN.Size = new System.Drawing.Size(109, 42);
            this.BT_YEAR_IN.TabIndex = 11;
            this.BT_YEAR_IN.Text = "연말 수입 정산";
            this.BT_YEAR_IN.UseVisualStyleBackColor = true;
            // 
            // BT_YEAR_OUT
            // 
            this.BT_YEAR_OUT.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_YEAR_OUT.Location = new System.Drawing.Point(592, 12);
            this.BT_YEAR_OUT.Name = "BT_YEAR_OUT";
            this.BT_YEAR_OUT.Size = new System.Drawing.Size(109, 42);
            this.BT_YEAR_OUT.TabIndex = 11;
            this.BT_YEAR_OUT.Text = "연말 지출 정산";
            this.BT_YEAR_OUT.UseVisualStyleBackColor = true;
            // 
            // BT_PERSON
            // 
            this.BT_PERSON.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BT_PERSON.Location = new System.Drawing.Point(709, 12);
            this.BT_PERSON.Name = "BT_PERSON";
            this.BT_PERSON.Size = new System.Drawing.Size(127, 42);
            this.BT_PERSON.TabIndex = 11;
            this.BT_PERSON.Text = "사람별 연말 정산";
            this.BT_PERSON.UseVisualStyleBackColor = true;
            // 
            // D_startDate
            // 
            this.D_startDate.CustomFormat = "yyyyMMdd";
            this.D_startDate.Location = new System.Drawing.Point(552, 67);
            this.D_startDate.Name = "D_startDate";
            this.D_startDate.Size = new System.Drawing.Size(284, 21);
            this.D_startDate.TabIndex = 15;
            // 
            // L_DATE
            // 
            this.L_DATE.AutoSize = true;
            this.L_DATE.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.L_DATE.Location = new System.Drawing.Point(437, 68);
            this.L_DATE.Name = "L_DATE";
            this.L_DATE.Size = new System.Drawing.Size(109, 19);
            this.L_DATE.TabIndex = 14;
            this.L_DATE.Text = "★기준날자";
            // 
            // Calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 570);
            this.Controls.Add(this.D_startDate);
            this.Controls.Add(this.L_DATE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BT_PERSON);
            this.Controls.Add(this.BT_YEAR_OUT);
            this.Controls.Add(this.BT_YEAR_IN);
            this.Controls.Add(this.BT_MON_OUT);
            this.Controls.Add(this.BT_MON_IN);
            this.Controls.Add(this.BT_DAY_OUT);
            this.Controls.Add(this.BT_DAY_IN);
            this.Controls.Add(this.L_STATE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculate";
            this.Text = "정산 -Made By EunGwang(Ver.1.0.0)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BT_DAY_IN;
        private System.Windows.Forms.Label L_STATE;
        private System.Windows.Forms.Button BT_DAY_OUT;
        private System.Windows.Forms.Button BT_MON_IN;
        private System.Windows.Forms.Button BT_MON_OUT;
        private System.Windows.Forms.Button BT_YEAR_IN;
        private System.Windows.Forms.Button BT_YEAR_OUT;
        private System.Windows.Forms.Button BT_PERSON;
        private System.Windows.Forms.DateTimePicker D_startDate;
        private System.Windows.Forms.Label L_DATE;
    }
}