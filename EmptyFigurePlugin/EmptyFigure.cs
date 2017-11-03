using AlmostPaint.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmptyFigurePlugin
{
    public class EmptyFigure : IPlugin
    {
        Button btnEmptyPlugIn;
        Command command = new Command();
        public string Name
        {
            get { return "Empty figure"; }
        }

        public void Run(MenuStrip menu, ToolStrip stripMenu, ToolStripMenuItem item, GroupBox plug, GroupBox property)
        {

            if (item.CheckState == CheckState.Unchecked)
            {
                item.CheckState = CheckState.Checked;

                btnEmptyPlugIn = new Button();
                btnEmptyPlugIn.Enter += delegate { command.AddMenu(stripMenu, property); };
                btnEmptyPlugIn.Leave += delegate { command.DelMenu(stripMenu, property); };
                btnEmptyPlugIn.Cursor = Cursors.Default;
                btnEmptyPlugIn.Location = new System.Drawing.Point(47, 31);
                btnEmptyPlugIn.Name = "btnEmptyPlugIn";
                btnEmptyPlugIn.Size = new System.Drawing.Size(94, 27);
                btnEmptyPlugIn.TabIndex = 3;
                btnEmptyPlugIn.Text = "Empty Figure";
                btnEmptyPlugIn.UseVisualStyleBackColor = true;
                btnEmptyPlugIn.Visible = true;

                plug.Controls.Add(btnEmptyPlugIn);
            }
            else
            {
                plug.Controls.Remove(btnEmptyPlugIn);
                command.DelMenu(stripMenu, property);
                item.CheckState = CheckState.Unchecked;
            }
        }
    }
}
