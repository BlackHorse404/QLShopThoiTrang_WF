using QLShopThoiTrang.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLShopThoiTrang.GUI
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        //open form into panel main
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panel_ViewMain_BotRight.Controls.Add(childForm);
            panel_ViewMain_BotRight.Tag = childForm;
            title.Text = childForm.Text;
            childForm.BringToFront();
            childForm.Show();
        }

        private void menuTrangChu_Click(object sender, EventArgs e)
        {
            Form TrangChu = new FormTrangChu();
            openChildForm(TrangChu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Formtest f = new Formtest();
            //openChildForm(f);
        }
    }
}
