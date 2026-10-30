using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bus_Ticket_mgmt
{
    /// <summary>
    /// Modern styled button with custom rounded corners, icons, and hover animations.
    /// </summary>
    public class ModernButton : Button
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color NormalColor { get; set; } = Color.FromArgb(13, 94, 234); // #0D5EEA

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color HoverColor { get; set; } = Color.FromArgb(11, 79, 196);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color PressedColor { get; set; } = Color.FromArgb(9, 66, 166);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderLineColor { get; set; } = Color.Transparent;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float BorderSize { get; set; } = 0f;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BorderRadius { get; set; } = 8;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ButtonIconType ButtonIcon { get; set; } = ButtonIconType.None;

        private bool isHovered = false;
        private bool isPressed = false;

        public ModernButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Cursor = Cursors.Hand;
            this.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            this.ForeColor = Color.White;
            this.Size = new Size(360, 44);

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            MouseEnter += (s, e) => { isHovered = true; Invalidate(); };
            MouseLeave += (s, e) => { isHovered = false; isPressed = false; Invalidate(); };
            MouseDown += (s, e) => { isPressed = true; Invalidate(); };
            MouseUp += (s, e) => { isPressed = false; Invalidate(); };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color bg = isPressed ? PressedColor : (isHovered ? HoverColor : NormalColor);
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            using (GraphicsPath path = CardPanel.GetRoundedRectanglePath(rect, BorderRadius))
            {
                using (SolidBrush brush = new SolidBrush(bg))
                {
                    g.FillPath(brush, path);
                }

                if (BorderSize > 0 && BorderLineColor != Color.Transparent)
                {
                    using (Pen pen = new Pen(BorderLineColor, BorderSize))
                    {
                        g.DrawPath(pen, path);
                    }
                }
            }

            DrawButtonContent(g);
        }

        private void DrawButtonContent(Graphics g)
        {
            string text = this.Text;
            SizeF textSize = g.MeasureString(text, this.Font);
            int iconWidth = (ButtonIcon != ButtonIconType.None) ? 24 : 0;
            int totalContentWidth = (int)textSize.Width + iconWidth;
            int startX = (this.Width - totalContentWidth) / 2;
            int textY = (this.Height - (int)textSize.Height) / 2;

            int iconX = startX;
            int currentTextX = startX;

            if (ButtonIcon != ButtonIconType.None)
            {
                currentTextX = startX + iconWidth + 4;
                DrawIcon(g, iconX, this.Height / 2);
            }

            using (SolidBrush textBrush = new SolidBrush(this.ForeColor))
            {
                g.DrawString(text, this.Font, textBrush, currentTextX, textY);
            }
        }

        private void DrawIcon(Graphics g, int x, int centerY)
        {
            using (Pen pen = new Pen(this.ForeColor, 2f))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;

                if (ButtonIcon == ButtonIconType.Login)
                {
                    int bx = x + 3;
                    g.DrawLine(pen, bx + 7, centerY - 8, bx + 13, centerY - 8);
                    g.DrawLine(pen, bx + 13, centerY - 8, bx + 13, centerY + 8);
                    g.DrawLine(pen, bx + 13, centerY + 8, bx + 7, centerY + 8);

                    g.DrawLine(pen, bx, centerY, bx + 9, centerY);
                    g.DrawLine(pen, bx + 6, centerY - 4, bx + 10, centerY);
                    g.DrawLine(pen, bx + 6, centerY + 4, bx + 10, centerY);
                }
                else if (ButtonIcon == ButtonIconType.GuestUser)
                {
                    int cx = x + 8;
                    g.DrawEllipse(pen, cx - 4, centerY - 7, 8, 8);
                    g.DrawArc(pen, cx - 7, centerY + 2, 14, 9, 180, 180);
                }
                else if (ButtonIcon == ButtonIconType.Register)
                {
                    int cx = x + 6;
                    g.DrawEllipse(pen, cx - 3, centerY - 6, 7, 7);
                    g.DrawArc(pen, cx - 6, centerY + 2, 12, 8, 180, 180);
                    g.DrawLine(pen, cx + 8, centerY - 2, cx + 8, centerY + 4);
                    g.DrawLine(pen, cx + 5, centerY + 1, cx + 11, centerY + 1);
                }
            }
        }
    }
}

