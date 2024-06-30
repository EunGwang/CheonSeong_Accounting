using CheonSeong_Accounting.FORM;
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
    public partial class NewData : Form
    {
        public ExcelFile ex;

        public NewData(ExcelFile file)
        {

            InitializeComponent();

            //--------------버튼이벤트------------------
            this.BT_INSERT.Click += BT_INSERT_Click;
            this.BT_INSERTTYPE.Click += BT_INSERTTYPE_Click;
            //------------------------------------------

            //-------------컨트롤초기화-----------------
            this.CBO_INOUT.SelectedIndexChanged += CBO_INOUT_SelectedIndexChanged;
            //------------------------------------------
            ex = file;
            InitData(); //초기데이터세팅(콤보박스)
        }

        private void BT_INSERTTYPE_Click(object sender, EventArgs e)
        {
            NewData_AddType addtypeForm = new NewData_AddType(ex);
            addtypeForm.FormClosed += AddtypeForm_FormClosed;
            addtypeForm.ShowDialog();
        }


        private void BT_INSERT_Click(object sender, EventArgs e)
        {
            //입력
            if (this.CBO_INOUT.SelectedItem.ToString() == "<<전체>>")
            {
                MessageBox.Show("수입/지출을 선택하세요.");
                return;
            }
            if (this.CBO_TYPE.SelectedValue.ToString() == "<<전체>>")
            {
                MessageBox.Show("구분항목을 선택해주세요");
                return;
            }
            if (this.CBO_NAME.SelectedValue.ToString() == "<<전체>>")
            {
                MessageBox.Show("이름을 선택해주세요");
                return;
            }
            if (this.T_DONATION.Text == "")
            {
                MessageBox.Show("금액을 입력하세요.");
                return;
            }
            int numchek = 0;
            if(!int.TryParse(this.T_DONATION.Text, out numchek))
            {
                MessageBox.Show("올바른 금액을 입력하세요.");
                return;
            }

            string val ="'"+ this.D_DATETIME.Value.ToString("yyyyMMdd") + "',"+  //날자
                        "'" + this.CBO_INOUT.SelectedItem.ToString() + "',"+   //수입/지출
                        "'" + this.CBO_TYPE.SelectedValue.ToString() + "',"+   //구분
                        "'" + this.CBO_NAME.SelectedValue.ToString() + "',"+    //이름
                        "'" + this.T_DONATION.Text + "',"+                     //금액
                        "'" + this.T_COMANTS.Text + "'"                        //비고
                        ;
            ex.Imex = "0";
            ex.OpenExcel();
            ex.InsertData("Data", val);
            ex.CloseExcel();
            MessageBox.Show("추가완료!");
        }

        #region 데이터셋팅
        private void InitData()
        {
            ex.Imex = "1";
            ex.OpenExcel();

            this.CBO_INOUT.SelectedIndex = 0;       //초기값 수입

            DataTable dt1 = ex.GetDataTable("inType");
            this.CBO_TYPE.DataSource = dt1;
            this.CBO_TYPE.ValueMember = "구분";

            dt1 = ex.GetDataTable("People");
            this.CBO_NAME.DataSource = dt1;
            this.CBO_NAME.ValueMember = "이름";

            ex.CloseExcel();
        }
        #endregion

        #region 컨트롤이벤트
        private void AddtypeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InitData();
        }

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
        #endregion
    }
}
