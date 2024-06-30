using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheonSeong_Accounting
{
    public partial class Calculate : Form
    {
        private ExcelFile ex;

        public Calculate(ExcelFile e)
        {
            InitializeComponent();

            ex = e;
            //================버튼이벤트=================
            this.BT_DAY_IN.Click += BT_DAY_IN_Click;
            this.BT_DAY_OUT.Click += BT_DAY_OUT_Click;
            this.BT_MON_IN.Click += BT_MON_IN_Click;
            this.BT_MON_OUT.Click += BT_MON_OUT_Click;
            this.BT_YEAR_IN.Click += BT_YEAR_IN_Click;
            this.BT_YEAR_OUT.Click += BT_YEAR_OUT_Click;
            this.BT_PERSON.Click += BT_PERSON_Click;
            //===========================================
        }

        #region 버튼이벤트
        private void BT_PERSON_Click(object sender, EventArgs e)
        {
            ex.Imex = "1";
            ex.OpenExcel();
            DataTable dt = ex.Calculate_in(this.D_startDate.Value.ToString("yyyyMMdd"), "Person");
            this.dataGridView1.DataSource = dt;
            ex.CloseExcel();
        }
        
        private void BT_YEAR_OUT_Click(object sender, EventArgs e)
        {
            ex.Imex = "1";
            ex.OpenExcel();
            DataTable dt = ex.Calculate_out(this.D_startDate.Value.ToString("yyyyMMdd"), "Year");
            this.dataGridView1.DataSource = dt;
            ex.CloseExcel();
        }

        private void BT_YEAR_IN_Click(object sender, EventArgs e)
        {
            ex.Imex = "1";
            ex.OpenExcel();
            DataTable dt = ex.Calculate_in(this.D_startDate.Value.ToString("yyyyMMdd"), "Year");
            this.dataGridView1.DataSource = dt;
            ex.CloseExcel();
        }

        private void BT_MON_OUT_Click(object sender, EventArgs e)
        {
            ex.Imex = "1";
            ex.OpenExcel();
            DataTable dt = ex.Calculate_out(this.D_startDate.Value.ToString("yyyyMMdd"), "Mon");
            this.dataGridView1.DataSource = dt;
            ex.CloseExcel();
        }

        private void BT_MON_IN_Click(object sender, EventArgs e)
        {
            ex.Imex = "1";
            ex.OpenExcel();
            DataTable dt = ex.Calculate_in(this.D_startDate.Value.ToString("yyyyMMdd"), "Mon");
            this.dataGridView1.DataSource = dt;
            ex.CloseExcel();
        }

        private void BT_DAY_OUT_Click(object sender, EventArgs e)
        {
            ex.Imex = "1";
            ex.OpenExcel();
            DataTable dt = ex.Calculate_out(this.D_startDate.Value.ToString("yyyyMMdd"), "Today");
            this.dataGridView1.DataSource = dt;
            ex.CloseExcel();
        }

        private void BT_DAY_IN_Click(object sender, EventArgs e)
        {
            ex.Imex = "1";
            ex.OpenExcel();
            DataTable dt = ex.Calculate_in(this.D_startDate.Value.ToString("yyyyMMdd"),"Today");
            this.dataGridView1.DataSource = dt;
            ex.CloseExcel();
        }
        #endregion
    }
}
