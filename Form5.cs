using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace group_01
{
    public partial class Form5 : Form
    {
        List<Image> imageList = new List<Image>();
        List<string> imageNames = new List<string>();

        public Form5()
        {
            InitializeComponent();
            LoadImages();
        }

        private void LoadImages()
        {
            // Add your own image paths or use project resources
            imageList.Add(Image.FromFile("img1.jpg"));
            imageList.Add(Image.FromFile("img2.jpg"));
            imageList.Add(Image.FromFile("img3.jpg"));

            imageNames.Add("Image 1");
            imageNames.Add("Image 2");
            imageNames.Add("Image 3");

            listBox1.Items.AddRange(imageNames.ToArray());
            progressBar1.Minimum = 0;
            progressBar1.Maximum = imageList.Count - 1;
            progressBar1.Value = 0;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ResizeImageInPictureBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResizeImageInPictureBox();
            progressBar1.Value = listBox1.SelectedIndex;
        }

        private void ResizeImageInPictureBox()
        {
            int index = listBox1.SelectedIndex;
            if (index < 0 || index >= imageList.Count) return;

            float scale = trackBar1.Value / 100f;

            Image original = imageList[index];

            int newWidth = (int)(original.Width * scale);
            int newHeight = (int)(original.Height * scale);

            Bitmap resized = new Bitmap(original, new Size(newWidth, newHeight));

            // Tạo ảnh mới bằng đúng kích thước PictureBox
            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.Clear(pictureBox1.BackColor);

                int x = (pictureBox1.Width - newWidth) / 2;
                int y = (pictureBox1.Height - newHeight) / 2;

                g.DrawImage(resized, x, y, newWidth, newHeight);
            }

            pictureBox1.Image = canvas;
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            // Lấy hình ảnh từ ImageList
            Image img = imageList[e.Index];
            string text = listBox1.Items[e.Index].ToString();

            // Vẽ hình ảnh
            e.Graphics.DrawImage(img, e.Bounds.Left + 2, e.Bounds.Top + 2, 32, 32);

            // Vẽ văn bản bên cạnh hình
            using (Brush brush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(text, e.Font, brush, e.Bounds.Left + 40, e.Bounds.Top + 10);
            }

            e.DrawFocusRectangle();
        }



    }
}