namespace StudyBuddy
{
    partial class SignUp_Form
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
            this.picboxImage = new System.Windows.Forms.PictureBox();
            this.panelSignUp = new System.Windows.Forms.Panel();
            this.chkboxShowPass = new System.Windows.Forms.CheckBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtboxLastName = new System.Windows.Forms.TextBox();
            this.chkboxShowPassRe = new System.Windows.Forms.CheckBox();
            this.lblToSignIn = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtboxPasswordRe = new System.Windows.Forms.TextBox();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).BeginInit();
            this.panelSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // picboxImage
            // 
            this.picboxImage.Image = global::StudyBuddy.Properties.Resources.Placeholder;
            this.picboxImage.Location = new System.Drawing.Point(354, 0);
            this.picboxImage.Name = "picboxImage";
            this.picboxImage.Size = new System.Drawing.Size(520, 541);
            this.picboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxImage.TabIndex = 1;
            this.picboxImage.TabStop = false;
            // 
            // panelSignUp
            // 
            this.panelSignUp.Controls.Add(this.chkboxShowPass);
            this.panelSignUp.Controls.Add(this.txtboxPassword);
            this.panelSignUp.Controls.Add(this.txtboxEmail);
            this.panelSignUp.Controls.Add(this.txtboxUsername);
            this.panelSignUp.Controls.Add(this.txtboxLastName);
            this.panelSignUp.Controls.Add(this.chkboxShowPassRe);
            this.panelSignUp.Controls.Add(this.lblToSignIn);
            this.panelSignUp.Controls.Add(this.btnSignUp);
            this.panelSignUp.Controls.Add(this.txtboxPasswordRe);
            this.panelSignUp.Controls.Add(this.txtboxFirstName);
            this.panelSignUp.Controls.Add(this.lblWelcome);
            this.panelSignUp.Location = new System.Drawing.Point(0, 0);
            this.panelSignUp.Name = "panelSignUp";
            this.panelSignUp.Size = new System.Drawing.Size(356, 541);
            this.panelSignUp.TabIndex = 2;
            // 
            // chkboxShowPass
            // 
            this.chkboxShowPass.AutoSize = true;
            this.chkboxShowPass.Font = new System.Drawing.Font("Archivo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxShowPass.Location = new System.Drawing.Point(44, 320);
            this.chkboxShowPass.Name = "chkboxShowPass";
            this.chkboxShowPass.Size = new System.Drawing.Size(104, 21);
            this.chkboxShowPass.TabIndex = 11;
            this.chkboxShowPass.Text = "Show password";
            this.chkboxShowPass.UseVisualStyleBackColor = true;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtboxPassword.Location = new System.Drawing.Point(40, 288);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '•';
            this.txtboxPassword.Size = new System.Drawing.Size(276, 29);
            this.txtboxPassword.TabIndex = 10;
            this.txtboxPassword.Text = "Password";
            this.txtboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxPassword.Enter += new System.EventHandler(this.txtboxPassword_Enter);
            this.txtboxPassword.Leave += new System.EventHandler(this.txtboxPassword_Leave);
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxEmail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtboxEmail.Location = new System.Drawing.Point(40, 246);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(276, 29);
            this.txtboxEmail.TabIndex = 9;
            this.txtboxEmail.Text = "Email Address";
            this.txtboxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxEmail.Enter += new System.EventHandler(this.txtboxEmail_Enter);
            this.txtboxEmail.Leave += new System.EventHandler(this.txtboxEmail_Leave);
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxUsername.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtboxUsername.Location = new System.Drawing.Point(40, 204);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(276, 29);
            this.txtboxUsername.TabIndex = 8;
            this.txtboxUsername.Text = "Username";
            this.txtboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxUsername.Enter += new System.EventHandler(this.txtboxUsername_Enter);
            this.txtboxUsername.Leave += new System.EventHandler(this.txtboxUsername_Leave);
            // 
            // txtboxLastName
            // 
            this.txtboxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxLastName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLastName.ForeColor = System.Drawing.Color.DimGray;
            this.txtboxLastName.Location = new System.Drawing.Point(182, 162);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(134, 29);
            this.txtboxLastName.TabIndex = 7;
            this.txtboxLastName.Text = "Last Name";
            this.txtboxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxLastName.Enter += new System.EventHandler(this.txtboxLastName_Enter);
            this.txtboxLastName.Leave += new System.EventHandler(this.txtboxLastName_Leave);
            // 
            // chkboxShowPassRe
            // 
            this.chkboxShowPassRe.AutoSize = true;
            this.chkboxShowPassRe.Font = new System.Drawing.Font("Archivo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxShowPassRe.Location = new System.Drawing.Point(43, 386);
            this.chkboxShowPassRe.Name = "chkboxShowPassRe";
            this.chkboxShowPassRe.Size = new System.Drawing.Size(104, 21);
            this.chkboxShowPassRe.TabIndex = 6;
            this.chkboxShowPassRe.Text = "Show password";
            this.chkboxShowPassRe.UseVisualStyleBackColor = true;
            // 
            // lblToSignIn
            // 
            this.lblToSignIn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToSignIn.Location = new System.Drawing.Point(110, 518);
            this.lblToSignIn.Name = "lblToSignIn";
            this.lblToSignIn.Size = new System.Drawing.Size(136, 14);
            this.lblToSignIn.TabIndex = 5;
            this.lblToSignIn.Text = "Already have an account?";
            this.lblToSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Archivo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(64, 424);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(208, 32);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            // 
            // txtboxPasswordRe
            // 
            this.txtboxPasswordRe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxPasswordRe.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPasswordRe.ForeColor = System.Drawing.Color.DimGray;
            this.txtboxPasswordRe.Location = new System.Drawing.Point(40, 354);
            this.txtboxPasswordRe.Name = "txtboxPasswordRe";
            this.txtboxPasswordRe.PasswordChar = '•';
            this.txtboxPasswordRe.Size = new System.Drawing.Size(276, 29);
            this.txtboxPasswordRe.TabIndex = 2;
            this.txtboxPasswordRe.Text = "Re-type Password";
            this.txtboxPasswordRe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxPasswordRe.Enter += new System.EventHandler(this.txtboxPasswordRe_Enter);
            this.txtboxPasswordRe.Leave += new System.EventHandler(this.txtboxPasswordRe_Leave);
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxFirstName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.txtboxFirstName.Location = new System.Drawing.Point(40, 162);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(134, 29);
            this.txtboxFirstName.TabIndex = 1;
            this.txtboxFirstName.Text = "First Name";
            this.txtboxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxFirstName.Enter += new System.EventHandler(this.txtboxFirstName_Enter);
            this.txtboxFirstName.Leave += new System.EventHandler(this.txtboxFirstName_Leave);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Italianno", 33.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(92, 60);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(165, 65);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignUp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 541);
            this.Controls.Add(this.panelSignUp);
            this.Controls.Add(this.picboxImage);
            this.Name = "SignUp_Form";
            this.Text = "SignUp_Form";
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).EndInit();
            this.panelSignUp.ResumeLayout(false);
            this.panelSignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxImage;
        private System.Windows.Forms.Panel panelSignUp;
        private System.Windows.Forms.CheckBox chkboxShowPassRe;
        private System.Windows.Forms.Label lblToSignIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtboxPasswordRe;
        private System.Windows.Forms.TextBox txtboxFirstName;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtboxLastName;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.CheckBox chkboxShowPass;
    }
}