namespace group_01
{
    partial class Form4
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

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel1;

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            exitButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(10, 10);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 0;
            button1.Text = "Open Form1";
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(10, 40);
            button2.Name = "button2";
            button2.Size = new Size(123, 23);
            button2.TabIndex = 1;
            button2.Text = "Open Form2";
            button2.Click += Button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(10, 70);
            button3.Name = "button3";
            button3.Size = new Size(123, 23);
            button3.TabIndex = 2;
            button3.Text = "Open Form3";
            button3.Click += Button3_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(10, 100);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(123, 23);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.Click += ExitButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImage = group_01.Properties.Resources.cach_thay_doi_man_hinh_nen_tren_dien_thoai_samsung_1_254_800x1177;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel1.Location = new Point(139, 10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(609, 506);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // Form4
            // 
            ClientSize = new Size(760, 528);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(exitButton);
            Name = "Form4";
            Text = "Main Form";
            ResumeLayout(false);
        }

        private Button exitButton;
    }
}