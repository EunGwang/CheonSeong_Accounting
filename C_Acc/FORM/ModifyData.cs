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
    public partial class ModifyData : Form
    {
        ExcelFile ex;
        string[] rowdt;

        public ModifyData(ExcelFile ef, string[] rowdata)
        {

            InitializeComponent();

            //--------------버튼이벤트------------------
            this.BT_MODIFY.Click += BT_MODIFY_Click;
            this.BT_CLOSE.Click += BT_CLOSE_Click;
            //------------------------------------------

            //-------------컨트롤이벤트-----------------
            this.CBO_INOUT.SelectedIndexChanged += CBO_INOUT_SelectedIndexChanged;
            //------------------------------------------
            ex = ef;
            rowdt = rowdata;
            Initdata();
        }

        #region 버튼이벤트
        private void BT_MODIFY_Click(object sender, EventArgs e)
        {
            //수정클릭
            //데이터순서 : 날자,수입/지출,구분,이름,금액,비고
            string[] newrowdt = { D_DATETIME.Value.ToString("yyyyMMdd"),
                                  CBO_INOUT.SelectedItem.ToString(),
                                  CBO_TYPE.SelectedValue.ToString(),
                                  CBO_NAME.SelectedValue.ToString(),
                                  T_DONATION.Text,
                                  T_COMANTS.Text};
            ex.Imex = "0";
            ex.OpenExcel();
            ex.Update_Data("Data", rowdt, newrowdt);
            ex.CloseExcel();
            MessageBox.Show("수정 완료!");
        }

        private void BT_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void CBO_INOUT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CBO_INOUT.SelectedIndex == 0)  //수입
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

        private void Initdata()
        {
            ex.Imex = "1";
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

            //--------------------받아온 값 설정---------------------------
            string y = rowdt[0].Substring(0, 4); ;
            string m = rowdt[0].Substring(4, 2); ;
            string d = rowdt[0].Substring(6, 2); ;
            
            this.D_DATETIME.Value = new DateTime(int.Parse(y),int.Parse(m),int.Parse(d));   //날자
            this.CBO_INOUT.SelectedItem = rowdt[1]; //수입/지출
            this.CBO_TYPE.SelectedValue = rowdt[2]; //구분
            this.CBO_NAME.SelectedValue = rowdt[3]; //이름
            this.T_DONATION.Text = rowdt[4];    //금액
            this.T_COMANTS.Text = rowdt[5];  //비고
        }

    }
}
