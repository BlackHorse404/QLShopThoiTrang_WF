using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLShopThoiTrang.GUI
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        int imgindex = 1;
        private void slider()
        {
            if(imgindex == 4)
            {
                imgindex = 1;
            }
            imgindex++;
            var path = string.Format(@"../../Resources/images/post{0}.jpg", imgindex);
            var fullPath = Path.GetFullPath(path);
            picBox.ImageLocation = fullPath;
            //MessageBox.Show(fullPath.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            slider();
        }
    }
}
