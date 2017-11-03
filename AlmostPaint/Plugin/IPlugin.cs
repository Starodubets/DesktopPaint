using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmostPaint.Plugin
{
    public interface IPlugin
    {
        string Name { get; }
        void Run(MenuStrip menu, ToolStrip stripMenu, ToolStripMenuItem item, GroupBox plug, GroupBox property);
    }
}
