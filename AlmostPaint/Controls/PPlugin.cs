using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmostPaint.Controls
{
    public partial class PPlugin : UserControl
    {
        public PPlugin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
