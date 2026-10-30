using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Bus_Ticket_mgmt
{
    /// <summary>
    /// Main split panel that renders the curved bus image on the left, typography, and features pill.
    /// </summary>
    public class MainSplitPanel : Panel
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image? BannerImage { get; set; }

        public MainSplitPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            this.BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            int w = this.Width;
            int h = this.Height;

            // Left side takes about 47.5% to 54.5% width in an organic wave curve
            float splitTopX = w * 0.475f;
            float c1X = w * 0.545f;
            float c1Y = h * 0.28f;
            float c2X = w * 0.525f;
            float c2Y = h * 0.70f;
            float splitBottomX = w * 0.425f;

            // 1. Draw Left Image clipped by curve
            using (GraphicsPath clipPath = new GraphicsPath())
            {
                clipPath.AddLine(0, 0, splitTopX, 0);
                clipPath.AddBezier(splitTopX, 0, c1X, c1Y, c2X, c2Y, splitBottomX, h);
                clipPath.AddLine(splitBottomX, h, 0, h);
                clipPath.CloseFigure();

                g.SetClip(clipPath);

                if (BannerImage != null)
                {
                    float imgRatio = (float)BannerImage.Width / BannerImage.Height;
                    int drawWidth = (int)(h * imgRatio);
                    int drawHeight = h;
                    if (drawWidth < w * 0.55f)
                    {
                        drawWidth = (int)(w * 0.55f);
                        drawHeight = (int)(drawWidth / imgRatio);
                    }

                    int offsetX = 0;
                    int offsetY = (h - drawHeight) / 2;
                    g.DrawImage(BannerImage, new Rectangle(offsetX, offsetY, drawWidth, drawHeight));
                }
                else
                {
                    using (LinearGradientBrush lgb = new LinearGradientBrush(new Rectangle(0, 0, (int)(w * 0.55f), h),
                        Color.FromArgb(14, 165, 233), Color.FromArgb(30, 58, 138), LinearGradientMode.ForwardDiagonal))
                    {
                        g.FillRectangle(lgb, 0, 0, (int)(w * 0.55f), h);
                    }
                }

                g.ResetClip();

                using (Pen curvePen = new Pen(Color.White, 2.5f))
                {
                    g.DrawBezier(curvePen, splitTopX, 0, c1X, c1Y, c2X, c2Y, splitBottomX, h);
                }
            }

            // 2. Draw Left Headline & Subtitle Text
            DrawLeftOverlayText(g);

            // 3. Draw Floating Features Badge at bottom left
            DrawFloatingBadge(g, h);
        }

        private void DrawLeftOverlayText(Graphics g)
        {
            int startX = 48;
            int startY = 56;

            using (Font titleFont = new Font("Segoe UI", 31f, FontStyle.Bold))
            using (SolidBrush titleBrush = new SolidBrush(Color.FromArgb(16, 42, 67))) // #102A43
            {
                g.DrawString("Your Journey,", titleFont, titleBrush, startX, startY);
                g.DrawString("Our Priority", titleFont, titleBrush, startX, startY + 48);
            }

            using (SolidBrush barBrush = new SolidBrush(Color.FromArgb(13, 94, 234))) // #0D5EEA
            {
                Rectangle barRect = new Rectangle(startX, startY + 110, 48, 4);
                using (GraphicsPath barPath = CardPanel.GetRoundedRectanglePath(barRect, 2))
                {
                    g.FillPath(barBrush, barPath);
                }
            }

            using (Font subFont = new Font("Segoe UI", 11.5f, FontStyle.Regular))
            using (SolidBrush subBrush = new SolidBrush(Color.FromArgb(30, 41, 59))) // #1E293B
            {
                string subtitle = "Book bus tickets across Ethiopia easily,\nquickly, and securely.";
                g.DrawString(subtitle, subFont, subBrush, startX, startY + 126);
            }
        }

        private void DrawFloatingBadge(Graphics g, int totalHeight)
        {
            int badgeX = 36;
            int badgeY = totalHeight - 96;
            int badgeW = 380;
            int badgeH = 60;

            Rectangle badgeRect = new Rectangle(badgeX, badgeY, badgeW, badgeH);

            using (GraphicsPath path = CardPanel.GetRoundedRectanglePath(badgeRect, 14))
            {
                using (SolidBrush bgBrush = new SolidBrush(Color.FromArgb(215, 20, 36, 68)))
                {
                    g.FillPath(bgBrush, path);
                }

                using (Pen borderPen = new Pen(Color.FromArgb(45, 255, 255, 255), 1.2f))
                {
                    g.DrawPath(borderPen, path);
                }
            }

            int itemW = badgeW / 3;

            using (Pen divPen = new Pen(Color.FromArgb(50, 255, 255, 255), 1f))
            {
                g.DrawLine(divPen, badgeX + itemW, badgeY + 12, badgeX + itemW, badgeY + badgeH - 12);
                g.DrawLine(divPen, badgeX + itemW * 2, badgeY + 12, badgeX + itemW * 2, badgeY + badgeH - 12);
            }

            using (Font font = new Font("Segoe UI", 8.5f, FontStyle.Bold))
            using (SolidBrush textBrush = new SolidBrush(Color.White))
            using (Pen iconPen = new Pen(Color.White, 1.8f))
            {
                iconPen.StartCap = LineCap.Round;
                iconPen.EndCap = LineCap.Round;

                // Feature 1: Comfortable Seats
                int f1X = badgeX + 10;
                int f1Y = badgeY + badgeH / 2;
                g.DrawArc(iconPen, f1X + 5, f1Y - 14, 10, 10, 180, 180);
                g.DrawLine(iconPen, f1X + 4, f1Y - 9, f1X + 4, f1Y + 3);
                g.DrawLine(iconPen, f1X + 16, f1Y - 9, f1X + 16, f1Y + 3);
                g.DrawLine(iconPen, f1X + 2, f1Y + 3, f1X + 18, f1Y + 3);
                g.DrawLine(iconPen, f1X + 5, f1Y + 3, f1X + 5, f1Y + 10);
                g.DrawLine(iconPen, f1X + 15, f1Y + 3, f1X + 15, f1Y + 10);
                g.DrawString("Comfortable\nSeats", font, textBrush, f1X + 24, badgeY + 13);

                // Feature 2: Safe & Reliable
                int f2X = badgeX + itemW + 10;
                int f2Y = badgeY + badgeH / 2;
                using (GraphicsPath shield = new GraphicsPath())
                {
                    shield.AddLine(f2X + 10, f2Y - 12, f2X + 20, f2Y - 8);
                    shield.AddBezier(f2X + 20, f2Y - 8, f2X + 20, f2Y + 6, f2X + 10, f2Y + 12, f2X + 10, f2Y + 12);
                    shield.AddBezier(f2X + 10, f2Y + 12, f2X + 10, f2Y + 12, f2X, f2Y + 6, f2X, f2Y - 8);
                    shield.CloseFigure();
                    g.DrawPath(iconPen, shield);
                }
                g.DrawLine(iconPen, f2X + 7, f2Y - 1, f2X + 9, f2Y + 2);
                g.DrawLine(iconPen, f2X + 9, f2Y + 2, f2X + 14, f2Y - 3);
                g.DrawString("Safe &\nReliable", font, textBrush, f2X + 24, badgeY + 13);

                // Feature 3: Secure Payment
                int f3X = badgeX + itemW * 2 + 10;
                int f3Y = badgeY + badgeH / 2;
                Rectangle card = new Rectangle(f3X + 2, f3Y - 10, 18, 13);
                using (GraphicsPath cPath = CardPanel.GetRoundedRectanglePath(card, 2))
                {
                    g.DrawPath(iconPen, cPath);
                }
                g.DrawLine(iconPen, f3X + 2, f3Y - 5, f3X + 20, f3Y - 5);
                Rectangle mLock = new Rectangle(f3X + 11, f3Y + 3, 9, 8);
                using (GraphicsPath mlPath = CardPanel.GetRoundedRectanglePath(mLock, 2))
                {
                    using (SolidBrush lockFill = new SolidBrush(Color.FromArgb(215, 20, 36, 68)))
                    {
                        g.FillPath(lockFill, mlPath);
                    }
                    g.DrawPath(iconPen, mlPath);
                }
                g.DrawArc(iconPen, f3X + 13, f3Y - 1, 5, 5, 180, 180);
                g.DrawString("Secure\nPayment", font, textBrush, f3X + 24, badgeY + 13);
            }
        }
    }
}

