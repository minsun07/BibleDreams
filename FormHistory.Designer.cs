namespace BibleDreams
{
    partial class FormHistory
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
            this.btnSend = new System.Windows.Forms.Button();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(25, 18);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(341, 45);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "내역 불러오기";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // lbHistory
            // 
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.ItemHeight = 12;
            this.lbHistory.Items.AddRange(new object[] {
            "2025-08-24 13:00:01 - 20071201 03 - 길을 잃고 헤매다가 빛을 따라 걷는 꿈",
            "2025-08-24 13:01:01 - 20071201 03 - 낡은 집을 깨끗하게 청소하고 새롭게 꾸미는 꿈",
            "2025-08-24 13:03:01 - 20071201 03 - 사막 한가운데서 오아시스를 발견하는 꿈",
            "2025-08-24 13:05:01 - 20071201 03 - 물이 가득 찬 맑고 투명한 바다를 걷는 꿈",
            "2025-08-24 13:06:01 - 20071201 03 - 높은 절벽 끝에 서 있는데, 아래로 떨어지는 꿈"});
            this.lbHistory.Location = new System.Drawing.Point(24, 83);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(341, 328);
            this.lbHistory.TabIndex = 1;
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.btnSend);
            this.Name = "FormHistory";
            this.Text = "FormHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lbHistory;
    }
}