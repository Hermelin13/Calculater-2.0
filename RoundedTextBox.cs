using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public class RoundedTextBox : TextBox
    {
        private int _borderRadius = 30;
        public int BorderRadius
        {
            get { return _borderRadius; }
            set { _borderRadius = value; this.Invalidate(); }
        }

        private GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            // Top left arc
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            // Top border
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            // Top right arc
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            // Right border
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height);
            // Bottom border
            GraphPath.AddLine(Rect.Width, Rect.Height, Rect.X, Rect.Height);
            // Left border
            GraphPath.AddLine(Rect.X, Rect.Height, Rect.X, Rect.Y + r2);

            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rect, BorderRadius * 2);

            this.Region = new Region(GraphPath);

            using (Pen pen = new Pen(Color.Black, 1.75f))
            {
                e.Graphics.DrawPath(pen, GraphPath);
            }
        }
    }
}
