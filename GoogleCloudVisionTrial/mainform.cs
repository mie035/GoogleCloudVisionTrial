using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GoogleCloudVisionTrial
{
    public partial class Mainform : Form,  IDisposable
    {
        CloudVisionController visionController = new CloudVisionController();
        public Mainform()
        {
            InitializeComponent();
            pictDetect.AllowDrop = true;
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            Image img;
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image File(*.bmp,*.jpg,*.png,*.tif)|*.bmp;*.jpg;*.png;*.tif|Bitmap(*.bmp)|*.bmp|Jpeg(*.jpg)|*.jpg|PNG(*.png)|*.png";
                if (ofd.ShowDialog() == DialogResult.Cancel) return;

                if (File.Exists(ofd.FileName))
                    img = Image.FromFile(ofd.FileName);
                else
                    throw new Exception("it doesn't existed");
                pictDetect.Image = img;
            }
        }

        private void pictDetect_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pictDetect_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            var img = Image.FromFile(files[0]);
            if(img != null)
                pictDetect.Image = img;
            else
                MessageBox.Show("It's not picture");

        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            var detectedTxt = visionController.ReadTextFromImage(pictDetect.Image);
            tbxDetected.Text = detectedTxt;
        }
    }
}
