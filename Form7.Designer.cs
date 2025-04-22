namespace group_01
{
    partial class Form7
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvQuestions = new DataGridView();
            txtQuestion = new TextBox();
            txtOptionA = new TextBox();
            txtOptionB = new TextBox();
            txtOptionC = new TextBox();
            txtOptionD = new TextBox();
            cboCorrectAnswer = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSaveToFile = new Button();
            btnLoadFromFile = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).BeginInit();
            SuspendLayout();
            // 
            // dgvQuestions
            // 
            dgvQuestions.ColumnHeadersHeight = 29;
            dgvQuestions.Location = new Point(-2, 92);
            dgvQuestions.Name = "dgvQuestions";
            dgvQuestions.RowHeadersWidth = 51;
            dgvQuestions.Size = new Size(490, 458);
            dgvQuestions.TabIndex = 0;
            dgvQuestions.SelectionChanged += dgvQuestions_SelectionChanged;
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(494, 92);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(276, 130);
            txtQuestion.TabIndex = 2;
            txtQuestion.Text = "Question";
            // 
            // txtOptionA
            // 
            txtOptionA.Location = new Point(494, 268);
            txtOptionA.Name = "txtOptionA";
            txtOptionA.Size = new Size(276, 27);
            txtOptionA.TabIndex = 4;
            txtOptionA.Text = "A. ?";
            // 
            // txtOptionB
            // 
            txtOptionB.Location = new Point(494, 325);
            txtOptionB.Name = "txtOptionB";
            txtOptionB.Size = new Size(276, 27);
            txtOptionB.TabIndex = 6;
            txtOptionB.Text = "B. ?";
            // 
            // txtOptionC
            // 
            txtOptionC.Location = new Point(494, 387);
            txtOptionC.Name = "txtOptionC";
            txtOptionC.Size = new Size(276, 27);
            txtOptionC.TabIndex = 8;
            txtOptionC.Text = "C. ?";
            // 
            // txtOptionD
            // 
            txtOptionD.Location = new Point(494, 459);
            txtOptionD.Name = "txtOptionD";
            txtOptionD.Size = new Size(276, 27);
            txtOptionD.TabIndex = 10;
            txtOptionD.Text = "D. ?";
            // 
            // cboCorrectAnswer
            // 
            cboCorrectAnswer.Location = new Point(494, 522);
            cboCorrectAnswer.Name = "cboCorrectAnswer";
            cboCorrectAnswer.Size = new Size(276, 28);
            cboCorrectAnswer.TabIndex = 12;
            cboCorrectAnswer.Text = "Correct answer";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 49);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 28);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(93, 49);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(87, 28);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(186, 48);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 28);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSaveToFile
            // 
            btnSaveToFile.Location = new Point(267, 48);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.Size = new Size(102, 28);
            btnSaveToFile.TabIndex = 16;
            btnSaveToFile.Text = "Save to file";
            btnSaveToFile.Click += btnSaveToFile_Click;
            // 
            // btnLoadFromFile
            // 
            btnLoadFromFile.Location = new Point(375, 48);
            btnLoadFromFile.Name = "btnLoadFromFile";
            btnLoadFromFile.Size = new Size(113, 28);
            btnLoadFromFile.TabIndex = 17;
            btnLoadFromFile.Text = "Load from file";
            btnLoadFromFile.Click += btnLoadFromFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(494, 245);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 18;
            label1.Text = "Enter answer A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(494, 302);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 19;
            label2.Text = "Enter answer B:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(494, 364);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 20;
            label3.Text = "Enter answer C:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(494, 436);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 21;
            label4.Text = "Enter answer D:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(494, 69);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 22;
            label5.Text = "Enter question:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(494, 499);
            label6.Name = "label6";
            label6.Size = new Size(186, 20);
            label6.TabIndex = 23;
            label6.Text = "Choose the correct answer:";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvQuestions);
            Controls.Add(txtQuestion);
            Controls.Add(txtOptionA);
            Controls.Add(txtOptionB);
            Controls.Add(txtOptionC);
            Controls.Add(txtOptionD);
            Controls.Add(cboCorrectAnswer);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSaveToFile);
            Controls.Add(btnLoadFromFile);
            Name = "Form7";
            Text = "Question management";
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}