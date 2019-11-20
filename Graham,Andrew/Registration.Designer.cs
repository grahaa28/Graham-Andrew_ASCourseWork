namespace Graham_Andrew
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.gbxRegistration = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.cbxAvatar = new System.Windows.Forms.ComboBox();
            this.gbxInstructions = new System.Windows.Forms.GroupBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.gbxRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            this.gbxInstructions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(39, 32);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(100, 20);
            this.tbxUserName.TabIndex = 0;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(164, 32);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbxFirstName.TabIndex = 1;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(164, 71);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(100, 20);
            this.tbxLastName.TabIndex = 2;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(39, 71);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxPassword.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(45, 16);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(45, 55);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(170, 16);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(169, 55);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name";
            // 
            // gbxRegistration
            // 
            this.gbxRegistration.Controls.Add(this.btnSubmit);
            this.gbxRegistration.Controls.Add(this.pbxAvatar);
            this.gbxRegistration.Controls.Add(this.lblAvatar);
            this.gbxRegistration.Controls.Add(this.cbxAvatar);
            this.gbxRegistration.Controls.Add(this.lblUsername);
            this.gbxRegistration.Controls.Add(this.lblLastName);
            this.gbxRegistration.Controls.Add(this.tbxUserName);
            this.gbxRegistration.Controls.Add(this.lblFirstName);
            this.gbxRegistration.Controls.Add(this.tbxFirstName);
            this.gbxRegistration.Controls.Add(this.lblPassword);
            this.gbxRegistration.Controls.Add(this.tbxLastName);
            this.gbxRegistration.Controls.Add(this.tbxPassword);
            this.gbxRegistration.Location = new System.Drawing.Point(498, 129);
            this.gbxRegistration.Name = "gbxRegistration";
            this.gbxRegistration.Size = new System.Drawing.Size(321, 306);
            this.gbxRegistration.TabIndex = 8;
            this.gbxRegistration.TabStop = false;
            this.gbxRegistration.Text = "Registration";
            this.gbxRegistration.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(113, 277);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Subit Details";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.Location = new System.Drawing.Point(90, 156);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(121, 103);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAvatar.TabIndex = 10;
            this.pbxAvatar.TabStop = false;
            // 
            // lblAvatar
            // 
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.Location = new System.Drawing.Point(135, 94);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(38, 13);
            this.lblAvatar.TabIndex = 9;
            this.lblAvatar.Text = "Avatar";
            // 
            // cbxAvatar
            // 
            this.cbxAvatar.FormattingEnabled = true;
            this.cbxAvatar.Items.AddRange(new object[] {
            "Albert Einstien",
            "Nieles Bohr",
            "Marie Curie",
            "Stephen Hawkings"});
            this.cbxAvatar.Location = new System.Drawing.Point(90, 110);
            this.cbxAvatar.Name = "cbxAvatar";
            this.cbxAvatar.Size = new System.Drawing.Size(121, 21);
            this.cbxAvatar.TabIndex = 8;
            this.cbxAvatar.SelectedIndexChanged += new System.EventHandler(this.cbxAvatar_SelectedIndexChanged);
            // 
            // gbxInstructions
            // 
            this.gbxInstructions.Controls.Add(this.lblInstructions);
            this.gbxInstructions.Location = new System.Drawing.Point(12, 184);
            this.gbxInstructions.Name = "gbxInstructions";
            this.gbxInstructions.Size = new System.Drawing.Size(321, 183);
            this.gbxInstructions.TabIndex = 9;
            this.gbxInstructions.TabStop = false;
            this.gbxInstructions.Text = "Instructions";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(0, 16);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(321, 169);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 551);
            this.Controls.Add(this.gbxInstructions);
            this.Controls.Add(this.gbxRegistration);
            this.DoubleBuffered = true;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.gbxRegistration.ResumeLayout(false);
            this.gbxRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            this.gbxInstructions.ResumeLayout(false);
            this.gbxInstructions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.GroupBox gbxRegistration;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.ComboBox cbxAvatar;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbxInstructions;
        private System.Windows.Forms.Label lblInstructions;
    }
}