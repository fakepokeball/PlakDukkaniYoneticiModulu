using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkaniYoneticiModulu
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public void FormAc(Form form)
        {
            panelDesktop.Controls.Clear();
            form.MdiParent = this;
            panelDesktop.Controls.Add(form);
            form.BringToFront();
            form.FormBorderStyle = FormBorderStyle.None;
            form.Height = panelDesktop.Height;
            form.Width = panelDesktop.Width;
            form.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.FormAc(new frmUpdate());
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.FormAc(new frmUserControl());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(pictureBox2);
            pictureBox2.Parent=panelDesktop;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.FormAc(new frmFinished());
        }

        private void txtSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnOnSales_Click(object sender, EventArgs e)
        {
            this.FormAc(new frmOnSales());
        }

        private void btnNewAlbums_Click(object sender, EventArgs e)
        {
            this.FormAc(new frmNewAlbums());
        }

        private void btnDiscounts_Click(object sender, EventArgs e)
        {
            this.FormAc(new frmDiscounts());
        }
    }
}
