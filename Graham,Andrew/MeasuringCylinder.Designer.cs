namespace Graham_Andrew
{
    partial class MeasuringCylinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeasuringCylinder));
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.tbxGuess = new System.Windows.Forms.TextBox();
            this.lblSubmit = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnStartFill = new System.Windows.Forms.Button();
            this.btnStopFill = new System.Windows.Forms.Button();
            this.tmrFill = new System.Windows.Forms.Timer(this.components);
            this.lblFirstLastName = new System.Windows.Forms.Label();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.pbxMeasuringCylinder = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mstSpiningWheel = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hintWithTheCurrentQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxPause = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VerticalProgressBar = new Graham_Andrew.VerticalProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMeasuringCylinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.mstSpiningWheel.SuspendLayout();
            this.gbxPause.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Location = new System.Drawing.Point(568, 474);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(222, 74);
            this.btnSubmitAnswer.TabIndex = 1;
            this.btnSubmitAnswer.Text = "Submit Answer";
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // tbxGuess
            // 
            this.tbxGuess.Location = new System.Drawing.Point(568, 438);
            this.tbxGuess.Name = "tbxGuess";
            this.tbxGuess.Size = new System.Drawing.Size(222, 20);
            this.tbxGuess.TabIndex = 2;
            // 
            // lblSubmit
            // 
            this.lblSubmit.AutoSize = true;
            this.lblSubmit.Location = new System.Drawing.Point(546, 359);
            this.lblSubmit.Name = "lblSubmit";
            this.lblSubmit.Size = new System.Drawing.Size(273, 52);
            this.lblSubmit.TabIndex = 3;
            this.lblSubmit.Text = resources.GetString("lblSubmit.Text");
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(-1, 90);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(294, 52);
            this.lblInstruction.TabIndex = 4;
            this.lblInstruction.Text = resources.GetString("lblInstruction.Text");
            this.lblInstruction.Click += new System.EventHandler(this.lblInstruction_Click);
            // 
            // btnStartFill
            // 
            this.btnStartFill.Location = new System.Drawing.Point(12, 164);
            this.btnStartFill.Name = "btnStartFill";
            this.btnStartFill.Size = new System.Drawing.Size(75, 23);
            this.btnStartFill.TabIndex = 9;
            this.btnStartFill.Text = "Start Fill";
            this.btnStartFill.UseVisualStyleBackColor = true;
            this.btnStartFill.Click += new System.EventHandler(this.btnStartFill_Click);
            // 
            // btnStopFill
            // 
            this.btnStopFill.Enabled = false;
            this.btnStopFill.Location = new System.Drawing.Point(191, 164);
            this.btnStopFill.Name = "btnStopFill";
            this.btnStopFill.Size = new System.Drawing.Size(75, 23);
            this.btnStopFill.TabIndex = 10;
            this.btnStopFill.Text = "End Fill";
            this.btnStopFill.UseVisualStyleBackColor = true;
            this.btnStopFill.Click += new System.EventHandler(this.btnStopFill_Click);
            // 
            // tmrFill
            // 
            this.tmrFill.Tick += new System.EventHandler(this.tmrFill_Tick);
            // 
            // lblFirstLastName
            // 
            this.lblFirstLastName.AutoSize = true;
            this.lblFirstLastName.Location = new System.Drawing.Point(72, 24);
            this.lblFirstLastName.Name = "lblFirstLastName";
            this.lblFirstLastName.Size = new System.Drawing.Size(35, 13);
            this.lblFirstLastName.TabIndex = 24;
            this.lblFirstLastName.Text = "label1";
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.Location = new System.Drawing.Point(2, 24);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(64, 53);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAvatar.TabIndex = 23;
            this.pbxAvatar.TabStop = false;
            // 
            // pbxMeasuringCylinder
            // 
            this.pbxMeasuringCylinder.BackColor = System.Drawing.Color.Transparent;
            this.pbxMeasuringCylinder.Image = ((System.Drawing.Image)(resources.GetObject("pbxMeasuringCylinder.Image")));
            this.pbxMeasuringCylinder.Location = new System.Drawing.Point(312, 81);
            this.pbxMeasuringCylinder.Name = "pbxMeasuringCylinder";
            this.pbxMeasuringCylinder.Size = new System.Drawing.Size(217, 467);
            this.pbxMeasuringCylinder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMeasuringCylinder.TabIndex = 8;
            this.pbxMeasuringCylinder.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // mstSpiningWheel
            // 
            this.mstSpiningWheel.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mstSpiningWheel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.pauseStartToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.mstSpiningWheel.Location = new System.Drawing.Point(0, 0);
            this.mstSpiningWheel.Name = "mstSpiningWheel";
            this.mstSpiningWheel.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.mstSpiningWheel.Size = new System.Drawing.Size(831, 24);
            this.mstSpiningWheel.TabIndex = 25;
            this.mstSpiningWheel.Text = "mstMeasuringCylinder";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalHelpToolStripMenuItem,
            this.hintWithTheCurrentQuestionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // generalHelpToolStripMenuItem
            // 
            this.generalHelpToolStripMenuItem.Name = "generalHelpToolStripMenuItem";
            this.generalHelpToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.generalHelpToolStripMenuItem.Text = "General Help";
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
            this.pauseStartToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
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
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // gbxPause
            // 
            this.gbxPause.Controls.Add(this.label5);
            this.gbxPause.Location = new System.Drawing.Point(0, 24);
            this.gbxPause.Name = "gbxPause";
            this.gbxPause.Size = new System.Drawing.Size(831, 524);
            this.gbxPause.TabIndex = 32;
            this.gbxPause.TabStop = false;
            this.gbxPause.Text = "Paused";
            this.gbxPause.Visible = false;
            this.gbxPause.Enter += new System.EventHandler(this.gbxPause_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(175, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(538, 50);
            this.label5.TabIndex = 0;
            this.label5.Text = "Paused\r\nTo resume click on start from the drop down menu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VerticalProgressBar
            // 
            this.VerticalProgressBar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.VerticalProgressBar.Location = new System.Drawing.Point(312, 199);
            this.VerticalProgressBar.Maximum = 500;
            this.VerticalProgressBar.Name = "VerticalProgressBar";
            this.VerticalProgressBar.Size = new System.Drawing.Size(109, 325);
            this.VerticalProgressBar.Step = 5;
            this.VerticalProgressBar.TabIndex = 7;
            // 
            // MeasuringCylinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(831, 551);
            this.Controls.Add(this.mstSpiningWheel);
            this.Controls.Add(this.lblFirstLastName);
            this.Controls.Add(this.pbxAvatar);
            this.Controls.Add(this.btnStopFill);
            this.Controls.Add(this.btnStartFill);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblSubmit);
            this.Controls.Add(this.tbxGuess);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Controls.Add(this.VerticalProgressBar);
            this.Controls.Add(this.pbxMeasuringCylinder);
            this.Controls.Add(this.gbxPause);
            this.Name = "MeasuringCylinder";
            this.Text = "MeasuringCylinder";
            this.Load += new System.EventHandler(this.MeasuringCylinder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMeasuringCylinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.mstSpiningWheel.ResumeLayout(false);
            this.mstSpiningWheel.PerformLayout();
            this.gbxPause.ResumeLayout(false);
            this.gbxPause.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.TextBox tbxGuess;
        private System.Windows.Forms.Label lblSubmit;
        private System.Windows.Forms.Label lblInstruction;
        private VerticalProgressBar VerticalProgressBar;
        private System.Windows.Forms.PictureBox pbxMeasuringCylinder;
        private System.Windows.Forms.Button btnStartFill;
        private System.Windows.Forms.Button btnStopFill;
        private System.Windows.Forms.Timer tmrFill;
        private System.Windows.Forms.Label lblFirstLastName;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip mstSpiningWheel;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hintWithTheCurrentQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxPause;
        private System.Windows.Forms.Label label5;
    }
}