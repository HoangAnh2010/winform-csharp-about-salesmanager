using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.GUI
{
    public partial class frmKhoaTK : Form
    {
        public frmKhoaTK()
        {
            InitializeComponent();
        }
        int i, n;

        private void frmKhoaTK_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            i =10800;
            n = i;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Maximum = i;
            i--;
            this.lblDemLui.Text = "Thời gian còn lại là " + (i+1).ToString()  + " giây";
            if(i>=0)
            {
                progressBar1.Value = i ;
            }
            if(i<0)
            {
                this.timer1.Enabled = false;
                frmDangNhap f = new frmDangNhap();
                f.ShowDialog();
                this.Hide();
            }
        }
    }
}
