using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;

namespace CheonSeong_Accounting
{
    public partial class MainForm : Form
    {
        public string File;
        public DBManager ex;

        public MainForm(string filename)
        {
            InitializeComponent();

            //--------------버튼이벤트------------------
            this.BT_SEARCH.Click += BT_SEARCH_Click;        //조회
            this.BT_NEW.Click += BT_NEW_Click;              //신규입력
            this.BT_MODIFY.Click += BT_MODIFY_Click;        //수정
            this.BT_CALCULATE.Click += BT_CALCULATE_Click;  //정산
            this.BT_SEARCHALL.Click += BT_SEARCHALL_Click;  //전체조회
            this.BT_CLOSE.Click += BT_CLOSE_Click;          //닫기
            //------------------------------------------

            //-------------컨트롤이벤트-----------------
            this.CBO_INOUT.SelectedIndexChanged += CBO_INOUT_SelectedIndexChanged;
            //------------------------------------------

            File = filename;
            ex = new DBManager(File, "1", true);
            InitData(); //초기데이터세팅(콤보박스)
        }



        #region 버튼이벤트
        private void BT_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
            Process.GetCurrentProcess().Kill();
        }

        private void BT_CALCULATE_Click(object sender, EventArgs e)
        {
            //정산
            Calculate Cal = new Calculate(ex);
            Cal.ShowDialog();
        }

        private void BT_MODIFY_Click(object sender, EventArgs e)
        {
            //수정
            //데이터순서 : 날자,수입/지출,구분,이름,금액,비고
            string[] rowdt = { this.dataGridView1.Rows[this.dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString(),
                               this.dataGridView1.Rows[this.dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString(),
                               this.dataGridView1.Rows[this.dataGridView1.CurrentCellAddress.Y].Cells[2].Value.ToString(),
                               this.dataGridView1.Rows[this.dataGridView1.CurrentCellAddress.Y].Cells[3].Value.ToString(),
                               this.dataGridView1.Rows[this.dataGridView1.CurrentCellAddress.Y].Cells[4].Value.ToString(),
                               this.dataGridView1.Rows[this.dataGridView1.CurrentCellAddress.Y].Cells[5].Value.ToString()};
            ModifyData modifydata = new ModifyData(ex, rowdt);
            modifydata.ShowDialog();
        }

        private void BT_NEW_Click(object sender, EventArgs e)
        {
            //신규입력 팝업
            NewData newdata = new NewData(ex);
            newdata.FormClosed += Newdata_FormClosed;
            newdata.ShowDialog();
        }

        private void BT_SEARCH_Click(object sender, EventArgs e)
        {
            //조회
            ex.Imex = "1";
            ex.OpenExcel();

            string[] condition = new string[] {this.D_startDate.Value.ToString("yyyyMMdd"),
                                               this.CBO_INOUT.SelectedItem.ToString(),
                                               this.CBO_TYPE.SelectedValue.ToString(),
                                               this.CBO_NAME.SelectedValue.ToString(),
                                               this.T_DONATION.Text,
                                               };

            DataTable dt = ex.GetDataTable("Data",condition);

            this.dataGridView1.DataSource = dt;
            ex.CloseExcel();

        }

        private void BT_SEARCHALL_Click(object sender, EventArgs e)
        {
            //조회
            ex.Imex = "1";
            ex.OpenExcel();

            DataTable dt = ex.GetDataTable("Data");

            this.dataGridView1.DataSource = dt;
            ex.CloseExcel();
        }
        #endregion

        #region 데이터셋팅
        private void InitData()
        {
            ex.Imex = "0";
            ex.OpenExcel();

            this.CBO_INOUT.SelectedIndex = 0;       //초기값 <<전체>>
            DataTable dt1 = ex.GetDataTable("inType");
            DataTable dt2 = ex.GetDataTable("outType");
            dt1.Merge(dt2);
            this.CBO_TYPE.DataSource = dt1;
            this.CBO_TYPE.ValueMember = "구분";

            dt2 = ex.GetDataTable("People");
            this.CBO_NAME.DataSource = dt2;
            this.CBO_NAME.ValueMember = "이름";

            ex.CloseExcel();
        }
        #endregion

        #region 컨트롤이벤트
        private void Newdata_FormClosed(object sender, FormClosedEventArgs e)
        {
            InitData();
        }

        private void CBO_INOUT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CBO_INOUT.SelectedIndex == 0)  //==전체==
            {
                ex.Imex = "1";
                ex.OpenExcel();

                DataTable dt1 = ex.GetDataTable("inType");
                DataTable dt2 = ex.GetDataTable("outType");
                dt1.Merge(dt2);
                this.CBO_TYPE.DataSource = dt1;
                this.CBO_TYPE.ValueMember = "구분";

                ex.CloseExcel();
            }
            else if(this.CBO_INOUT.SelectedIndex == 1)  //수입
            {
                ex.Imex = "1";
                ex.OpenExcel();

                DataTable dt = ex.GetDataTable("inType");
                this.CBO_TYPE.DataSource = dt;
                this.CBO_TYPE.ValueMember = "구분";

                ex.CloseExcel();
            }
            else   //지출
            {
                ex.Imex = "1";
                ex.OpenExcel();

                DataTable dt = ex.GetDataTable("outType");
                this.CBO_TYPE.DataSource = dt;
                this.CBO_TYPE.ValueMember = "구분";

                ex.CloseExcel();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
        #endregion

    }
}
