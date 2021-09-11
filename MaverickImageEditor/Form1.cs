using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaverickImageEditor
{
    public partial class Form1 : Form
    {
        private ImageEditor imageEditor;    //object which performs image editing functions
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(128, 72, 145, 220));
        private Point RectStartPoint;
        private bool cropActivate = false;
        private Rectangle Rect = new Rectangle();
        Stack<Image> UChanges = new Stack<Image>(5);    //stack used to store undo stacked images
        Stack<Image> RChanges = new Stack<Image>(5);    //stack used to store redo stacked images 

        CancellationTokenSource cts = new CancellationTokenSource();

        private String fileName;


        public Form1()
        {
            InitializeComponent();
            PictureBox.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
            PictureBox.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            PictureBox.Paint += new PaintEventHandler(PictureBox_Paint);
            PictureBox.MouseUp += new MouseEventHandler(PictureBox_MouseUp);
            save.Enabled = false;
            saveMenu.Enabled = false;
            undo.Enabled = false;
            redo.Enabled = false;
            resetToolStripMenuItem.Enabled = false;
            cancelToolStripMenuItem.Enabled = false;
            toolStrip.Enabled = false;
            tabControl1.Enabled = false;

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) // upload image to the application
        {
            OpenFileDialog Dlg = new OpenFileDialog();

            Dlg.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*.gif;)|*.jpg;*.jpeg;*.png;.*.gif";
            Dlg.Title = "Select Image";
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                imageEditor = new ImageEditor(new Bitmap(Dlg.FileName));
                LoadImage(imageEditor.Img);
                SubPictureBox();

                //editor fucntions, save and undo buttons are enabled only after an image is uploaded
                cancelToolStripMenuItem.Enabled = true;
                resetToolStripMenuItem.Enabled = true;
                save.Enabled = true;
                saveMenu.Enabled = true;
                toolStrip.Enabled = true;
                tabControl1.Enabled = true;
                RChanges.Clear();
                UChanges.Clear();
            }

        }

        public void UCAdd(Image img) //push image to undo stack
        {
            UChanges.Push(img);
            undo.Enabled = true;
        }

        public void RCAdd(Image img) //push image to redo stack
        {
            RChanges.Push(img);
            redo.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void LoadImage(Bitmap img) //method which adjusts the picture box in order to fit the entire image
                                           //that is uploaded
        {
            //the main picturebox view size
            int imgWidth = img.Width;
            int imgHeight = img.Height;
            PictureBox.Width = imgWidth;
            PictureBox.Height = imgHeight;
            PictureBox.Image = img;
            imageEditor.Img = img;

            PictureBoxPosition();
        }
        private void PictureBoxPosition() //centers the uploaded image in the application screen
        {
            int x = 0;
            int y = 0;
            if (splitContainer1.Panel1.Width > PictureBox.Width)
            {
                x = (splitContainer1.Panel1.Width - PictureBox.Width) / 2;
            }
            if (splitContainer1.Panel1.Height > PictureBox.Height)
            {
                y = (splitContainer1.Height - PictureBox.Height) / 2;
            }
            PictureBox.Location = new Point(x, y); //main picture box position    
        }

        private void SubPictureBox() // the secondary picture box which stores the image before applying filters for comparison
        {

            PictureBox1.Image = imageEditor.Img;
            int x = 0;
            int y = 0;
            if (groupBox1.Width > PictureBox1.Width)
            {
                x = (groupBox1.Width - PictureBox1.Width) / 2;
            }
            if (groupBox1.Height > PictureBox1.Height)
            {
                y = (groupBox1.Height - PictureBox1.Height) / 2;
            }
            PictureBox1.Location = new Point(x, y);
        }

        private void SplitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            PictureBoxPosition();
        }

        private void toolStripButton2_Click(object sender, EventArgs e) //grayscale image edit
        {
            if (PictureBox.Image == null)
            {
                MessageBox.Show("Upload Image to Edit", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                CancellationToken token = cts.Token;
                List<Task<int>> tasks = new List<Task<int>>();
                Task<int> task = tasks[1];
                
                Task<Bitmap> greyTask = Task.Factory.StartNew(() =>
                {
                    Bitmap temp = imageEditor.GrayScale(token);
                    return temp;
                }, token
                );
                Task ui = greyTask.ContinueWith((antecedent) =>
                {
                    Bitmap imgvalue = null;
                    try
                    {
                        imgvalue = antecedent.Result;
                        UCAdd(PictureBox.Image);
                        RChanges.Clear();
                    }
                    catch (AggregateException ae)
                    {
                        String message = "Error Occured";
                        ae = ae.Flatten();
                        foreach (Exception ex in ae.InnerExceptions)
                        {
                            if (ex is OperationCanceledException)
                            {
                                message = "Operation Cancelled";
                                break;
                            }

                        }
                        MessageBox.Show(message, "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    LoadImage(imgvalue);
                },
               TaskScheduler.FromCurrentSynchronizationContext()
               );
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e) //change the numeric textbox according to trackbar
        {
            brightnessUpDown.Value = brightnessTrackBar.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)//change the trackbar position according to the integer
        {
            brightnessTrackBar.Value = (int)brightnessUpDown.Value;
        }

        private void button3_Click(object sender, EventArgs e) //apply brightness changes on the image
        {
            if (PictureBox.Image == null)
            {
                MessageBox.Show("Upload Image to Edit", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                CancellationToken token = cts.Token;
                int value = brightnessTrackBar.Value;
                Task<Bitmap> brightness = Task.Factory.StartNew<Bitmap>((args) =>
                {
                    Bitmap temp = imageEditor.Brightness((int)args, token);
                    return temp;
                }, value, token
                );
                Task ui = brightness.ContinueWith((antecedent) =>
                {
                    Bitmap imgvalue = null;
                    try
                    {
                        imgvalue = antecedent.Result;
                        UCAdd(PictureBox.Image);
                        RChanges.Clear();
                    }
                    catch (AggregateException ae)
                    {
                        String message = "Error Occured";
                        ae = ae.Flatten();
                        foreach (Exception ex in ae.InnerExceptions)
                        {
                            if (ae.InnerException is OperationCanceledException)
                            {
                                message = "Operation Cancelled";
                                break;
                            }

                        }
                        MessageBox.Show(message, "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    LoadImage(imgvalue);
                    brightnessTrackBar.Value = 0;
                    brightnessUpDown.Value = 0;
                },
                TaskScheduler.FromCurrentSynchronizationContext()
                );
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) //90 rotate function
        {
            if (PictureBox.Image == null)
            {
                MessageBox.Show("Upload Image to Edit", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                UCAdd(PictureBox.Image);
                Bitmap temp = imageEditor.Flip(90);
                LoadImage(temp);
                RChanges.Clear();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e) //180 rotate function
        {
            if (PictureBox.Image == null)
            {
                MessageBox.Show("Upload Image to Edit", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                UCAdd(PictureBox.Image);
                Bitmap temp = imageEditor.Flip(180);
                LoadImage(temp);
                RChanges.Clear();
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)//-90 rotate function
        {
            if (PictureBox.Image == null)
            {
                MessageBox.Show("Upload Image to Edit", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                UCAdd(PictureBox.Image);
                Bitmap temp = imageEditor.Flip(-90);
                LoadImage(temp);
                RChanges.Clear();
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void horizontalFlipToolStripMenuItem_Click(object sender, EventArgs e) //horizontal flip
        {
            if (PictureBox.Image == null)
            {
                MessageBox.Show("Upload Image to Edit", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                UCAdd(PictureBox.Image);
                Bitmap temp = imageEditor.Flip(0);
                LoadImage(temp);
                RChanges.Clear();
            }
        }

        private void veriticalFlipToolStripMenuItem_Click(object sender, EventArgs e) // vertical flip
        {
            if (PictureBox.Image == null)
            {
                MessageBox.Show("Upload Image to Edit", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                UCAdd(PictureBox.Image);
                Bitmap temp = imageEditor.Flip(-180);
                LoadImage(temp);
                RChanges.Clear();

            }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            if (PictureBox.Image == null)
            {
                MessageBox.Show("Upload Image to Edit", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) //save as button to save files according to desired location
        {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*.gif;)|*.jpg;*.jpeg;*.png;.*.gif";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PictureBox.Image.Save(dlg.FileName, ImageFormat.Jpeg);
                    imageEditor.Img = (Bitmap)PictureBox.Image;
                    fileName = dlg.FileName;
                    SubPictureBox();
                }
            }
            catch (Exception)
            {
                return;
            }

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e) //user clicks the exit button
        {
            if (PictureBox.Image != PictureBox1.Image || (fileName == null && PictureBox1.Image != null)) //checks if user has unsaved changes
            {
                if (MessageBox.Show("You have unsaved changes. Save File.", "Maverick", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    saveMenu_Click(sender, e);
                }

            }
            this.Close();
        }

        private void invertButton_Click(object sender, EventArgs e) //Invert Image filter
        {
            if (PictureBox.Image == null)
            {
                MessageBox.Show("Upload Image to Edit", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                CancellationToken token = cts.Token;

                Task<Bitmap> invert = Task.Factory.StartNew<Bitmap>(() =>
                {
                    Bitmap temp = imageEditor.Invert(token);
                    return temp;
                }, token
                );

                Task ui = invert.ContinueWith((antecedent) =>
                {
                    Bitmap imgvalue = null;
                    try
                    {
                        imgvalue = antecedent.Result;
                        UCAdd(PictureBox.Image);
                        RChanges.Clear();
                    }
                    catch (AggregateException ae)
                    {
                        String message = "Error Occured";
                        ae = ae.Flatten();
                        foreach (Exception ex in ae.InnerExceptions)
                        {
                            if (ae.InnerException is OperationCanceledException)
                            {
                                message = "Operation Cancelled";
                                break;
                            }

                        }
                        MessageBox.Show(message, "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    LoadImage(imgvalue);
                }
                ,
                TaskScheduler.FromCurrentSynchronizationContext());

            }
        }

        private void undoToolStripMenuItem_Click_1(object sender, EventArgs e)//undo click event handled
        {
            if (UChanges.Count != 0)
            {
                RCAdd(PictureBox.Image);
                LoadImage((Bitmap)UChanges.Pop());
                if (UChanges.Count == 0)
                {
                    undo.Enabled = false;
                }
                else
                {
                    undo.Enabled = true;
                }
            }
        }

        private void saveMenu_Click(object sender, EventArgs e) //save button in the menu
        {
            if (fileName == null) //checks if file has been saved before
            {
                saveToolStripMenuItem_Click(sender, e); //show save file dialog
            }
            else //if file has been saved before, overwriting the previously saved file
            {
                PictureBox.Image.Save(fileName, ImageFormat.Jpeg);
                imageEditor.Img = (Bitmap)PictureBox.Image;
                SubPictureBox(); //update sub picture box in order to show the new image as the original image
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            exitToolStripMenuItem_Click(sender, e);
            this.Close();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e) //redo
        {
            if (RChanges.Count != 0)
            {
                UCAdd(PictureBox.Image);
                LoadImage((Bitmap)RChanges.Pop());
                if (RChanges.Count == 0)
                {
                    redo.Enabled = false;
                }
                else
                {
                    redo.Enabled = true;
                }
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            contrastUpDown.Value = contrastTrackBar.Value;
        }

        private void contrastUpDown_ValueChanged(object sender, EventArgs e)
        {
            contrastTrackBar.Value = (int)contrastUpDown.Value;
        }

        private void contrastApply_Click(object sender, EventArgs e)
        {
            CancellationToken token = cts.Token;
            int value = contrastTrackBar.Value;
            Task<Bitmap> contrastImage = Task.Factory.StartNew((args) =>
            {
                Bitmap temp = imageEditor.ContrastImage((int)args, token);
                return temp;
            }, value, token
            );
            Task ui = contrastImage.ContinueWith((antecedent) =>
            {
                Bitmap imgvalue = null;
                try
                {
                    imgvalue = antecedent.Result;
                    UCAdd(PictureBox.Image);
                    RChanges.Clear();
                }
                catch (AggregateException ae)
                {
                    String message = "Error Occured";
                    ae = ae.Flatten();
                    foreach (Exception ex in ae.InnerExceptions)
                    {
                        if (ae.InnerException is OperationCanceledException)
                        {
                            message = "Operation Cancelled";
                            break;
                        }
                    }
                    MessageBox.Show(message, "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                LoadImage(imgvalue);
                contrastTrackBar.Value = 0;
                contrastUpDown.Value = 0;
            },
            TaskScheduler.FromCurrentSynchronizationContext()
            );
        }

        private void toolStripButton4_Click(object sender, EventArgs e) //sepia filter on image
        {
            CancellationToken token = cts.Token;
            Task<Bitmap> sepiaTask = Task.Factory.StartNew(() =>
            {
                Bitmap temp = imageEditor.SepiaEditor(token);
                return temp;
            },token
            );

            Task ui = sepiaTask.ContinueWith((antecedent) =>
            {
                Bitmap tmpImage = null;
                try
                {
                    tmpImage = antecedent.Result;
                    UCAdd(PictureBox.Image);
                    RChanges.Clear();
                }
                catch (AggregateException ae)
                {
                    String message = "Error Occured";
                    ae = ae.Flatten();
                    foreach (Exception ex in ae.InnerExceptions)
                    {
                        if (ae.InnerException is OperationCanceledException)
                        {
                            message = "Operation Cancelled";
                            break;
                        }
                    }
                    MessageBox.Show(message, "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }                
                LoadImage(tmpImage);  
            },
            TaskScheduler.FromCurrentSynchronizationContext()
             );
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {

        }


        private void toolStripButton3_Click(object sender, EventArgs e) //crop function
        {
            cropActivate = true;
        }

        private void PictureBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (cropActivate== true)
            {
                // Determine the initial rectangle coordinates...
                RectStartPoint = e.Location;
                Invalidate();
            }
        }

        // Draw Rectangle
        //
        private void PictureBox_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Point tempEndPoint = e.Location;
            Rect.Location = new Point(
                Math.Min(RectStartPoint.X, tempEndPoint.X),
                Math.Min(RectStartPoint.Y, tempEndPoint.Y));
            Rect.Size = new Size(
                Math.Abs(RectStartPoint.X - tempEndPoint.X),
                Math.Abs(RectStartPoint.Y - tempEndPoint.Y));
            PictureBox.Invalidate();
        }

        // Draw Area
        //
        private void PictureBox_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Draw the rectangle...
            if (cropActivate==true)
            {
                if (Rect != null && Rect.Width > 0 && Rect.Height > 0)
                {
                    e.Graphics.FillRectangle(selectionBrush, Rect);
                }
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (Rect.Contains(e.Location))
                {
                  //  Debug.WriteLine("Right click");
                }
            }
        }

        private void cropbutton_Click(object sender, EventArgs e)
        {
            if(Rect != null && Rect.Width > 0 && Rect.Height > 0 && cropActivate== true)
            {
                UCAdd(PictureBox.Image);
                Bitmap temp = imageEditor.CropImage(Rect);
                LoadImage(temp);
                RChanges.Clear();
                cropActivate = false;

            }
            else
            {
                MessageBox.Show("Select Area to Crop", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button1_Click(object sender, EventArgs e)//deactivate crop
        {
            cropActivate = false;
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            cts = new CancellationTokenSource();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e) //red filter
        {
            CancellationToken token = cts.Token;

            Task<Bitmap> redFilter = Task.Factory.StartNew(() =>
            {
                Bitmap temp = imageEditor.FilterImage("Red",token);
                return temp;
            },token);
            Task ui = redFilter.ContinueWith((antecedent) =>
            {
                Bitmap tmpImage = null;
                try
                {
                    tmpImage = antecedent.Result;
                    UCAdd(PictureBox.Image);
                    RChanges.Clear();
                }
                catch (AggregateException ae)
                {
                    String message = "Error Occured";
                    ae = ae.Flatten();
                    foreach (Exception ex in ae.InnerExceptions)
                    {
                        if (ae.InnerException is OperationCanceledException)
                        {
                            message = "Operation Cancelled";
                            break;
                        }
                    }
                    MessageBox.Show(message, "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }               
                LoadImage(tmpImage);               
            },
            TaskScheduler.FromCurrentSynchronizationContext()
             );
        }

        private void greenFilter_Click(object sender, EventArgs e)
        {
            CancellationToken token = cts.Token;

            Task<Bitmap> greenFilter = Task.Factory.StartNew(() =>
            {
                Bitmap temp = imageEditor.FilterImage("Green",token);
                return temp;
            }
            , token);

            Task ui = greenFilter.ContinueWith((antecedent) =>
            {
                Bitmap tmpImage = null;
                try
                {
                    tmpImage = antecedent.Result;
                    UCAdd(PictureBox.Image);
                    RChanges.Clear();
                }
                catch (AggregateException ae)
                {
                    String message = "Error Occured";
                    ae = ae.Flatten();
                    foreach (Exception ex in ae.InnerExceptions)
                    {
                        if (ae.InnerException is OperationCanceledException)
                        {
                            message = "Operation Cancelled";
                            break;
                        }

                    }

                    MessageBox.Show(message, "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                LoadImage(tmpImage);
            }
            ,
            TaskScheduler.FromCurrentSynchronizationContext()
             );
        }

        private void blueFilter_Click(object sender, EventArgs e)
        {
            CancellationToken token = cts.Token;

            Task<Bitmap> blueFilter = Task.Factory.StartNew(() =>
            {
                Bitmap temp = imageEditor.FilterImage("Blue",token);
                return temp;
            }
            , token);

            Task ui = blueFilter.ContinueWith((antecedent) =>
            {
                Bitmap tmpImage = null;
                try
                {
                    tmpImage = antecedent.Result;
                    UCAdd(PictureBox.Image);
                    RChanges.Clear();
                }
                catch (AggregateException ae)
                {
                    String message = "Error Occured";
                    ae = ae.Flatten();
                    foreach (Exception ex in ae.InnerExceptions)
                    {
                        if (ae.InnerException is OperationCanceledException)
                        {
                            message = "Operation Cancelled";
                            break;
                        }

                    }

                    MessageBox.Show(message, "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                UCAdd(PictureBox.Image);
                LoadImage(tmpImage);
                RChanges.Clear();
            }
            ,
            TaskScheduler.FromCurrentSynchronizationContext()
             );
        }

        private void flipToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadImage((Bitmap)PictureBox1.Image);
            UChanges.Clear();
            RChanges.Clear();
            undo.Enabled = false;
            redo.Enabled = false;

        }
    }
}
