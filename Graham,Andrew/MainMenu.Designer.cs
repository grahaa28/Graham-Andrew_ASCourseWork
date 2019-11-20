namespace Graham_Andrew
{
    partial class MainMenu
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
            this.btnLeaderBoard = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeaderBoard
            // 
            this.btnLeaderBoard.Location = new System.Drawing.Point(12, 402);
            this.btnLeaderBoard.Name = "btnLeaderBoard";
            this.btnLeaderBoard.Size = new System.Drawing.Size(168, 98);
            this.btnLeaderBoard.TabIndex = 0;
            this.btnLeaderBoard.Text = "Leaderboard";
            this.btnLeaderBoard.UseVisualStyleBackColor = true;
            this.btnLeaderBoard.Click += new System.EventHandler(this.btnLeaderBoard_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(635, 402);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(168, 98);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Quiz";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(323, 402);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(168, 98);
            this.btnPassword.TabIndex = 2;
            this.btnPassword.Text = "Change your Password";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Graham_Andrew.Properties.Resources._58287;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 512);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnLeaderBoard);
            this.DoubleBuffered = true;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeaderBoard;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPassword;
    }
}