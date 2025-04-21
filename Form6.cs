using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace group_01
{
    //Form6.cs
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private int currentQuestionIndex = 0;
        private List<Question> questions = new List<Question>();
        private bool isSubmitted = false;

        private void SetRadioButtonsEnabled(bool enabled)
        {
            radioA.Enabled = enabled;
            radioB.Enabled = enabled;
            radioC.Enabled = enabled;
            radioD.Enabled = enabled;
        }


        // Lớp Question để lưu trữ câu hỏi và các đáp án
        public class Question
        {
            public string QuestionText { get; set; }
            public string OptionA { get; set; }
            public string OptionB { get; set; }
            public string OptionC { get; set; }
            public string OptionD { get; set; }
            public string CorrectAnswer { get; set; }
            public string UserAnswer { get; set; }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("questions.json"))
                {
                    string json = File.ReadAllText("questions.json");
                    var list = JsonSerializer.Deserialize<List<Question>>(json);
                    questions.Clear();
                    questions.AddRange(list);
                }

                listBoxQuestions.Items.Clear();
                for (int i = 0; i < questions.Count; i++)
                    listBoxQuestions.Items.Add($"Question {i + 1}");

                progressBar.Maximum = questions.Count;

                foreach (var q in questions)
                {
                    q.UserAnswer = ""; // reset toàn bộ đáp án
                }


                listBoxQuestions.SelectedIndex = 0; // chọn câu đầu tiên (gọi ShowQuestion qua event)
                }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hiển thị câu hỏi và đáp án
        private void ShowQuestion(int index)
        {
            try
            {
                if (index < 0 || index >= questions.Count) return;

                lblQuestion.Text = questions[index].QuestionText;
                radioA.Text = $"A. "+questions[index].OptionA;
                radioB.Text = $"B. "+questions[index].OptionB;
                radioC.Text = $"C. "+questions[index].OptionC;
                radioD.Text = $"D. "+questions[index].OptionD;

                // Reset hết radio button
                radioA.Checked = false;
                radioB.Checked = false;
                radioC.Checked = false;
                radioD.Checked = false;

                // Nếu có lựa chọn từ trước thì đánh dấu lại
                string userAnswer = questions[index].UserAnswer;
                if (userAnswer == "A") radioA.Checked = true;
                else if (userAnswer == "B") radioB.Checked = true;
                else if (userAnswer == "C") radioC.Checked = true;
                else if (userAnswer == "D") radioD.Checked = true;

                progressBar.Value = index + 1;
                SetRadioButtonsEnabled(!isSubmitted); // giữ trạng thái khóa/mở radio nếu đã submit
                }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void SaveUserAnswer()
        {
            try {
                string selected = "";
                if (radioA.Checked) selected = "A";
                else if (radioB.Checked) selected = "B";
                else if (radioC.Checked) selected = "C";
                else if (radioD.Checked) selected = "D";

                questions[currentQuestionIndex].UserAnswer = selected;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Khi nhấn nút Next
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                SaveUserAnswer(); // Save trước khi qua câu mới
                string json = JsonSerializer.Serialize(questions);
                File.WriteAllText("questions.json", json);
                if (currentQuestionIndex < questions.Count - 1)
                {
                    currentQuestionIndex++;
                    listBoxQuestions.SelectedIndex = currentQuestionIndex;
                    ShowQuestion(currentQuestionIndex);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                SaveUserAnswer(); // Save trước khi quay lại
                if (currentQuestionIndex > 0)
                {
                    currentQuestionIndex--;
                    listBoxQuestions.SelectedIndex = currentQuestionIndex;
                    ShowQuestion(currentQuestionIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveUserAnswer(); // Save khi chọn từ ListBox
            currentQuestionIndex = listBoxQuestions.SelectedIndex;
            ShowQuestion(currentQuestionIndex);
        }


        // Khi nhấn nút Submit
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SaveUserAnswer(); // đảm bảo đáp án hiện tại được lưu
                int score = 0;

                for (int i = 0; i < questions.Count; i++)
                {
                    string selected = questions[i].UserAnswer;
                    if (selected == questions[i].CorrectAnswer)
                        score++;
                }

                btnReview.Enabled = true;
                isSubmitted = true;
                SetRadioButtonsEnabled(false); // khóa các radio
                progressBar.Enabled = false;
                MessageBox.Show($"You scored {score}/{questions.Count}", "Test Result");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
        private void btnReview_Click(object sender, EventArgs e)
        {
            try
            {
                SaveUserAnswer();
                string reviewText = "";

                for (int i = 0; i < questions.Count; i++)
                {
                    var q = questions[i];
                    reviewText += $"Q{i + 1}: {q.QuestionText}\n";
                    reviewText += $"Your Answer: {q.UserAnswer}, Correct: {q.CorrectAnswer}\n\n";
                }
                SetRadioButtonsEnabled(!isSubmitted); // khóa nếu đã submit

                MessageBox.Show(reviewText, "Review Answers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
