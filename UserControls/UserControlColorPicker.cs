using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using UserControl = System.Windows.Forms.UserControl;
using System.Configuration;
using System.Collections.Specialized;
using System.Diagnostics;
using UtilitySharp.Entities;
using UtilitySharp.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;
using LinearGradientBrush = System.Drawing.Drawing2D.LinearGradientBrush;

namespace UtilitySharp.UserControls
{
    public partial class UserControlColorPicker : UserControl
    {
        public static UserControlColorPicker instance;
        public string value;

        private Bitmap _canvas;
        private Graphics _graphicsBuffer;
        private LinearGradientBrush _lgbSpectrum, _lgbFade;
        public Color selectedColor;
        private bool mouseIsPressed = false;


        public UserControlColorPicker(string _value)
        {
            instance = this;

            InitializeComponent();

            value = _value;

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
            
            UpdateBackBuffer();
            UpdateGradiient();
        }


        private void UserControlColorPicker_Load(object sender, EventArgs e)
        {

        }

        public void OnColorPicked()
        {
            colorPreview.BackColor = selectedColor;
            SettingsForm.instance.UpdateColorsPreview(selectedColor, value);

            switch (value)
            {
                case "Color":
                    SettingsForm.controlsColor = selectedColor;
                    break;
                case "HighlightedColor":
                    SettingsForm.highlightedColor = selectedColor;
                    break;
                case "BackColor":
                    SettingsForm.backColor = selectedColor;
                    break;
                case "ControlFontColor":
                    SettingsForm.controlsFontColor = selectedColor;
                    break;
                case "BackFontColor":
                    SettingsForm.backFontColor = selectedColor;
                    break;
                default:
                    break;
            }
        }


        private void UpdateBackBuffer()
        {
            if(!this.Width.Equals(0))
            {
                _canvas = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
                _graphicsBuffer = Graphics.FromImage(_canvas);
            }
        }

        private void UpdateGradiient()
        {
            _lgbSpectrum = new LinearGradientBrush(Point.Empty, new Point(this.ClientSize.Width, 0), Color.Wheat, Color.Wheat);
            ColorBlend spectrumBlend = new ColorBlend();
            spectrumBlend.Colors = new Color[] { Color.Red, Color.Green, Color.Blue };
            spectrumBlend.Positions = new float[] { 0, 0.5f, 1f };
            _lgbSpectrum.InterpolationColors = spectrumBlend;

            _lgbFade = new LinearGradientBrush(this.ClientRectangle, Color.White, Color.White, 90f);
            ColorBlend fadeBlend = new ColorBlend();
            fadeBlend.Colors = new Color[] { Color.Black, Color.Transparent, Color.White };
            fadeBlend.Positions = new float[] { 0, 0.5f, 1f };
            _lgbFade.InterpolationColors = fadeBlend;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            UpdateBackBuffer();
            UpdateGradiient();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            _graphicsBuffer.FillRectangle(_lgbSpectrum, this.ClientRectangle);
            _graphicsBuffer.FillRectangle(_lgbFade, this.ClientRectangle);
            e.Graphics.DrawImageUnscaled(_canvas, Point.Empty);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            mouseIsPressed = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            mouseIsPressed = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if(mouseIsPressed)
            {
                Point pos = this.PointToClient(Cursor.Position);
                if (pos.X > 0 && pos.Y > 0 && pos.X < this.Width && pos.Y < this.Height)
                {
                    selectedColor = _canvas.GetPixel(pos.X, pos.Y);
                    OnColorPicked();
                }
            }
        }

        private void colorPreview_Paint(object sender, PaintEventArgs e)
        {

        }

        public Color SelectedColor
        {
            get { return selectedColor; }
        }
    }
}
