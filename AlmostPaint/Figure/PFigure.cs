using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using AlmostPaint.Controls;

namespace AlmostPaint.Figure
{
    public partial class PFigure : UserControl
    {
        public enum FigureKeyPoint
        {
            none,
            topLeft, top, topRight, right,
            bottomRight, bottom, bottomLeft, left
        };

        private bool isMoving = false;
        private bool isResizing = false;
        private Point startPoint;
        private FigureKeyPoint figureKeyPoint;

        private Color _color;
        private int _lineWidth;
        public int _type;

        public Color Color { set { _color = value; Invalidate(); } }
        public int LineWidth { set { _lineWidth = value; Invalidate(); } }
        public int Type { set { _type = value; Invalidate(); } }

        public PFigure(MFigure mFigure)
        {
            InitializeComponent();

            Left = mFigure.x;
            Top = mFigure.y;
            Width = mFigure.w;
            Height = mFigure.h;

            _color = Color.FromArgb(mFigure.color);
            _type = mFigure.type;
            _lineWidth = mFigure.lineWidth;
        }

        public MFigure GetMemento()
        {
            MFigure memento = new MFigure();
            memento.x = Left;
            memento.y = Top;
            memento.w = Width;
            memento.h = Height;

            memento.color = _color.ToArgb();
            memento.lineWidth = _lineWidth;
            memento.type = _type;

            return memento;
        }

        public PFigure(int x, int y, XData xData)
        {
            InitializeComponent();
            Location = new Point(x, y);
            Color = xData.color;
            _lineWidth = xData.lineWidth;
            _type = xData.type;

        }

        private void PFigure_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen pen = new Pen(_color, _lineWidth);
            if (_type == 1)
                g.DrawRectangle(pen, new Rectangle(_lineWidth / 2, _lineWidth / 2, Width - _lineWidth, Height - _lineWidth));
            else if (_type == 2)
                g.DrawEllipse(pen, new Rectangle(_lineWidth / 2, _lineWidth / 2, Width - _lineWidth, Height - _lineWidth));
            else if (_type == 3)
                g.DrawLine(pen, 0, 0, Width, Height);
            else if (_type == 4)
            {
                GraphicsPath path = new GraphicsPath();
                Rectangle bounds = new Rectangle(_lineWidth / 2, _lineWidth / 2, Width - 1, Height - 1);
                Size size = new Size(20, 20);
                Rectangle arc = new Rectangle(bounds.Location, size);
                path.AddArc(arc, 180, 90);
                arc.X = bounds.Right - 20;
                path.AddArc(arc, 270, 90);
                arc.Y = bounds.Bottom - 20;
                path.AddArc(arc, 0, 90);
                arc.X = bounds.Left;
                path.AddArc(arc, 90, 90);
                arc.Y = bounds.Top;
                path.CloseFigure();
                g.DrawPath(pen, path);
            }
        }



        private void PFigure_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                figureKeyPoint = GetResizePoint(e.X, e.Y);
                isMoving = (figureKeyPoint == FigureKeyPoint.none);
                isResizing = (figureKeyPoint != FigureKeyPoint.none);
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void PFigure_MouseEnter(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }

        private void PFigure_MouseLeave(object sender, EventArgs e)
        {
            if (Focused == false)
                BorderStyle = BorderStyle.None;
        }

        private void PFigure_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor[] cursors = { Cursors.Default,
                Cursors.SizeNWSE, Cursors.SizeNS, Cursors.SizeNESW, Cursors.SizeWE,
                Cursors.SizeNWSE, Cursors.SizeNS, Cursors.SizeNESW, Cursors.SizeWE
            };

            if (figureKeyPoint == FigureKeyPoint.none)
                Cursor.Current = cursors[(int)GetResizePoint(e.X, e.Y)];
            else
                Cursor.Current = cursors[(int)figureKeyPoint];

            if (e.Button == MouseButtons.Left)
            {
                if (isMoving == true)
                    Move(e.X - startPoint.X, e.Y - startPoint.Y);
                else if (isResizing == true)
                    Resize(figureKeyPoint, e.X, e.Y);
            }
        }

        private void PFigure_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
            isResizing = false;
            figureKeyPoint = FigureKeyPoint.none;
        }

        private void PFigure_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void PFigure_Enter(object sender, EventArgs e)
        {
            (Parent as PDraw).currentFigure = this;
            BorderStyle = BorderStyle.FixedSingle;
        }

        private void PFigure_Leave(object sender, EventArgs e)
        {
            (Parent as PDraw).currentFigure = null;
            BorderStyle = BorderStyle.None;
        }

        public FigureKeyPoint GetResizePoint(int x, int y)
        {
            FigureKeyPoint result = FigureKeyPoint.none;
            int padding = 10;

            if (x > Width - padding)
            {
                if (y < padding)
                    result = FigureKeyPoint.topRight;
                else if (y > Height - padding)
                    result = FigureKeyPoint.bottomRight;
                else
                    result = FigureKeyPoint.right;
            }
            else if (x < padding)
            {
                if (y < padding)
                    result = FigureKeyPoint.topLeft;
                else if (y > Height - padding)
                    result = FigureKeyPoint.bottomLeft;
                else
                    result = FigureKeyPoint.left;
            }
            else
            {
                if (y < padding)
                    result = FigureKeyPoint.top;
                else if (y > Height - padding)
                    result = FigureKeyPoint.bottom;
            }

            return result;
        }

        public new void Move(int dx, int dy)
        {
            Left += dx;
            Top += dy;
        }

        public new void Resize(FigureKeyPoint resizePoint, int dx, int dy)
        {
            if (resizePoint == FigureKeyPoint.right)
            {
                Width = dx;
            }
            else if (resizePoint == FigureKeyPoint.left)
            {
                Width -= dx;
                Left += dx;
            }
            else if (resizePoint == FigureKeyPoint.topLeft)
            {
                Width -= dx;
                Left += dx;
                Height -= dy;
                Top += dy;
            }
            else if (resizePoint == FigureKeyPoint.bottomRight)
            {
                Width = dx;
                Height = dy;
            }

            Invalidate();
        }

        private void PFigure_Click(object sender, EventArgs e)
        {
            if (this.Focused)
            {
            }
            else
            {
                Focus();
            }

        }

        private void PFigure_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Height = 0;
            Width = 0;
        }
    }
}
