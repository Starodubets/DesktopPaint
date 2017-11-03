using AlmostPaint.Figure;
using AlmostPaint.Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmostPaint
{
    public partial class Form1 : Form
    {
        private PluginManager pm = new PluginManager();
        public Form1()
        {
            InitializeComponent();

            XCommand xCommand = new XCommand();
            List<PFigure> pFigures = new List<PFigure>();

            pDraw1.pFigures = pFigures;
            pDraw1.XCommand = xCommand;
            xCommand.pDraw = pDraw1;

            pMenu1.xCommand = xCommand;

            pm.ScanPlugins(AppDomain.CurrentDomain.BaseDirectory + "\\Plugins\\");

            //создаем меню плагинов
            ToolStripMenuItem mi = new ToolStripMenuItem("Plugins");
            pMenu1.menuStrip1.Items.Add(mi);

            //перебираем плагины, создаем пункт меню для каждого
            foreach (var plugin in pm.Plugins)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(plugin.Name);
                mi.DropDownItems.Add(item);
                item.Click += delegate { plugin.Run(pMenu1.menuStrip1, pToolBox1.toolStrip1 , item, pPlugin1.groupBox1, pProperty1.groupBox1); };//при клике на меню, запускаем плагин на выполнение
                item.CheckState = CheckState.Unchecked;
            }

        }
        
    }
}
