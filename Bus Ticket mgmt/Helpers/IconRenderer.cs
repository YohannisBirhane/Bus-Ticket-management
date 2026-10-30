using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Bus_Ticket_mgmt
{
    /// <summary>
    /// Utility for drawing custom vector icons across title bars and navigation elements.
    /// </summary>
    public static class IconRenderer
    {
        public static void DrawBusIcon(Graphics g, int x, int y, int size, Color color)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(color, 1.8f))
            using (SolidBrush brush = new SolidBrush(color))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;

                Rectangle busBody = new Rectangle(x, y + 2, size, (int)(size * 0.75f));
                using (GraphicsPath bPath = CardPanel.GetRoundedRectanglePath(busBody, 3))
                {
                    g.DrawPath(pen, bPath);
                }

                int wH = (int)(busBody.Height * 0.42f);
                Rectangle winRect = new Rectangle(busBody.X + 2, busBody.Y + 3, busBody.Width - 4, wH);
                using (GraphicsPath wPath = CardPanel.GetRoundedRectanglePath(winRect, 2))
                {
                    g.DrawPath(pen, wPath);
                }

                int wheelSize = (int)(size * 0.22f);
                g.FillEllipse(brush, busBody.X + 3, busBody.Bottom - wheelSize / 2, wheelSize, wheelSize);
                g.FillEllipse(brush, busBody.Right - 3 - wheelSize, busBody.Bottom - wheelSize / 2, wheelSize, wheelSize);
            }
        }

        public static void DrawHeadphoneIcon(Graphics g, int x, int y, Color color)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(color, 1.8f))
            using (SolidBrush brush = new SolidBrush(color))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;

                g.DrawArc(pen, x, y, 16, 15, 180, 180);
                Rectangle leftEar = new Rectangle(x, y + 7, 4, 8);
                Rectangle rightEar = new Rectangle(x + 12, y + 7, 4, 8);
                using (GraphicsPath lp = CardPanel.GetRoundedRectanglePath(leftEar, 2))
                using (GraphicsPath rp = CardPanel.GetRoundedRectanglePath(rightEar, 2))
                {
                    g.FillPath(brush, lp);
                    g.FillPath(brush, rp);
                }
            }
        }

        public static void DrawMailIcon(Graphics g, int x, int y, Color color)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(color, 1.8f))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;

                Rectangle rect = new Rectangle(x, y + 1, 18, 13);
                using (GraphicsPath path = CardPanel.GetRoundedRectanglePath(rect, 2))
                {
                    g.DrawPath(pen, path);
                }
                g.DrawLine(pen, x + 1, y + 2, x + 9, y + 8);
                g.DrawLine(pen, x + 17, y + 2, x + 9, y + 8);
            }
        }

        public static void DrawPhoneIcon(Graphics g, int x, int y, Color color)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(color, 1.8f))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;

                g.DrawArc(pen, x + 2, y, 14, 14, 210, 80);
                g.DrawLine(pen, x + 4, y + 10, x + 2, y + 14);
                g.DrawLine(pen, x + 12, y + 2, x + 16, y + 4);
            }
        }
    }
}

