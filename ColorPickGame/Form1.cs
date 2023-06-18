using ColorPickGame.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorPickGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int prog = 0;
        int AllScore = 0;
        int MaxScore = 0;
        DateTime StartTime = new DateTime();
        DateTime StopStartTime = new DateTime();
        private void Form1_Load(object sender, EventArgs e)
        {
            Settings.Default.Reload();
            MaxScore = Settings.Default.HighScore;
            HighScore.Text = $"HighScore:{MaxScore}";
        }

        private void StartNext_Click(object sender, EventArgs e)
        {
            if (StartNext.Text == "Start")
            {
                Reset();
                StartTime = DateTime.Now;
            }
            NewQ();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            R.Enabled = false;
            G.Enabled = false;
            B.Enabled = false;
            Check.Enabled = false;
            StartNext.Enabled = true;
            Answer.Text = $"Answer\nR:{AnsColor.BackColor.R}\nG:{AnsColor.BackColor.G}\nB:{AnsColor.BackColor.B}";
            StopStartTime = DateTime.Now;
            int Point = 765 - (Math.Abs(AnsColor.BackColor.R - (int)R.Value) + Math.Abs(AnsColor.BackColor.G - (int)G.Value) + Math.Abs(AnsColor.BackColor.B - (int)B.Value));
            AllScore += Point;
            PlusScore.Text = $"+{Point}";
            Score.Text = $"Score:{AllScore}";
            MaxScore = Math.Max(MaxScore, AllScore);
            HighScore.Text = $"HighScore:{MaxScore}";
            if (prog == 10)
                End();
        }
        private void Reset()
        {
            prog = 0;
            AllScore = 0;
            Progress.Text = "";
            Time.Text = "00:00.0000";
            Answer.Text = "Answer\nR:\nG:\nB:";
            Score.Text = "Score:0";
            R.Value = 0;
            G.Value = 0;
            B.Value = 0;
            R.Enabled = false;
            G.Enabled = false;
            B.Enabled = false;
            Check.Enabled = false;
        }
        private void NewQ()
        {
            if (prog > 0)
                StartTime += DateTime.Now - StopStartTime;
            R.Enabled = true;
            G.Enabled = true;
            B.Enabled = true;
            Check.Enabled = true;
            StartNext.Enabled = false;
            StartNext.Text = "Next";
            PlusScore.Text = "";
            Answer.Text = "Answer\nR:\nG:\nB:";
            R.Value = 0;
            G.Value = 0;
            B.Value = 0;
            Random random = new Random(DateTime.Now.Millisecond);
            AnsColor.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            prog++;
            Progress.Text = $"{prog}/10";

        }
        private void End()
        {
            StartNext.Text = "Start";
            Time.Text = (DateTime.Now - StartTime).ToString("mm\\:ss\\.ffff");
            HighScore.Text = $"HighScore:{MaxScore}";
            Settings.Default.HighScore = MaxScore;
            Settings.Default.Save();
        }

        private void TimeUpdate_Tick(object sender, EventArgs e)
        {
            if (prog != 0 && Check.Enabled)
                Time.Text = (DateTime.Now - StartTime).ToString("mm\\:ss\\.ffff");
        }

        private void HighScoreReset_Click(object sender, EventArgs e)
        {
            DialogResult ResetCheck = MessageBox.Show("ハイスコアをリセットしてもよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (ResetCheck == DialogResult.OK)
            {
                MaxScore = 0;
                HighScore.Text = "HighScore:0";
                Settings.Default.HighScore = 0;
                Settings.Default.Save();
            }
        }
    }
}
