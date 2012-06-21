using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeRez {
    public partial class Form1 : Form {
        private Image _image;
        private int _pixelSize = 4;
        private float _threshold = .2f;
        private int _targetWidth = 64;
        private int _targetHeight = 128;
        private Rectangle _cropArea;

        Boolean bHaveMouse = false;
        Point ptOriginal = new Point();
        Point ptLast = new Point(); 

        public Form1() {
            _cropArea = new Rectangle(0, 0, _targetWidth, _targetHeight);
            InitializeComponent();
            src.Resize += (sender, args) => dest.Location = new Point(src.Location.X + src.Width + 5, dest.Location.Y);
            src.Paint += SrcPicBox_Paint;
            src.MouseDown += SrcPicBox_MouseDown;
            src.MouseMove += SrcPicBox_MouseMove;
            src.MouseUp += SrcPicBox_MouseUp;

            pixelSize.Text = _pixelSize.ToString();
            darkThreshold.Text = _threshold.ToString();
            targetHeight.Text = _targetHeight.ToString();
            targetWidth.Text = _targetWidth.ToString();
        }

        private void SrcPicBox_MouseDown(object sender, MouseEventArgs e) {
            // Make a note that we "have the mouse". 
            bHaveMouse = true;

            // Store the "starting point" for this rubber-band rectangle. 
            ptOriginal.X = e.X;
            ptOriginal.Y = e.Y;

            // Special value lets us know that no previous 
            // rectangle needs to be erased. 

            ptLast.X = -1;
            ptLast.Y = -1;

            _cropArea = new Rectangle(new Point(e.X, e.Y), new Size());
        }

        private void SrcPicBox_MouseUp(object sender, MouseEventArgs e) {
            // Set internal flag to know we no longer "have the mouse". 
            bHaveMouse = false;

            // If we have drawn previously, draw again in that spot 
            // to remove the lines. 
            if ( ptLast.X != -1 ) {
                Point ptCurrent = new Point(e.X, e.Y);
            }

            // Set flags to know that there is no "previous" line to reverse. 
            ptLast.X = -1;
            ptLast.Y = -1;
            ptOriginal.X = -1;
            ptOriginal.Y = -1;

            DeRez();
        }

        private void SrcPicBox_MouseMove(object sender, MouseEventArgs e) {
            Point ptCurrent = new Point(e.X, e.Y);

            // If we "have the mouse", then we draw our lines. 
            if ( bHaveMouse ) {
                // If we have drawn previously, draw again in 
                // that spot to remove the lines. 

                // Update last point. 
                ptLast = ptCurrent;

                // Draw new lines. 

                // e.X - _cropArea.X; 
                // normal 
                if ( e.X > ptOriginal.X && e.Y > ptOriginal.Y ) {
                    _cropArea.Width = e.X - ptOriginal.X;

                    // e.Y - _cropArea.Height; 
                    _cropArea.Height = e.Y - ptOriginal.Y;
                } else if ( e.X < ptOriginal.X && e.Y > ptOriginal.Y ) {
                    _cropArea.Width = ptOriginal.X - e.X;
                    _cropArea.Height = e.Y - ptOriginal.Y;
                    _cropArea.X = e.X;
                    _cropArea.Y = ptOriginal.Y;
                } else if ( e.X > ptOriginal.X && e.Y < ptOriginal.Y ) {
                    _cropArea.Width = e.X - ptOriginal.X;
                    _cropArea.Height = ptOriginal.Y - e.Y;

                    _cropArea.X = ptOriginal.X;
                    _cropArea.Y = e.Y;
                } else {
                    _cropArea.Width = ptOriginal.X - e.X;

                    // e.Y - _cropArea.Height; 
                    _cropArea.Height = ptOriginal.Y - e.Y;
                    _cropArea.X = e.X;
                    _cropArea.Y = e.Y;
                }

                // adjust the width and height of the crop area to match the target
                float ratio = (float) _targetHeight / _targetWidth;
                float cropRatio = (float) _cropArea.Height / _cropArea.Width;
                if ( Math.Abs(ratio - cropRatio) > .1 ) {
                    _cropArea.Height = (int) (_cropArea.Width * ratio);
                }

                src.Refresh();
            }
        }

        private Bitmap CropSource() {
            
            //Prepare a new Bitmap on which the cropped image will be drawn 
            Bitmap sourceBitmap = new Bitmap(src.Image, src.Width, src.Height);            
            Bitmap b;
            try {
                b = new Bitmap(_cropArea.Width, _cropArea.Height);
            } catch ( ArgumentException ) {
                return sourceBitmap;
            }

            using ( Graphics g = Graphics.FromImage(b) ) {

                //Draw the image on the Graphics object with the new dimesions 
                g.DrawImage(sourceBitmap, new Rectangle(0, 0, b.Width, b.Height),
                            _cropArea, GraphicsUnit.Pixel);

                //Good practice to dispose the System.Drawing objects when not in use. 
                sourceBitmap.Dispose();

                return b;
            }
        } 

        private void SrcPicBox_Paint(object sender, PaintEventArgs e) {
            if ( _cropArea != null ) {
                Pen drawLine = new Pen(Color.Black);
                drawLine.DashStyle = DashStyle.Dash;
                e.Graphics.DrawRectangle(drawLine, _cropArea);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            this.openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            _image = Image.FromFile(path);
            src.Image = _image;
            //_cropArea = new Rectangle(0, 0, _image.Width, _image.Height);
            DeRez();
        }

        private void button1_Click(object sender, EventArgs e) {
            DeRez();
        }

        private void DeRez() {
            if ( _image != null ) {
                Bitmap bitmap = CropSource();
                int outputWidth = bitmap.Width / _pixelSize;
                int outputHeight = bitmap.Height / _pixelSize;
                Bitmap output = new Bitmap(outputWidth, outputHeight);
                for ( int y = 0; y < outputHeight; y++ ) {
                    for ( int x = 0; x < outputWidth; x++ ) {
                        int black = 0;
                        for ( int yy = 0; y * _pixelSize + yy < bitmap.Height && yy < _pixelSize; yy++ ) {
                            for ( int xx = 0; x * _pixelSize + xx < bitmap.Width && xx < _pixelSize; xx++ ) {
                                Color pixel = bitmap.GetPixel(x * _pixelSize + xx, y * _pixelSize + yy);
                                if ( IsPixelDark(pixel) ) {
                                    black++;
                                }
                            }
                        }
                        if ( black > (_pixelSize * _pixelSize) / 2 ) {
                            output.SetPixel(x, y, Color.Black);
                        } else {
                            output.SetPixel(x, y, Color.White);
                        }
                    }
                }

                output = ResizeImage(output, _targetWidth, _targetHeight);
                dest.Image = output;
            }
        }

        private bool IsPixelDark(Color pixel) {
            return pixel.GetBrightness() < _threshold;
        }

        private void pixelSize_TextChanged(object sender, EventArgs e) {
            int parse;
            if ( Int32.TryParse(pixelSize.Text, out parse) ) {
                _pixelSize = parse;
                DeRez();
            }
        }

        private void darkThreshold_TextChanged(object sender, EventArgs e) {
            float parse;
            if ( float.TryParse(darkThreshold.Text, out parse) ) {
                _threshold = parse;
                DeRez();
            }
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(System.Drawing.Image image, int width, int height) {
            //a holder for the result
            Bitmap result = new Bitmap(width, height);

            //use a graphics object to draw the resized image into the bitmap
            using ( Graphics graphics = Graphics.FromImage(result) ) {
                //set the resize quality modes to high quality
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                //draw the image into the target bitmap
                graphics.DrawImage(image, 0, 0, result.Width, result.Height);
            }

            //return the resulting bitmap
            return result;
        }

        private void targetWidth_TextChanged(object sender, EventArgs e) {
            int parse;
            if (Int32.TryParse(targetWidth.Text, out parse)) {
                _targetWidth = parse;
                DeRez();
            }
        }

        private void targetHeight_TextChanged(object sender, EventArgs e) {
            int parse;
            if ( Int32.TryParse(targetHeight.Text, out parse) ) {
                _targetHeight = parse;
                DeRez();
            }
        }

    }
}
