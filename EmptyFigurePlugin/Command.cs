using AlmostPaint.Controls;
using EmptyFigurePlugin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmptyFigurePlugin
{
    public class Command
    {
        ToolStripSplitButton tp;
        ToolStripSplitButton wdth;
        ToolStripSplitButton clr;
        ToolStripSeparator sel;
        pProperty pr;
        bool isExist = false;
        public void ChangeColor()
        {
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {

            }
        }
        public void ChangeType(String type)
        {

        }
        public void ChangeWidth(int width)
        {

        }
        public void AddMenu(ToolStrip stripMenu, GroupBox property)
        {
            if (isExist)
                return;
            sel = new ToolStripSeparator();
            tp = new ToolStripSplitButton("Type");
            tp.DropDownItems.Add(new ToolStripMenuItem("Rectangle", null, delegate { ChangeType("Rectangle"); }));
            tp.DropDownItems.Add(new ToolStripMenuItem("Ellipse", null, delegate { ChangeType("Ellipse"); }));
            tp.DropDownItems.Add(new ToolStripMenuItem("Line", null, delegate { ChangeType("Line"); }));
            tp.DropDownItems.Add(new ToolStripMenuItem("RoundRect", null, delegate { ChangeType("RoundRect"); }));
            clr = new ToolStripSplitButton("Color", null, delegate { ChangeColor(); });
            wdth = new ToolStripSplitButton("Width");
            wdth.DropDownItems.Add(new ToolStripMenuItem("1", null, delegate { ChangeWidth(1); }));
            wdth.DropDownItems.Add(new ToolStripMenuItem("3", null, delegate { ChangeWidth(3); }));
            wdth.DropDownItems.Add(new ToolStripMenuItem("5", null, delegate { ChangeWidth(5); }));
            wdth.DropDownItems.Add(new ToolStripMenuItem("7", null, delegate { ChangeWidth(7); }));
            wdth.DropDownItems.Add(new ToolStripMenuItem("10", null, delegate { ChangeWidth(10); }));
            wdth.DropDownItems.Add(new ToolStripMenuItem("15", null, delegate { ChangeWidth(15); }));
            wdth.DropDownItems.Add(new ToolStripMenuItem("20", null, delegate { ChangeWidth(20); }));
            wdth.DropDownItems.Add(new ToolStripMenuItem("25", null, delegate { ChangeWidth(25); }));

            stripMenu.Items.Add(sel);
            stripMenu.Items.Add(wdth);
            stripMenu.Items.Add(tp);
            stripMenu.Items.Add(clr);

            pr = new pProperty();
            property.Controls.Add(pr);
            isExist = true;
        }
        public void DelMenu(ToolStrip stripMenu, GroupBox property)
        {
            stripMenu.Items.Remove(sel);
            stripMenu.Items.Remove(tp);
            stripMenu.Items.Remove(wdth);
            stripMenu.Items.Remove(clr);
            property.Controls.Remove(pr);
            isExist = false;
        }
    }
}
