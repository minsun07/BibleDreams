using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibleDreams
{
    public partial class Form1 : Form
    {
        List<string> results;
        public Form1()
        {
            InitializeComponent();
            LoadResults();
        }

        private void LoadResults()
        {
            try
            {
                string filename = "results2.csv";
                results = File.ReadAllLines(filename).ToList();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"파일이 없어요.\n{ex.Message}", "파일이 없는 오류!");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"권한이 없어요.\n{ex.Message}", "파일 권한 오류!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했어요.\n{ex.Message}", "알 수 없는 오류!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        private void 기록보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistory form = Application.OpenForms["FormHistory"] as FormHistory;
            if(form != null)
            {
                form.Activate();
            }
            else
            {
                form = new FormHistory(); // this 써줘야함.
                form.Show();
            }
        }
        private string GetFortune()
        {
            Random random = new Random();
            int index = random.Next(0, results.Count);
            return results[index];
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string dreamContent = tbDreamContent.Text;
            string emotionState = tbEmotionState.Text;
            string repetition = comRepetition.SelectedItem.ToString();
            string recentIssue = tbRecentIssue.Text;
            string result = GetFortune();
            tbResult.Text = "꿈의 주요 내용: " + dreamContent + " " + Environment.NewLine +
                "꿈의 감정 상태: " + emotionState + " " + Environment.NewLine +
                "반복 여부: " + repetition + " " + Environment.NewLine +
                "최근 주요 이슈: " + recentIssue + " " + Environment.NewLine +
                "꿈 해몽: " + result;


        }
    }
}
