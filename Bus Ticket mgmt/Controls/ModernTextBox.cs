using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bus_Ticket_mgmt
{
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
}

