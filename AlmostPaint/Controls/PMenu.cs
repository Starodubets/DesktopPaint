using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlmostPaint.Windows;
using AlmostPaint.Serialization;

namespace AlmostPaint.Controls
{
    public partial class PMenu : UserControl
    {
        public XCommand xCommand = null;
        public PMenu()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilites.SaveAction(Serializer.toJson(xCommand.GetMemento()));
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xCommand.SetMemento(Serializer.fromJson(Utilites.LoadAction()));
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xCommand.SetFigureType(1);
        }

        private void rRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xCommand.SetFigureType(2);
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xCommand.SetFigureType(3);
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xCommand.SetFigureType(4);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xCommand.SetColor(Utilites.GetColor());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            xCommand.SetLineWidth(Convert.ToInt32(toolStripMenuItem2.Text));
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            xCommand.SetLineWidth(Convert.ToInt32(toolStripMenuItem3.Text));
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            xCommand.SetLineWidth(Convert.ToInt32(toolStripMenuItem4.Text));
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            xCommand.SetLineWidth(Convert.ToInt32(toolStripMenuItem5.Text));
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            xCommand.SetLineWidth(Convert.ToInt32(toolStripMenuItem6.Text));
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            xCommand.SetLineWidth(Convert.ToInt32(toolStripMenuItem7.Text));
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            xCommand.SetText(toolStripTextBox1.Text);
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void showPluginSelectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xCommand.PluginShow();
        }

        private void openGroupSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWindow av = new AboutWindow();
            av.Show();
        }

        private void addNewTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xCommand.AddNewTab();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editFigureToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xCommand.ThemeChange();
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xCommand.ThemeChange();
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xCommand.LanguageChange();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xCommand.LanguageChange();
        }

        private void switchTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xCommand.SwitchTab();
        }

        private void removeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xCommand.CloseTab();
        }

        private void renameCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xCommand.RenameTab();
        }

        private void closePluginSelectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xCommand.PluginClosed();
        }
    }
}
