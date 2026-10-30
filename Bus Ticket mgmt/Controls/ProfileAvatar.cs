using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bus_Ticket_mgmt
{
    /// <summary>
    /// Avatar circular picture display.
    /// </summary>
    public class ProfileAvatar : Control
    {
        public ProfileAvatar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            this.Size = new Size(68, 68);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle circleRect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            using (SolidBrush circleBrush = new SolidBrush(Color.FromArgb(219, 234, 254))) // #DBEAFE
            {
                g.FillEllipse(circleBrush, circleRect);
            }

            Color silhouette = Color.FromArgb(30, 58, 138); // #1E3A8A
            using (SolidBrush brush = new SolidBrush(silhouette))
            {
                int cx = this.Width / 2;
                int cy = this.Height / 2;

                g.FillEllipse(brush, cx - 11, cy - 16, 22, 22);

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(circleRect);
                    g.SetClip(path);
                    g.FillEllipse(brush, cx - 19, cy + 9, 38, 28);
                    g.ResetClip();
                }
            }
        }
    }
}

