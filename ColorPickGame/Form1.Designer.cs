namespace ColorPickGame
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AnsColor = new System.Windows.Forms.Label();
            this.RGBtext = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.NumericUpDown();
            this.G = new System.Windows.Forms.NumericUpDown();
            this.B = new System.Windows.Forms.NumericUpDown();
            this.Check = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            this.HighScore = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.StartNext = new System.Windows.Forms.Button();
            this.TimeUpdate = new System.Windows.Forms.Timer(this.components);
            this.PlusScore = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.HighScoreReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).BeginInit();
            this.SuspendLayout();
            // 
            // AnsColor
            // 
            this.AnsColor.BackColor = System.Drawing.Color.White;
            this.AnsColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnsColor.Location = new System.Drawing.Point(200, 0);
            this.AnsColor.Name = "AnsColor";
            this.AnsColor.Size = new System.Drawing.Size(400, 400);
            this.AnsColor.TabIndex = 0;
            // 
            // RGBtext
            // 
            this.RGBtext.AutoSize = true;
            this.RGBtext.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.RGBtext.Location = new System.Drawing.Point(50, 125);
            this.RGBtext.Name = "RGBtext";
            this.RGBtext.Size = new System.Drawing.Size(44, 99);
            this.RGBtext.TabIndex = 1;
            this.RGBtext.Text = "R:\r\nG:\r\nB:";
            // 
            // R
            // 
            this.R.Enabled = false;
            this.R.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.R.Location = new System.Drawing.Point(86, 128);
            this.R.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(64, 34);
            this.R.TabIndex = 2;
            // 
            // G
            // 
            this.G.Enabled = false;
            this.G.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.G.Location = new System.Drawing.Point(86, 161);
            this.G.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(64, 34);
            this.G.TabIndex = 3;
            // 
            // B
            // 
            this.B.Enabled = false;
            this.B.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.B.Location = new System.Drawing.Point(86, 194);
            this.B.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(64, 34);
            this.B.TabIndex = 4;
            // 
            // Check
            // 
            this.Check.Enabled = false;
            this.Check.Location = new System.Drawing.Point(50, 250);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(100, 100);
            this.Check.TabIndex = 5;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Progress
            // 
            this.Progress.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.Progress.Location = new System.Drawing.Point(40, 40);
            this.Progress.Name = "Progress";
            this.Progress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Progress.Size = new System.Drawing.Size(120, 40);
            this.Progress.TabIndex = 6;
            this.Progress.Text = "0/10";
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.Answer.Location = new System.Drawing.Point(643, 92);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(114, 132);
            this.Answer.TabIndex = 7;
            this.Answer.Text = "Answer\r\nR:\r\nG:\r\nB:";
            // 
            // HighScore
            // 
            this.HighScore.AutoSize = true;
            this.HighScore.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.HighScore.Location = new System.Drawing.Point(606, 373);
            this.HighScore.Name = "HighScore";
            this.HighScore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HighScore.Size = new System.Drawing.Size(147, 27);
            this.HighScore.TabIndex = 8;
            this.HighScore.Text = "HighScore:0";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Time.Location = new System.Drawing.Point(633, 33);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(134, 27);
            this.Time.TabIndex = 9;
            this.Time.Text = "00:00.0000";
            // 
            // StartNext
            // 
            this.StartNext.Location = new System.Drawing.Point(650, 250);
            this.StartNext.Name = "StartNext";
            this.StartNext.Size = new System.Drawing.Size(100, 100);
            this.StartNext.TabIndex = 10;
            this.StartNext.Text = "Start";
            this.StartNext.UseVisualStyleBackColor = true;
            this.StartNext.Click += new System.EventHandler(this.StartNext_Click);
            // 
            // TimeUpdate
            // 
            this.TimeUpdate.Enabled = true;
            this.TimeUpdate.Interval = 33;
            this.TimeUpdate.Tick += new System.EventHandler(this.TimeUpdate_Tick);
            // 
            // PlusScore
            // 
            this.PlusScore.AutoSize = true;
            this.PlusScore.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.PlusScore.Location = new System.Drawing.Point(140, 351);
            this.PlusScore.Name = "PlusScore";
            this.PlusScore.Size = new System.Drawing.Size(0, 22);
            this.PlusScore.TabIndex = 12;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Score.Location = new System.Drawing.Point(56, 373);
            this.Score.Name = "Score";
            this.Score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Score.Size = new System.Drawing.Size(98, 27);
            this.Score.TabIndex = 11;
            this.Score.Text = "Score:0";
            // 
            // HighScoreReset
            // 
            this.HighScoreReset.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.HighScoreReset.Location = new System.Drawing.Point(730, 356);
            this.HighScoreReset.Name = "HighScoreReset";
            this.HighScoreReset.Size = new System.Drawing.Size(59, 21);
            this.HighScoreReset.TabIndex = 13;
            this.HighScoreReset.Text = "Reset";
            this.HighScoreReset.UseVisualStyleBackColor = true;
            this.HighScoreReset.Click += new System.EventHandler(this.HighScoreReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.HighScoreReset);
            this.Controls.Add(this.PlusScore);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.StartNext);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.HighScore);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.B);
            this.Controls.Add(this.G);
            this.Controls.Add(this.R);
            this.Controls.Add(this.RGBtext);
            this.Controls.Add(this.AnsColor);
            this.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ColorPickGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AnsColor;
        private System.Windows.Forms.Label RGBtext;
        private System.Windows.Forms.NumericUpDown R;
        private System.Windows.Forms.NumericUpDown G;
        private System.Windows.Forms.NumericUpDown B;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Label Progress;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Label HighScore;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Button StartNext;
        private System.Windows.Forms.Timer TimeUpdate;
        private System.Windows.Forms.Label PlusScore;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button HighScoreReset;
    }
}

