using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlmostPaint.Figure;

namespace AlmostPaint.Controls
{
    public partial class PDraw : UserControl
    {
        private XCommand _xCommand = null;
        public XCommand XCommand { set { _xCommand = value; } }

        public List<PFigure> pFigures = null;
        public PFigure currentFigure = null;

        private PFigure newFigure = null;
        private Point clickPoint;
        public PDraw()
        {
            InitializeComponent();
        }

        private void PDraw_MouseDown(object sender, MouseEventArgs e)
        {
            clickPoint = new Point(e.X, e.Y);
            newFigure = new PFigure(e.X, e.Y, _xCommand.xData);
            Controls.Add(newFigure);
            newFigure.BringToFront();
        }

        private void PDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (newFigure != null)
            {
                newFigure.Resize(newFigure.GetResizePoint(e.X, e.Y), e.X - clickPoint.X, e.Y - clickPoint.Y);
            }
        }

        private void PDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (newFigure != null)
            {
                pFigures.Add(newFigure);
                newFigure = null;
            }
        }

        public List<MFigure> GetMemento()
        {
            List<MFigure> res = new List<MFigure>();
            foreach (PFigure figure in pFigures)
            {
                res.Add(figure.GetMemento());
            }
            return res;
        }

        internal void SetMemento(List<MFigure> list)
        {
            Controls.Clear();
            pFigures.Clear();

            foreach (var figure in list)
            {
                PFigure f = new PFigure(figure);
                Controls.Add(f);
                pFigures.Add(f);
                f.BringToFront();
            }
        }
    }
}
