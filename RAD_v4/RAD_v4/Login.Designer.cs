namespace RAD_v4
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.KRTS = new System.Windows.Forms.Label();
            this.PleaseSignIn = new System.Windows.Forms.Label();
            this.UNameInput = new System.Windows.Forms.TextBox();
            this.PWordInput = new System.Windows.Forms.TextBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.UNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KRTS
            // 
            this.KRTS.AutoSize = true;
            this.KRTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KRTS.Location = new System.Drawing.Point(190, 42);
            this.KRTS.Name = "KRTS";
            this.KRTS.Size = new System.Drawing.Size(91, 31);
            this.KRTS.TabIndex = 0;
            this.KRTS.Text = "KRTS";
            this.KRTS.Click += new System.EventHandler(this.SignInButton_Click_1);
            // 
            // PleaseSignIn
            // 
            this.PleaseSignIn.AutoSize = true;
            this.PleaseSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PleaseSignIn.Location = new System.Drawing.Point(141, 91);
            this.PleaseSignIn.Name = "PleaseSignIn";
            this.PleaseSignIn.Size = new System.Drawing.Size(189, 29);
            this.PleaseSignIn.TabIndex = 1;
            this.PleaseSignIn.Text = "Please Sign In:";
            // 
            // UNameInput
            // 
            this.UNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNameInput.Location = new System.Drawing.Point(146, 164);
            this.UNameInput.Name = "UNameInput";
            this.UNameInput.Size = new System.Drawing.Size(184, 29);
            this.UNameInput.TabIndex = 2;
            this.UNameInput.Text = "Click here";
            this.UNameInput.TextChanged += new System.EventHandler(this.UNameInput_TextChanged);
            // 
            // PWordInput
            // 
            this.PWordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWordInput.Location = new System.Drawing.Point(146, 225);
            this.PWordInput.Name = "PWordInput";
            this.PWordInput.Size = new System.Drawing.Size(184, 29);
            this.PWordInput.TabIndex = 3;
            this.PWordInput.Text = "Click here";
            this.PWordInput.TextChanged += new System.EventHandler(this.PWordInput_TextChanged);
            // 
            // SignInButton
            // 
            this.SignInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInButton.FlatAppearance.BorderSize = 10;
            this.SignInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.SignInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.Location = new System.Drawing.Point(196, 298);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(85, 41);
            this.SignInButton.TabIndex = 4;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click_1);
            // 
            // UNameLabel
            // 
            this.UNameLabel.AutoSize = true;
            this.UNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNameLabel.Location = new System.Drawing.Point(38, 167);
            this.UNameLabel.Name = "UNameLabel";
            this.UNameLabel.Size = new System.Drawing.Size(102, 24);
            this.UNameLabel.TabIndex = 5;
            this.UNameLabel.Text = "Username:";
            this.UNameLabel.Click += new System.EventHandler(this.UNameLabel_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(38, 225);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(97, 24);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 391);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UNameLabel);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.PWordInput);
            this.Controls.Add(this.UNameInput);
            this.Controls.Add(this.PleaseSignIn);
            this.Controls.Add(this.KRTS);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KRTS;
        private System.Windows.Forms.Label PleaseSignIn;
        private System.Windows.Forms.TextBox UNameInput;
        private System.Windows.Forms.TextBox PWordInput;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Label UNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
    }
}
