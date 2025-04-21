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
            txtQuestion.Text = "Câu hỏi ";
            // 
            // txtOptionA
            // 
            txtOptionA.Location = new Point(494, 238);
            txtOptionA.Name = "txtOptionA";
            txtOptionA.Size = new Size(276, 27);
            txtOptionA.TabIndex = 4;
            txtOptionA.Text = "A. ?";
            // 
            // txtOptionB
            // 
            txtOptionB.Location = new Point(494, 290);
            txtOptionB.Name = "txtOptionB";
            txtOptionB.Size = new Size(276, 27);
            txtOptionB.TabIndex = 6;
            txtOptionB.Text = "B. ?";
            // 
            // txtOptionC
            // 
            txtOptionC.Location = new Point(494, 341);
            txtOptionC.Name = "txtOptionC";
            txtOptionC.Size = new Size(276, 27);
            txtOptionC.TabIndex = 8;
            txtOptionC.Text = "C. ?";
            // 
            // txtOptionD
            // 
            txtOptionD.Location = new Point(494, 395);
            txtOptionD.Name = "txtOptionD";
            txtOptionD.Size = new Size(276, 27);
            txtOptionD.TabIndex = 10;
            txtOptionD.Text = "D. ?";
            // 
            // cboCorrectAnswer
            // 
            cboCorrectAnswer.Location = new Point(494, 441);
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
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(93, 49);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(87, 28);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(186, 48);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 28);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSaveToFile
            // 
            btnSaveToFile.Location = new Point(267, 48);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.Size = new Size(102, 28);
            btnSaveToFile.TabIndex = 16;
            btnSaveToFile.Text = "Lưu vào file";
            btnSaveToFile.Click += btnSaveToFile_Click;
            // 
            // btnLoadFromFile
            // 
            btnLoadFromFile.Location = new Point(375, 48);
            btnLoadFromFile.Name = "btnLoadFromFile";
            btnLoadFromFile.Size = new Size(89, 28);
            btnLoadFromFile.TabIndex = 17;
            btnLoadFromFile.Text = "Tải từ file";
            btnLoadFromFile.Click += btnLoadFromFile_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
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
            Text = "Quản lý câu hỏi";
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}