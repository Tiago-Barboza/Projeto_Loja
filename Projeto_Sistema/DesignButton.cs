using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Projeto_Sistema.Classes
{
    public class DesignButton : Button
    {
        private int BorderSize = 0;
        private int BorderRadius = 30;
        private Color BorderColor = Color.PaleVioletRed;

        public DesignButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 30);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF RectSurface = new RectangleF(0,0,this.Width,this.Height);
            RectangleF RectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (BorderRadius > 2)
            {
                using (GraphicsPath PathSurface = GetFigurePath(RectSurface, BorderRadius)) 
                using (GraphicsPath PathBorder = GetFigurePath(RectBorder, BorderRadius - 1F)) 
                using (Pen PenSurface = new Pen(this.Parent.BackColor, 2)) 
                using (Pen PenBorder = new Pen(BorderColor, BorderSize))
                {
                    PenBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(PathSurface);
                    pevent.Graphics.DrawPath(PenSurface, PathSurface);

                    if (BorderSize >= 1)
                    {
                        pevent.Graphics.DrawPath(PenBorder, PathBorder);
                    }
                }
            }
            else
            {
                this.Region = new Region(RectSurface);
                if (BorderSize >= 1)
                {
                    using (Pen PenBorder = new Pen(BorderColor, BorderSize))
                    {
                        PenBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(PenBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}
