using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1_home_applicant_with_SQL_
{
    public partial class MenuOfTech : Form
    {
        public MenuOfTech()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddPage_Click(object sender, EventArgs e)
        {
            add a = new add();
            this.Hide();
            a.ShowDialog();
            this.Close();

        }

        private void BtnSeePage_Click(object sender, EventArgs e)
        {
            See s = new See();
            this.Hide();
            s.ShowDialog();
            this.Close();
        }
    }
}
