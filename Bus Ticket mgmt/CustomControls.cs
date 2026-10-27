using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Bus_Ticket_mgmt
{
    public enum InputIconType
    {
        None,
        User,
        Lock,
        Email,
        Phone
    }

    public enum ButtonIconType
    {
        None,
        Login,
        GuestUser,
        Register
    }

    /// <summary>
    /// Modern rounded text box with leading icon, placeholder, and optional password reveal toggle.
    /// </summary>
    public class ModernTextBox : UserControl
    {
        private TextBox innerTextBox;
        private bool isPassword = false;
        private bool passwordVisible = false;
        private string placeholderText = "";
        private InputIconType iconType = InputIconType.None;
        private bool isHovered = false;
        private bool isFocused = false;

        private Color borderColor = Color.FromArgb(203, 213, 225); // #CBD5E1
        private Color focusBorderColor = Color.FromArgb(13, 94, 234); // #0D5EEA
        private Color placeholderColor = Color.FromArgb(148, 163, 184); // #94A3B8
        private Color textColor = Color.FromArgb(15, 23, 42); // #0F172A

        public event EventHandler? TextChangedCustom;

        public ModernTextBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            this.BackColor = Color.White;

            innerTextBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                BackColor = Color.White,
                ForeColor = placeholderColor,
                Font = new Font("Segoe UI", 10.5f, FontStyle.Regular),
                Location = new Point(44, 11),
                Width = 220,
                Text = ""
            };

            innerTextBox.Enter += InnerTextBox_Enter;
            innerTextBox.Leave += InnerTextBox_Leave;
            innerTextBox.TextChanged += InnerTextBox_TextChanged;
            innerTextBox.KeyDown += (s, e) => { OnKeyDown(e); };

            this.Controls.Add(innerTextBox);

            this.Size = new Size(360, 44);

            this.MouseEnter += (s, e) => { isHovered = true; Invalidate(); };
            this.MouseLeave += (s, e) => { isHovered = false; Invalidate(); };
            this.MouseDown += (s, e) => { innerTextBox.Focus(); };
            this.Click += (s, e) => { innerTextBox.Focus(); };
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string InputText
        {
            get => (innerTextBox == null || (innerTextBox.Text == placeholderText && innerTextBox.ForeColor == placeholderColor)) ? "" : innerTextBox.Text;
            set
            {
                if (innerTextBox == null) return;
                if (string.IsNullOrEmpty(value))
                {
                    SetPlaceholderMode();
                }
                else
                {
                    innerTextBox.Text = value;
                    innerTextBox.ForeColor = textColor;
                    if (isPassword && !passwordVisible)
                        innerTextBox.UseSystemPasswordChar = true;
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PlaceholderText
        {
            get => placeholderText;
            set
            {
                placeholderText = value;
                if (innerTextBox != null && (string.IsNullOrEmpty(innerTextBox.Text) || innerTextBox.Text == placeholderText))
                {
                    SetPlaceholderMode();
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsPassword
        {
            get => isPassword;
            set
            {
                isPassword = value;
                if (innerTextBox != null && isPassword && innerTextBox.ForeColor != placeholderColor)
                {
                    innerTextBox.UseSystemPasswordChar = !passwordVisible;
                }
                Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public InputIconType IconType
        {
            get => iconType;
            set { iconType = value; Invalidate(); }
        }

        private void SetPlaceholderMode()
        {
            if (innerTextBox == null) return;
            innerTextBox.UseSystemPasswordChar = false;
            innerTextBox.Text = placeholderText;
            innerTextBox.ForeColor = placeholderColor;
        }

        private void InnerTextBox_Enter(object? sender, EventArgs e)
        {
            if (innerTextBox == null) return;
            isFocused = true;
            if (innerTextBox.Text == placeholderText && innerTextBox.ForeColor == placeholderColor)
            {
                innerTextBox.Text = "";
                innerTextBox.ForeColor = textColor;
                if (isPassword && !passwordVisible)
                {
                    innerTextBox.UseSystemPasswordChar = true;
                }
            }
            Invalidate();
        }

        private void InnerTextBox_Leave(object? sender, EventArgs e)
        {
            if (innerTextBox == null) return;
            isFocused = false;
            if (string.IsNullOrWhiteSpace(innerTextBox.Text))
            {
                SetPlaceholderMode();
            }
            Invalidate();
        }

        private void InnerTextBox_TextChanged(object? sender, EventArgs e)
        {
            TextChangedCustom?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (innerTextBox == null) return;
            int rightMargin = isPassword ? 44 : 14;
            innerTextBox.Location = new Point(44, (this.Height - innerTextBox.PreferredHeight) / 2);
            innerTextBox.Width = Math.Max(20, this.Width - 44 - rightMargin);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (isPassword && innerTextBox != null)
            {
                Rectangle eyeRect = new Rectangle(this.Width - 38, (this.Height - 24) / 2, 28, 24);
                if (eyeRect.Contains(e.Location))
                {
                    passwordVisible = !passwordVisible;
                    if (innerTextBox.ForeColor != placeholderColor)
                    {
                        innerTextBox.UseSystemPasswordChar = !passwordVisible;
                    }
                    Invalidate();
                    innerTextBox.Focus();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = 8;
            Rectangle rect = new Rectangle(1, 1, this.Width - 3, this.Height - 3);
            using (GraphicsPath path = CardPanel.GetRoundedRectanglePath(rect, radius))
            {
                using (SolidBrush bgBrush = new SolidBrush(Color.White))
                {
                    g.FillPath(bgBrush, path);
                }

                Color currentBorder = isFocused ? focusBorderColor : (isHovered ? Color.FromArgb(148, 163, 184) : borderColor);
                float borderWidth = isFocused ? 1.8f : 1.2f;
                using (Pen borderPen = new Pen(currentBorder, borderWidth))
                {
                    g.DrawPath(borderPen, path);
                }
            }

            DrawLeadingIcon(g);

            if (isPassword)
            {
                DrawEyeIcon(g);
            }
        }

        private void DrawLeadingIcon(Graphics g)
        {
            Color iconColor = isFocused ? focusBorderColor : Color.FromArgb(148, 163, 184);
            using (Pen pen = new Pen(iconColor, 1.8f))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;

                if (iconType == InputIconType.User)
                {
                    int cx = 22;
                    int cy = this.Height / 2 - 2;
                    g.DrawEllipse(pen, cx - 4, cy - 6, 8, 8);
                    g.DrawArc(pen, cx - 8, cy + 4, 16, 10, 180, 180);
                }
                else if (iconType == InputIconType.Lock)
                {
                    int cx = 22;
                    int cy = this.Height / 2;
                    Rectangle body = new Rectangle(cx - 7, cy - 2, 14, 12);
                    using (GraphicsPath bPath = CardPanel.GetRoundedRectanglePath(body, 2))
                    {
                        g.DrawPath(pen, bPath);
                    }
                    g.DrawArc(pen, cx - 4, cy - 9, 8, 8, 180, 180);
                    using (SolidBrush dotBrush = new SolidBrush(iconColor))
                    {
                        g.FillEllipse(dotBrush, cx - 1, cy + 2, 2, 2);
                        g.FillRectangle(dotBrush, cx - 1, cy + 3, 2, 3);
                    }
                }
                else if (iconType == InputIconType.Email)
                {
                    int cx = 13;
                    int cy = this.Height / 2 - 6;
                    Rectangle rect = new Rectangle(cx, cy, 18, 12);
                    using (GraphicsPath mPath = CardPanel.GetRoundedRectanglePath(rect, 2))
                    {
                        g.DrawPath(pen, mPath);
                    }
                    g.DrawLine(pen, cx + 1, cy + 2, cx + 9, cy + 7);
                    g.DrawLine(pen, cx + 17, cy + 2, cx + 9, cy + 7);
                }
                else if (iconType == InputIconType.Phone)
                {
                    int cx = 14;
                    int cy = this.Height / 2 - 7;
                    g.DrawArc(pen, cx + 2, cy, 13, 13, 210, 80);
                    g.DrawLine(pen, cx + 4, cy + 9, cx + 2, cy + 13);
                    g.DrawLine(pen, cx + 11, cy + 2, cx + 15, cy + 4);
                }
            }
        }

        private void DrawEyeIcon(Graphics g)
        {
            int cx = this.Width - 24;
            int cy = this.Height / 2;
            Color eyeColor = passwordVisible ? focusBorderColor : Color.FromArgb(148, 163, 184);

            using (Pen pen = new Pen(eyeColor, 1.6f))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;

                g.DrawArc(pen, cx - 9, cy - 5, 18, 10, 0, 180);
                g.DrawArc(pen, cx - 9, cy - 5, 18, 10, 180, 180);

                using (SolidBrush pupilBrush = new SolidBrush(eyeColor))
                {
                    g.FillEllipse(pupilBrush, cx - 2.5f, cy - 2.5f, 5, 5);
                }

                if (!passwordVisible)
                {
                    g.DrawLine(pen, cx - 7, cy - 5, cx + 7, cy + 5);
                }
            }
        }
    }

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

    /// <summary>
    /// Rounded container panel for the login card.
    /// </summary>
    public class CardPanel : Panel
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BorderRadius { get; set; } = 16;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor { get; set; } = Color.FromArgb(226, 232, 240); // #E2E8F0

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float BorderWidth { get; set; } = 1f;

        public CardPanel()
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

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            using (GraphicsPath path = GetRoundedRectanglePath(rect, BorderRadius))
            {
                using (SolidBrush bgBrush = new SolidBrush(this.BackColor))
                {
                    g.FillPath(bgBrush, path);
                }

                if (BorderWidth > 0)
                {
                    using (Pen pen = new Pen(BorderColor, BorderWidth))
                    {
                        g.DrawPath(pen, path);
                    }
                }
            }
        }

        public static GraphicsPath GetRoundedRectanglePath(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            Rectangle arc = new Rectangle(bounds.Location, new Size(diameter, diameter));

            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }

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

    /// <summary>
    /// Utility for drawing vector icons in title and footer bars.
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

    /// <summary>
    /// Utility for smooth frameless window dragging.
    /// </summary>
    public static class WindowHelper
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public static void DragForm(IntPtr handle)
        {
            ReleaseCapture();
            SendMessage(handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
