using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMC_Flex_To_Temp
{
    
    public partial class Info : Form
    {

        string url = "https://www.youtube.com/c/OVERSPEED";
        string miurl = "https://www.youtube.com/channel/UCIo9VN-cylPe21pwRdhALSQ";
        public Info()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start(url);
        }

        private void pictureBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            System.Diagnostics.Process.Start(miurl);
        }

        private void pictureBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start(url);

        }
    }
}
