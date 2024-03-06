using System;
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
    }
}
