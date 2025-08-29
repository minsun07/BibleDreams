namespace BibleDreams
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.userData = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.recentIssues = new System.Windows.Forms.Label();
            this.repeatOrNot = new System.Windows.Forms.Label();
            this.userEmotion = new System.Windows.Forms.Label();
            this.userStroy = new System.Windows.Forms.Label();
            this.drResult = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기록보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userData.SuspendLayout();
            this.drResult.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userData
            // 
            this.userData.Controls.Add(this.comboBox1);
            this.userData.Controls.Add(this.btnSend);
            this.userData.Controls.Add(this.textBox4);
            this.userData.Controls.Add(this.textBox2);
            this.userData.Controls.Add(this.textBox1);
            this.userData.Controls.Add(this.recentIssues);
            this.userData.Controls.Add(this.repeatOrNot);
            this.userData.Controls.Add(this.userEmotion);
            this.userData.Controls.Add(this.userStroy);
            this.userData.Location = new System.Drawing.Point(18, 35);
            this.userData.Name = "userData";
            this.userData.Size = new System.Drawing.Size(348, 395);
            this.userData.TabIndex = 0;
            this.userData.TabStop = false;
            this.userData.Text = "사용자 꿈 입력";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "반복 x",
            "2~4회",
            "5회 이상"});
            this.comboBox1.Location = new System.Drawing.Point(21, 248);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 9;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(108, 345);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(109, 34);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "결과 보기";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(21, 306);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(305, 21);
            this.textBox4.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(305, 21);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 118);
            this.textBox1.TabIndex = 4;
            // 
            // recentIssues
            // 
            this.recentIssues.AutoSize = true;
            this.recentIssues.Location = new System.Drawing.Point(19, 285);
            this.recentIssues.Name = "recentIssues";
            this.recentIssues.Size = new System.Drawing.Size(85, 12);
            this.recentIssues.TabIndex = 3;
            this.recentIssues.Text = "최근 주요 이슈";
            // 
            // repeatOrNot
            // 
            this.repeatOrNot.AutoSize = true;
            this.repeatOrNot.Location = new System.Drawing.Point(19, 231);
            this.repeatOrNot.Name = "repeatOrNot";
            this.repeatOrNot.Size = new System.Drawing.Size(57, 12);
            this.repeatOrNot.TabIndex = 2;
            this.repeatOrNot.Text = "반복 여부";
            // 
            // userEmotion
            // 
            this.userEmotion.AutoSize = true;
            this.userEmotion.Location = new System.Drawing.Point(19, 171);
            this.userEmotion.Name = "userEmotion";
            this.userEmotion.Size = new System.Drawing.Size(85, 12);
            this.userEmotion.TabIndex = 1;
            this.userEmotion.Text = "꿈의 감정 상태";
            // 
            // userStroy
            // 
            this.userStroy.AutoSize = true;
            this.userStroy.Location = new System.Drawing.Point(19, 23);
            this.userStroy.Name = "userStroy";
            this.userStroy.Size = new System.Drawing.Size(85, 12);
            this.userStroy.TabIndex = 0;
            this.userStroy.Text = "꿈의 주요 내용";
            // 
            // drResult
            // 
            this.drResult.Controls.Add(this.textBox5);
            this.drResult.Location = new System.Drawing.Point(383, 34);
            this.drResult.Name = "drResult";
            this.drResult.Size = new System.Drawing.Size(398, 396);
            this.drResult.TabIndex = 1;
            this.drResult.TabStop = false;
            this.drResult.Text = "최근 주요 이슈";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(24, 24);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(352, 355);
            this.textBox5.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.기록보기ToolStripMenuItem,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 기록보기ToolStripMenuItem
            // 
            this.기록보기ToolStripMenuItem.Name = "기록보기ToolStripMenuItem";
            this.기록보기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.기록보기ToolStripMenuItem.Text = "기록 보기";
            this.기록보기ToolStripMenuItem.Click += new System.EventHandler(this.기록보기ToolStripMenuItem_Click);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.정보ToolStripMenuItem.Text = "정보";
            this.정보ToolStripMenuItem.Click += new System.EventHandler(this.정보ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drResult);
            this.Controls.Add(this.userData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.userData.ResumeLayout(false);
            this.userData.PerformLayout();
            this.drResult.ResumeLayout(false);
            this.drResult.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox userData;
        private System.Windows.Forms.GroupBox drResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.Label recentIssues;
        private System.Windows.Forms.Label repeatOrNot;
        private System.Windows.Forms.Label userEmotion;
        private System.Windows.Forms.Label userStroy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem 기록보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
    }
}

