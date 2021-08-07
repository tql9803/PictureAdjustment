using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureAdjustment
{
    public partial class CardPrintingPrep : Form
    {
        private Image OriginalImage;
        private string ImageSavePath;

        //FileStream fstream;
        
        public CardPrintingPrep()
        {
            InitializeComponent();
        }

        private void CardPrintingPrep_Load(object sender, EventArgs e)
        {

            //fstream = File.OpenRead("..\\..\\thu 7.jpg");
            //OriginalImage = Image.FromStream(fstream, true);
            //fstream.Close();


            //Stream fstream;

            //fstream = File.OpenRead("..\\..\\Backside.jpg");
            //OriginalImage = Image.FromStream(fstream, true);
            OriginalImage = global::PictureAdjustment.Properties.Resources.Backside;
            //fstream.Close();

            pBMainCanvas.Image = (Image)OriginalImage.Clone();
            pBMainCanvas.SizeMode = PictureBoxSizeMode.StretchImage;
            OriginalImage.Dispose();

            //ft = new Font("Copperplate Gothic", (float)15.21, FontStyle.Bold, GraphicsUnit.Point);
            //strFormat = new StringFormat();
            //strFormat.Alignment = StringAlignment.Center;
            //NameLoc = new Point(OriginalImage.Width / 2, OriginalImage.Height / 2);

            //grp.DrawString("Random Name", ft, Brushes.CadetBlue, NameLoc, strFormat);

            //pBMainCanvas.Image = OriginalImage;
            //pBMainCanvas.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void UIChange(object sender, EventArgs e)
        {
            this.Size = this.Size + new Size(0, tClientName.Size.Height * 2);

            tClientName.Location = new Point((this.Size.Width - tClientName.Size.Width) / 2, this.Height * 9 / 10);
            lClientName.Location = new Point((this.Size.Width - tClientName.Size.Width) / 2 - lClientName.Size.Width, this.Height * 9 / 10);
        }

        private void ResetForm()
        {
            pBMainCanvas.Image = null;
            tClientName.Text = null;
            tClientNum.Text = null;

            ImageSavePath = null;
            OriginalImage = global::PictureAdjustment.Properties.Resources.Backside;

            pBMainCanvas.Image = (Image)OriginalImage.Clone();
            pBMainCanvas.SizeMode = PictureBoxSizeMode.StretchImage;
            OriginalImage.Dispose();

            GC.Collect();
        }

        private void DrawNameOnPic(string ClientName, string ClientNum)
        {
            //OriginalImage = global::PictureAdjustment.Properties.Resources.Backside;
            //grp = Graphics.FromImage(pBMainCanvas.Image);
            //grp.DrawString(ClientName, ft, Brushes.CadetBlue, NameLoc, strFormat);
            Graphics grp;
            Font ft, ft2;
            StringFormat strFormat;
            Point NameLoc, NumLoc;

            Image bufim = pBMainCanvas.Image;
            Bitmap bmp = new Bitmap(pBMainCanvas.Size.Width, pBMainCanvas.Size.Height);

            //new Bitmap(OriginalImage.Width, OriginalImage.Height);

            grp = Graphics.FromImage(bmp);

            //pBMainCanvas.Image = (Image)OriginalImage.Clone();
            //pBMainCanvas.SizeMode = PictureBoxSizeMode.AutoSize;

            ft = new Font(new FontFamily("Copperplate Gothic Bold"), 35f, FontStyle.Regular, GraphicsUnit.Point);
            ft2 = new Font(new FontFamily("Copperplate Gothic Bold"), 20f, FontStyle.Regular, GraphicsUnit.Point);

            strFormat = new StringFormat();
            strFormat.Alignment = StringAlignment.Center;
            strFormat.LineAlignment = StringAlignment.Center;

            NameLoc = new Point(pBMainCanvas.Width / 2, pBMainCanvas.Height / 2 - 110);
            NumLoc = new Point(pBMainCanvas.Width / 2, pBMainCanvas.Height / 2 - 65);

            grp.DrawImage(bufim, 0,0, pBMainCanvas.Width, pBMainCanvas.Height);
            grp.DrawString(ClientName.ToUpper(), ft, new SolidBrush(Color.DarkSlateBlue), NameLoc,strFormat);
            grp.DrawString(ClientNum.ToUpper(), ft2, new SolidBrush(Color.DarkSlateBlue), NumLoc, strFormat);

            pBMainCanvas.Image = bmp;

            ft.Dispose();
            ft2.Dispose();
            grp.Dispose();
            strFormat.Dispose();
        }

        private void SaveImage()
        {
            string newdir;
            string FrontSavePath;
            newdir = "C:\\MemIDDocument\\ClientsDocuments\\ClientPics\\" + tClientName.Text;
            Directory.CreateDirectory(newdir);

            ImageSavePath = newdir + "\\" + tClientName.Text + "B.jpg";
            pBMainCanvas.Image.Save(ImageSavePath, ImageFormat.Jpeg);
            FrontSavePath = newdir + "\\" + tClientName.Text + "F.jpg";

            try
            {
                global::PictureAdjustment.Properties.Resources.Frontside.Save(FrontSavePath);
            } catch(Exception e) 
            { }
        }

        private void UpdateImage()
        {
            DrawNameOnPic(tClientName.Text,tClientNum.Text);
        }
        private void bUpdate_Click(object sender, EventArgs e)
        {
            UpdateImage();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
