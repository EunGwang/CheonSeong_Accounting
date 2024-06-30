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
    public partial class Start : Form
    {
        string FileFullName;

        public Start()
        {
            InitializeComponent();

            this.BT_FIND.Click += BT_FIND_Click;
            this.BT_INFILE.Click += BT_INFILE_Click;
        }

        private void BT_INFILE_Click(object sender, EventArgs e)
        {
            if(this.T_FILENAME.Text.Length == 0)
            {
                MessageBox.Show("엑셀파일을 선택해주세요.");
                return;
            }
            MainForm m = new MainForm(T_FILENAME.Text);
            this.Visible = false;
            m.Show();
            
        }

        private void BT_FIND_Click(object sender, EventArgs e)
        {
            //파일선택창 오픈
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();

            if(dr == DialogResult.OK) //선택시
            {
                FileFullName = ofd.FileName;
                this.T_FILENAME.Text = FileFullName;
            }
            else
            {
                return;
            }
        }
    }
}
