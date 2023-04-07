using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Library_Manager_UI.Components
{
    public partial class BookCard : UserControl
    {

        private Image bookCover;
        private string title;

        [Category("Custom Props")]
        public Image BookCover
        {
            get { return bookCover; }
            set { bookCover = value; pbBookCover.Image = value; }

        }

        [Category("Custom Props")]
        public string Title
        {
            get { return title; }
            set { title = value; lblTitle.Text = value; }

        }

        public BookCard()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // SetBackColor();
        }

        private void SetBackColor()
        {
            if (this.BookCover != null)
            {
                // Calculate the average color of the picture box image
                Bitmap bmp = new Bitmap(this.BookCover);
                Color avgColor = GetAverageColor(new Bitmap(this.BookCover));

                // Set the back color of the book card to the average color of the picture box image
                this.BackColor = avgColor;
            }
            else
            {
                // If the picture box image is null, set the back color of the book card to white
                this.BackColor = Color.White;
            }

            SetMinimalisticBackColor(); // Apply the minimalistic and muted color transformation
        }


        private void SetMinimalisticBackColor()
        {
            Color originalColor = this.BackColor; // Get the original color of the book card
            float brightnessOffset = -0.1f; // Set a brightness offset value (between -1 and 1)
            float saturationOffset = -0.2f; // Set a saturation offset value (between -1 and 1)
            float hueOffset = 0.05f; // Set a hue offset value (between -1 and 1)
            float hue, saturation, brightness;

            hue = originalColor.GetHue();
            saturation = originalColor.GetSaturation();
            brightness = originalColor.GetBrightness();

            // Apply the offsets
            brightness += brightnessOffset;
            saturation += saturationOffset;
            hue += hueOffset;
            hue = hue % 1.0f;

            // Clamp the values
            brightness = Math.Max(0, Math.Min(1, brightness));
            saturation = Math.Max(0, Math.Min(1, saturation));

            // Convert the HSB color back to RGB
            Color newColor = Color.FromArgb(originalColor.A, (int)(saturation * 255), (int)(hue * 255));

            this.BackColor = newColor; // Set the new color of the book card
        }


        private Color GetAverageColor(Bitmap bmp)
        {
            int r = 0, g = 0, b = 0;

            // Loop through each pixel in the bitmap and add up the RGB values
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = bmp.GetPixel(x, y);
                    r += c.R;
                    g += c.G;
                    b += c.B;
                }
            }

            // Calculate the average RGB values
            int pixelCount = bmp.Width * bmp.Height;
            r /= pixelCount;
            g /= pixelCount;
            b /= pixelCount;

            return Color.FromArgb(r, g, b);
        }








    }
}
