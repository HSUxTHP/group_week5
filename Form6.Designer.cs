namespace group_01
{
    //Form6.Déigner.cs
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListBox listBoxQuestions;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.RadioButton radioD;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnReview;


        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            listBoxQuestions = new ListBox();
            lblQuestion = new Label();
            radioA = new RadioButton();
            radioB = new RadioButton();
            radioC = new RadioButton();
            radioD = new RadioButton();
            btnNext = new Button();
            btnBack = new Button();
            btnSubmit = new Button();
            progressBar = new ProgressBar();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxQuestions
            // 
            listBoxQuestions.FormattingEnabled = true;
            listBoxQuestions.Location = new Point(12, 72);
            listBoxQuestions.Name = "listBoxQuestions";
            listBoxQuestions.Size = new Size(168, 344);
            listBoxQuestions.TabIndex = 0;
            listBoxQuestions.SelectedIndexChanged += listBoxQuestions_SelectedIndexChanged;
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(6, 13);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(571, 69);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Question will be displayed here";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            lblQuestion.Click += lblQuestion_Click;
            // 
            // radioA
            // 
            radioA.AutoSize = true;
            radioA.Location = new Point(78, 85);
            radioA.Name = "radioA";
            radioA.Size = new Size(40, 24);
            radioA.TabIndex = 2;
            radioA.TabStop = true;
            radioA.Text = "A";
            radioA.UseVisualStyleBackColor = true;
            // 
            // radioB
            // 
            radioB.AutoSize = true;
            radioB.Location = new Point(78, 120);
            radioB.Name = "radioB";
            radioB.Size = new Size(39, 24);
            radioB.TabIndex = 3;
            radioB.TabStop = true;
            radioB.Text = "B";
            radioB.UseVisualStyleBackColor = true;
            // 
            // radioC
            // 
            radioC.AutoSize = true;
            radioC.Location = new Point(78, 159);
            radioC.Name = "radioC";
            radioC.Size = new Size(39, 24);
            radioC.TabIndex = 4;
            radioC.TabStop = true;
            radioC.Text = "C";
            radioC.UseVisualStyleBackColor = true;
            // 
            // radioD
            // 
            radioD.AutoSize = true;
            radioD.Location = new Point(77, 200);
            radioD.Name = "radioD";
            radioD.Size = new Size(41, 24);
            radioD.TabIndex = 5;
            radioD.TabStop = true;
            radioD.Text = "D";
            radioD.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(77, 260);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(96, 35);
            btnNext.TabIndex = 6;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(192, 260);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 35);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(306, 260);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(102, 35);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(212, 378);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(550, 38);
            progressBar.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 50);
            label1.TabIndex = 10;
            label1.Text = "English Test";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSubmit);
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(btnNext);
            groupBox1.Controls.Add(lblQuestion);
            groupBox1.Controls.Add(radioD);
            groupBox1.Controls.Add(radioC);
            groupBox1.Controls.Add(radioB);
            groupBox1.Controls.Add(radioA);
            groupBox1.Location = new Point(212, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(583, 300);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            //
            // btnReview
            //
            btnReview = new Button();
            btnReview.Location = new Point(430, 260);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(102, 35);
            btnReview.TabIndex = 9;
            btnReview.Text = "Review";
            btnReview.UseVisualStyleBackColor = true;
            btnReview.Click += btnReview_Click;
            groupBox1.Controls.Add(btnReview);
            btnReview.Enabled = false; // Chỉ bật sau khi Submit
            // 
            // Form6
            // 
            ClientSize = new Size(807, 436);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(progressBar);
            Controls.Add(listBoxQuestions);
            Name = "Form6";
            Text = "English Test";
            Load += Form6_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
    }
}