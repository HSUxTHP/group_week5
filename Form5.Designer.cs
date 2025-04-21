namespace group_01
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private ListBox listBox1;
        private PictureBox pictureBox1;
        private TrackBar trackBar1;
        private ProgressBar progressBar1;

        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            trackBar1 = new TrackBar();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(141, 184);
            listBox1.TabIndex = 0;
            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.ItemHeight = 40;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.DrawItem += listBox1_DrawItem;

            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(184, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(207, 237);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 10;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(233, 56);
            trackBar1.TabIndex = 2;
            trackBar1.TickFrequency = 10;
            trackBar1.Value = 100;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 270);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(141, 23);
            progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 255);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 4;
            label1.Text = "Small";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(446, 255);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 5;
            label2.Text = "Big";
            // 
            // Form5
            // 
            ClientSize = new Size(480, 320);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(trackBar1);
            Controls.Add(progressBar1);
            Name = "Form5";
            Text = "ImageList Demo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
    }
}