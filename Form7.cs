using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static group_01.Form6;
using System.Text.Json;
using static group_01.Form7;


namespace group_01
{
    public partial class Form7 : Form
    {
        public class Question
        {
            public string QuestionText { get; set; }
            public string OptionA { get; set; }
            public string OptionB { get; set; }
            public string OptionC { get; set; }
            public string OptionD { get; set; }
            public string CorrectAnswer { get; set; }
            public string UserAnswer { get; set; } // Có thể dùng cho Form6
        }

        private BindingList<Question> questionList = new BindingList<Question>();

        public Form7()
        {
            try
            {
                InitializeComponent();
                dgvQuestions.DataSource = questionList;
                cboCorrectAnswer.Items.AddRange(new[] { "A", "B", "C", "D" });
                if (File.Exists("questions.json"))
                {
                    string json = File.ReadAllText("questions.json");
                    var list = JsonSerializer.Deserialize<List<Question>>(json);
                    questionList.Clear();
                    foreach (var q in list)
                        questionList.Add(q);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInput()
        {
            txtQuestion.Clear();
            txtOptionA.Clear();
            txtOptionB.Clear();
            txtOptionC.Clear();
            txtOptionD.Clear();
            cboCorrectAnswer.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var q = new Question
                {
                    QuestionText = txtQuestion.Text,
                    OptionA = txtOptionA.Text,
                    OptionB = txtOptionB.Text,
                    OptionC = txtOptionC.Text,
                    OptionD = txtOptionD.Text,
                    CorrectAnswer = cboCorrectAnswer.Text
                };
                questionList.Add(q);
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvQuestions_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
            if (dgvQuestions.CurrentRow?.DataBoundItem is Question q)
            {
                txtQuestion.Text = q.QuestionText;
                txtOptionA.Text = q.OptionA;
                txtOptionB.Text = q.OptionB;
                txtOptionC.Text = q.OptionC;
                txtOptionD.Text = q.OptionD;
                cboCorrectAnswer.Text = q.CorrectAnswer;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
            if (dgvQuestions.CurrentRow?.DataBoundItem is Question q)
            {
                q.QuestionText = txtQuestion.Text;
                q.OptionA = txtOptionA.Text;
                q.OptionB = txtOptionB.Text;
                q.OptionC = txtOptionC.Text;
                q.OptionD = txtOptionD.Text;
                q.CorrectAnswer = cboCorrectAnswer.Text;
                dgvQuestions.Refresh();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvQuestions.CurrentRow?.DataBoundItem is Question q)
                {
                    questionList.Remove(q);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                string json = JsonSerializer.Serialize(questionList);
                File.WriteAllText("questions.json", json);
                MessageBox.Show("Save file sussess");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            if (File.Exists("questions.json"))
            {
                string json = File.ReadAllText("questions.json");
                var list = JsonSerializer.Deserialize<List<Question>>(json);
                questionList.Clear();
                foreach (var q in list)
                questionList.Add(q);
            }
            else
            {
                MessageBox.Show("File questions.json does not exit.");
            }
        }

        private DataGridView dgvQuestions;
        private TextBox txtQuestion, txtOptionA, txtOptionB, txtOptionC, txtOptionD;
        private ComboBox cboCorrectAnswer;
        private Button btnAdd, btnUpdate, btnDelete, btnSaveToFile, btnLoadFromFile;
    }

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
}
