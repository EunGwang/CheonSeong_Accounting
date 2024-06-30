using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheonSeong_Accounting.FORM
{
    public partial class NewData_AddType : Form
    {
        private ExcelFile ex;
        public NewData_AddType(ExcelFile e)
        {
            InitializeComponent();
            ex = e;

            this.CBO_Colum.SelectedIndex = 0;
            this.BT_ADD.Click += BT_ADD_Click;
            this.BT_CLOSE.Click += BT_CLOSE_Click;
        }

        private void BT_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_ADD_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(T_Contents.Text))
            {
                MessageBox.Show("내용을 입력하세요.");
            }

            string SheetName = "";
            if(this.CBO_Colum.SelectedItem.ToString() == "수입항목 추가")
            {
                SheetName = "inType";
            }
            else if (this.CBO_Colum.SelectedItem.ToString() == "지출항목 추가")
            {
                SheetName = "outType";
            }
            else if (this.CBO_Colum.SelectedItem.ToString() == "이름 추가")
            {
                SheetName = "People";
            }

            ex.Imex = "0";
            ex.OpenExcel();
            ex.InsertData(SheetName, this.T_Contents.Text);
            ex.CloseExcel();
            MessageBox.Show("추가완료!");
            this.Close();
        }
    }
}
