using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmostPaint.Controls
{
    public partial class PMenuLoc : MenuStrip
    {
        public PMenuLoc()
        {
            ToolStripMenuItem file = new ToolStripMenuItem();

            this.MdiWindowListItem = file;
            this.Items.Add(file);

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
