namespace Graham_Andrew
{
    partial class SpinningWheel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpinningWheel));
            this.mstSpiningWheel = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hintWithTheCurrentQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.pbLimit = new System.Windows.Forms.ProgressBar();
            this.btnSpin = new System.Windows.Forms.Button();
            this.tmrChngClr = new System.Windows.Forms.Timer(this.components);
            this.tmrStop = new System.Windows.Forms.Timer(this.components);
            this.tmrQestionLimit = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.lblCurrentScore = new System.Windows.Forms.Label();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.lblCurrentQuestion = new System.Windows.Forms.Label();
            this.lblQuestionON = new System.Windows.Forms.Label();
            this.lblPaused = new System.Windows.Forms.Label();
            this.tmrLogOut = new System.Windows.Forms.Timer(this.components);
            this.lblFirstLastName = new System.Windows.Forms.Label();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.pbxSpinningWheel = new System.Windows.Forms.PictureBox();
            this.mstSpiningWheel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpinningWheel)).BeginInit();
            this.SuspendLayout();
            // 
            // mstSpiningWheel
            // 
            this.mstSpiningWheel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.pauseStartToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.mstSpiningWheel.Location = new System.Drawing.Point(0, 0);
            this.mstSpiningWheel.Name = "mstSpiningWheel";
            this.mstSpiningWheel.Size = new System.Drawing.Size(831, 24);
            this.mstSpiningWheel.TabIndex = 2;
            this.mstSpiningWheel.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalHelpToolStripMenuItem,
            this.hintWithTheCurrentQuestionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // generalHelpToolStripMenuItem
            // 
            this.generalHelpToolStripMenuItem.Name = "generalHelpToolStripMenuItem";
            this.generalHelpToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.generalHelpToolStripMenuItem.Text = "General Help";
            this.generalHelpToolStripMenuItem.Click += new System.EventHandler(this.generalHelpToolStripMenuItem_Click);
            // 
            // hintWithTheCurrentQuestionToolStripMenuItem
            // 
            this.hintWithTheCurrentQuestionToolStripMenuItem.Name = "hintWithTheCurrentQuestionToolStripMenuItem";
            this.hintWithTheCurrentQuestionToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.hintWithTheCurrentQuestionToolStripMenuItem.Text = "Hint With the current Question";
            this.hintWithTheCurrentQuestionToolStripMenuItem.Click += new System.EventHandler(this.hintWithTheCurrentQuestionToolStripMenuItem_Click);
            // 
            // pauseStartToolStripMenuItem
            // 
            this.pauseStartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolStripMenuItem,
            this.startToolStripMenuItem});
            this.pauseStartToolStripMenuItem.Name = "pauseStartToolStripMenuItem";
            this.pauseStartToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.pauseStartToolStripMenuItem.Text = "Pause / Start";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // btnA
            // 
            this.btnA.Enabled = false;
            this.btnA.Location = new System.Drawing.Point(12, 397);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(374, 71);
            this.btnA.TabIndex = 3;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Enabled = false;
            this.btnB.Location = new System.Drawing.Point(445, 397);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(374, 71);
            this.btnB.TabIndex = 7;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Enabled = false;
            this.btnC.Location = new System.Drawing.Point(12, 474);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(374, 71);
            this.btnC.TabIndex = 8;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Enabled = false;
            this.btnD.Location = new System.Drawing.Point(445, 474);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(374, 71);
            this.btnD.TabIndex = 9;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(182, 303);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(430, 91);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "Question:\r\n\r\n\r\nOption A:\r\nOption B:\r\nOption C\r\nOption D:                         " +
    "                                                                                " +
    "                     ";
            // 
            // pbLimit
            // 
            this.pbLimit.Location = new System.Drawing.Point(703, 27);
            this.pbLimit.Name = "pbLimit";
            this.pbLimit.Size = new System.Drawing.Size(116, 23);
            this.pbLimit.TabIndex = 11;
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(715, 314);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(104, 77);
            this.btnSpin.TabIndex = 12;
            this.btnSpin.Text = "Press to Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // tmrChngClr
            // 
            this.tmrChngClr.Interval = 200;
            this.tmrChngClr.Tick += new System.EventHandler(this.tmrChngClr_Tick);
            // 
            // tmrStop
            // 
            this.tmrStop.Interval = 1000;
            this.tmrStop.Tick += new System.EventHandler(this.tmrStop_Tick);
            // 
            // tmrQestionLimit
            // 
            this.tmrQestionLimit.Interval = 1000;
            this.tmrQestionLimit.Tick += new System.EventHandler(this.tmrQestionLimit_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(728, 53);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(64, 13);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "Time Left:";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(753, 66);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(11, 13);
            this.lblTimeLeft.TabIndex = 14;
            this.lblTimeLeft.Text = " ";
            // 
            // lblScoreTitle
            // 
            this.lblScoreTitle.AutoSize = true;
            this.lblScoreTitle.Location = new System.Drawing.Point(1, 97);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(38, 13);
            this.lblScoreTitle.TabIndex = 15;
            this.lblScoreTitle.Text = "Score:";
            // 
            // lblCurrentScore
            // 
            this.lblCurrentScore.AutoSize = true;
            this.lblCurrentScore.Location = new System.Drawing.Point(45, 97);
            this.lblCurrentScore.Name = "lblCurrentScore";
            this.lblCurrentScore.Size = new System.Drawing.Size(10, 13);
            this.lblCurrentScore.TabIndex = 16;
            this.lblCurrentScore.Text = " ";
            this.lblCurrentScore.Click += new System.EventHandler(this.lblCurrentScore_Click);
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Location = new System.Drawing.Point(53, 97);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(18, 13);
            this.lblTotalScore.TabIndex = 17;
            this.lblTotalScore.Text = "/3";
            // 
            // lblCurrentQuestion
            // 
            this.lblCurrentQuestion.AutoSize = true;
            this.lblCurrentQuestion.Location = new System.Drawing.Point(4, 123);
            this.lblCurrentQuestion.Name = "lblCurrentQuestion";
            this.lblCurrentQuestion.Size = new System.Drawing.Size(89, 13);
            this.lblCurrentQuestion.TabIndex = 18;
            this.lblCurrentQuestion.Text = "Current Question:";
            // 
            // lblQuestionON
            // 
            this.lblQuestionON.AutoSize = true;
            this.lblQuestionON.Location = new System.Drawing.Point(99, 123);
            this.lblQuestionON.Name = "lblQuestionON";
            this.lblQuestionON.Size = new System.Drawing.Size(10, 13);
            this.lblQuestionON.TabIndex = 19;
            this.lblQuestionON.Text = " ";
            this.lblQuestionON.Click += new System.EventHandler(this.lblQuestionON_Click);
            // 
            // lblPaused
            // 
            this.lblPaused.AutoSize = true;
            this.lblPaused.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaused.Location = new System.Drawing.Point(171, 324);
            this.lblPaused.Name = "lblPaused";
            this.lblPaused.Size = new System.Drawing.Size(538, 50);
            this.lblPaused.TabIndex = 20;
            this.lblPaused.Text = "Paused\r\nTo resume click on start from the drop down menu";
            this.lblPaused.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPaused.Visible = false;
            // 
            // tmrLogOut
            // 
            this.tmrLogOut.Interval = 500;
            this.tmrLogOut.Tick += new System.EventHandler(this.tmrLogOut_Tick);
            // 
            // lblFirstLastName
            // 
            this.lblFirstLastName.AutoSize = true;
            this.lblFirstLastName.Location = new System.Drawing.Point(77, 37);
            this.lblFirstLastName.Name = "lblFirstLastName";
            this.lblFirstLastName.Size = new System.Drawing.Size(35, 13);
            this.lblFirstLastName.TabIndex = 22;
            this.lblFirstLastName.Text = "label1";
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.Location = new System.Drawing.Point(7, 27);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(64, 53);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAvatar.TabIndex = 21;
            this.pbxAvatar.TabStop = false;
            // 
            // pbxSpinningWheel
            // 
            this.pbxSpinningWheel.BackColor = System.Drawing.Color.Transparent;
            this.pbxSpinningWheel.Image = ((System.Drawing.Image)(resources.GetObject("pbxSpinningWheel.Image")));
            this.pbxSpinningWheel.InitialImage = null;
            this.pbxSpinningWheel.Location = new System.Drawing.Point(252, 27);
            this.pbxSpinningWheel.Name = "pbxSpinningWheel";
            this.pbxSpinningWheel.Size = new System.Drawing.Size(299, 263);
            this.pbxSpinningWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSpinningWheel.TabIndex = 1;
            this.pbxSpinningWheel.TabStop = false;
            // 
            // SpinningWheel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 551);
            this.Controls.Add(this.lblFirstLastName);
            this.Controls.Add(this.pbxAvatar);
            this.Controls.Add(this.lblPaused);
            this.Controls.Add(this.lblQuestionON);
            this.Controls.Add(this.lblCurrentQuestion);
            this.Controls.Add(this.lblTotalScore);
            this.Controls.Add(this.lblCurrentScore);
            this.Controls.Add(this.lblScoreTitle);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.pbLimit);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.pbxSpinningWheel);
            this.Controls.Add(this.mstSpiningWheel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mstSpiningWheel;
            this.Name = "SpinningWheel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spinning Wheel";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.Load += new System.EventHandler(this.SpinningWheel_Load);
            this.mstSpiningWheel.ResumeLayout(false);
            this.mstSpiningWheel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpinningWheel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxSpinningWheel;
        private System.Windows.Forms.MenuStrip mstSpiningWheel;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hintWithTheCurrentQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.ProgressBar pbLimit;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Timer tmrChngClr;
        private System.Windows.Forms.Timer tmrStop;
        private System.Windows.Forms.Timer tmrQestionLimit;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.Label lblCurrentScore;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.Label lblCurrentQuestion;
        private System.Windows.Forms.Label lblQuestionON;
        private System.Windows.Forms.Label lblPaused;
        private System.Windows.Forms.Timer tmrLogOut;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.Label lblFirstLastName;
    }
}

