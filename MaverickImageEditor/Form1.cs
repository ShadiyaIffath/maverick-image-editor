using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaverickImageEditor
{
    public partial class Form1 : Form
    {
        private Image image;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dlg = new OpenFileDialog();
            Dlg.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*.gif;)|*.jpg;*.jpeg;*.png;.*.gif" ;
            Dlg.Title = "Select Image";
            if(Dlg.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(Dlg.FileName);
                LoadImage();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadImage() //method which adjusts the picture box in order to fit the entire image
        {
            int imgWidth = image.Width;
            int imgHeight = image.Height;
            PictureBox.Width = imgWidth;
            PictureBox.Height = imgHeight;
            PictureBox.Image = image;
            PictureBoxPosition();
        }
        private void PictureBoxPosition()
        {
            int x = 0;
            int y = 0;
            if(splitContainer1.Panel1.Width > PictureBox.Width)
            {
                x = (splitContainer1.Panel1.Width - PictureBox.Width) / 2;
            }
            if(splitContainer1.Panel1.Height > PictureBox.Height)
            {
                y = (splitContainer1.Height - PictureBox.Height) / 2;
            }
            PictureBox.Location = new Point(x, y);
           
        }

        private void SplitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            PictureBoxPosition();
        }
    }
}
