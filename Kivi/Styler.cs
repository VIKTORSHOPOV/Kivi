﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kivi
{
    public static class Styler
    {
        public static void Stone(Label label, Color outlineColor, Color fillColor)
        {

            label.AutoSize = false;
            label.Width = 25;
            label.Height = 25;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = "Circle";


            label.Paint += (sender, e) =>
            {

                e.Graphics.Clear(label.BackColor);


                int outlineWidth = 2;
                int adjustedWidth = label.Width - 1 - outlineWidth;
                int adjustedHeight = label.Height - 1 - outlineWidth;


                using (Pen outlinePen = new Pen(outlineColor, outlineWidth))
                using (SolidBrush fillBrush = new SolidBrush(fillColor))
                {
                    e.Graphics.FillEllipse(fillBrush, new Rectangle(0, 0, adjustedWidth, adjustedHeight));
                    e.Graphics.DrawEllipse(outlinePen, new Rectangle(0, 0, adjustedWidth, adjustedHeight));
                }
            };
        }
        public static void ButtonShine(Button button, bool logic, bool clicked)
        {
            if (logic == true && clicked == false)
            {
                button.BackColor = Color.Blue;
                button.FlatStyle = FlatStyle.Flat;
                //button.FlatAppearance.BorderColor = Color.FromArgb(255, 64, 224, 208); //Turquoise
                button.FlatAppearance.BorderColor = Color.Lime;
                button.FlatAppearance.BorderSize = 2;
                button.Enabled = true;
                button.Cursor = Cursors.Hand;

            }
            else
            {
                button.FlatStyle = FlatStyle.Popup;
                button.Enabled = false;
            }
        }

        public static Bitmap HueShift(this Bitmap sourceBitmap, float shift)
        {
            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            for (int x = 0; x < sourceBitmap.Width; x++)
            {
                for (int y = 0; y < sourceBitmap.Height; y++)
                {
                    Color sourceColor = sourceBitmap.GetPixel(x, y);
                    float hue, saturation, lightness;
                    ColorToHSL(sourceColor, out hue, out saturation, out lightness);
                    hue += shift;
                    if (hue > 360)
                        hue -= 360;
                    else if (hue < 0)
                        hue += 360;
                    Color shiftedColor = HSLToColor(hue, saturation, lightness);
                    resultBitmap.SetPixel(x, y, shiftedColor);
                }
            }

            return resultBitmap;
        }

        private static void ColorToHSL(Color color, out float hue, out float saturation, out float lightness)
        {
            float r = color.R / 255f;
            float g = color.G / 255f;
            float b = color.B / 255f;

            float max = Math.Max(r, Math.Max(g, b));
            float min = Math.Min(r, Math.Min(g, b));

            float delta = max - min;

            lightness = (max + min) / 2;

            saturation = 0;
            if (delta != 0)
            {
                saturation = delta / (1 - Math.Abs(2 * lightness - 1));
            }

            hue = 0;
            if (delta != 0)
            {
                if (max == r)
                {
                    hue = 60 * (((g - b) / delta) % 6);
                }
                else if (max == g)
                {
                    hue = 60 * (((b - r) / delta) + 2);
                }
                else if (max == b)
                {
                    hue = 60 * (((r - g) / delta) + 4);
                }
            }
        }
        private static Color HSLToColor(float hue, float saturation, float lightness)
        {
            float c = (1 - Math.Abs(2 * lightness - 1)) * saturation;
            float x = c * (1 - Math.Abs((hue / 60) % 2 - 1));
            float m = lightness - c / 2;

            float r = 0, g = 0, b = 0;
            if (0 <= hue && hue < 60)
            {
                r = c;
                g = x;
                b = 0;
            }
            else if (60 <= hue && hue < 120)
            {
                r = x;
                g = c;
                b = 0;
            }
            else if (120 <= hue && hue < 180)
            {
                r = 0;
                g = c;
                b = x;
            }
            else if (180 <= hue && hue < 240)
            {
                r = 0;
                g = x;
                b = c;
            }
            else if (240 <= hue && hue < 300)
            {
                r = x;
                g = 0;
                b = c;
            }
            else if (300 <= hue && hue < 360)
            {
                r = c;
                g = 0;
                b = x;
            }

            return Color.FromArgb((int)((r + m) * 255), (int)((g + m) * 255), (int)((b + m) * 255));
        }
    }
}
