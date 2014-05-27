using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.Threading;
using System.IO;

namespace trackk
{
    public partial class f21 : Form
    {
        
        private FilterInfoCollection videoDevices;
        EuclideanColorFiltering filter = new EuclideanColorFiltering();
        Color color = Color.Black;
        GrayscaleBT709 grayscaleFilter = new GrayscaleBT709();
        BlobCounter blobCounter = new BlobCounter();
        int range = 120;
    
        public f21()
        {
            InitializeComponent();
           
            blobCounter.MinWidth = 2;
            blobCounter.MinHeight = 2;
            blobCounter.FilterBlobs = true;
            blobCounter.ObjectsOrder = ObjectsOrder.Size;
            try
            {
                // enumerate video devices
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                // add all devices to combo
                foreach (FilterInfo device in videoDevices)
                {
                    camerasCombo.Items.Add(device.Name);
                }

                camerasCombo.SelectedIndex = 0;
            }
            catch (ApplicationException)
            {
                camerasCombo.Items.Add("No local capture devices");
                videoDevices = null;
            }

            Bitmap b = new Bitmap(320, 240);
           // Rectangle a = (Rectangle)r;
            Pen pen1 = new Pen(Color.FromArgb(160, 255, 160), 3);
            Graphics g2 = Graphics.FromImage(b);
            pen1 = new Pen(Color.FromArgb(255, 0, 0), 3);
            g2.Clear(Color.White);
            g2.DrawLine(pen1, b.Width / 2, 0, b.Width / 2, b.Width);
            g2.DrawLine(pen1, b.Width, b.Height / 2, 0, b.Height / 2); 
               }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        
        }

        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            Bitmap objectsImage = null;
            Bitmap mImage = null;
            mImage=(Bitmap)image.Clone();            
           filter.CenterColor = Color.FromArgb(color.ToArgb());
            filter.Radius =(short)range;
           
            objectsImage = image;
            filter.ApplyInPlace(objectsImage);

            BitmapData objectsData = objectsImage.LockBits(new Rectangle(0, 0, image.Width, image.Height),
            ImageLockMode.ReadOnly, image.PixelFormat);
            UnmanagedImage grayImage = grayscaleFilter.Apply(new UnmanagedImage(objectsData));
            objectsImage.UnlockBits(objectsData);

            
            blobCounter.ProcessImage(grayImage);//get rectangles
            Rectangle[] rects = blobCounter.GetObjectRectangles();//store rects in a varibla
           
            if (rects.Length > 0)//draw blob rectangles on display
            {

                foreach (Rectangle objectRect in rects)
                {
                    Graphics g = Graphics.FromImage(mImage);
                    using (Pen pen = new Pen(Color.FromArgb(160, 255, 160), 5))
                    {
                        g.DrawRectangle(pen, objectRect);
                    }

                    g.Dispose();
                }
            }

            image = mImage;
        }
        public void videoSourcePlayer3_NewFrame(object sender, ref Bitmap image)
        {
            Bitmap objectsImage = null;

            
                  // set center colol and radius
                  filter.CenterColor = Color.FromArgb(color.ToArgb());
                  filter.Radius = (short)range;
                  // apply the filter
                  objectsImage = image;
                  filter.ApplyInPlace(image);

            // lock image for further processing
            BitmapData objectsData = objectsImage.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadOnly, image.PixelFormat);

            // grayscaling
            UnmanagedImage grayImage = grayscaleFilter.Apply(new UnmanagedImage(objectsData));

            // unlock image
            objectsImage.UnlockBits(objectsData);

            // locate blobs 
            blobCounter.ProcessImage(grayImage);
            Rectangle[] rects = blobCounter.GetObjectRectangles();
          
            if (rects.Length > 0)
            {
                Rectangle objectRect = rects[0];

                // draw rectangle around detected object
                Graphics g = Graphics.FromImage(image);

                using (Pen pen = new Pen(Color.FromArgb(160, 255, 160), 5))
                {
                    g.DrawRectangle(pen, objectRect);
                }
              g.Dispose();
               
               
            }
       }
       
         

      
  
               
          
      
        
        private void button1_Click(object sender, EventArgs e)
        {

            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
            videoSourcePlayer2.SignalToStop();
            videoSourcePlayer2.WaitForStop();
            videoSourcePlayer3.SignalToStop();
            videoSourcePlayer3.WaitForStop();
            // videoDevices = null;
            VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[camerasCombo.SelectedIndex].MonikerString);
            videoSource.DesiredFrameSize = new Size(320, 240);
            videoSource.DesiredFrameRate = 12;

            videoSourcePlayer1.VideoSource = videoSource;
            videoSourcePlayer1.Start();
            videoSourcePlayer2.VideoSource = videoSource;
            videoSourcePlayer2.Start();
            videoSourcePlayer3.VideoSource = videoSource;
            videoSourcePlayer3.Start();
            //groupBox1.Enabled = false;
        }

        private void f21_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
            videoSourcePlayer2.SignalToStop();
            videoSourcePlayer2.WaitForStop();
            videoSourcePlayer3.SignalToStop();
            videoSourcePlayer3.WaitForStop();
            groupBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
            videoSourcePlayer2.SignalToStop();
            videoSourcePlayer2.WaitForStop();
            videoSourcePlayer3.SignalToStop();
            videoSourcePlayer3.WaitForStop();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            colorDialog1.ShowDialog();
            color = colorDialog1.Color;
        }

       

        private void videoSourcePlayer2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void videoSourcePlayer3_Click(object sender, EventArgs e)
        {

        }

        private void f21_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
         
            
 
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
