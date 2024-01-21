namespace StudyBuddy
{
    partial class SignIn_Form
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
            this.panelSignIn = new System.Windows.Forms.Panel();
            this.chkboxShowPass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linllblForgotPass = new System.Windows.Forms.LinkLabel();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.lblWelcomeBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).BeginInit();
            this.panelSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // picboxImage
            // 
            this.picboxImage.Image = global::StudyBuddy.Properties.Resources.Placeholder;
            this.picboxImage.Location = new System.Drawing.Point(335, 0);
            this.picboxImage.Name = "picboxImage";
            this.picboxImage.Size = new System.Drawing.Size(465, 450);
            this.picboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxImage.TabIndex = 0;
            this.picboxImage.TabStop = false;
            // 
            // panelSignIn
            // 
            this.panelSignIn.Controls.Add(this.chkboxShowPass);
            this.panelSignIn.Controls.Add(this.label1);
            this.panelSignIn.Controls.Add(this.linllblForgotPass);
            this.panelSignIn.Controls.Add(this.btnSignIn);
            this.panelSignIn.Controls.Add(this.txtboxPassword);
            this.panelSignIn.Controls.Add(this.txtboxUsername);
            this.panelSignIn.Controls.Add(this.lblWelcomeBack);
            this.panelSignIn.Location = new System.Drawing.Point(0, 0);
            this.panelSignIn.Name = "panelSignIn";
            this.panelSignIn.Size = new System.Drawing.Size(336, 450);
            this.panelSignIn.TabIndex = 1;
            // 
            // chkboxShowPass
            // 
            this.chkboxShowPass.AutoSize = true;
            this.chkboxShowPass.Font = new System.Drawing.Font("Archivo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxShowPass.Location = new System.Drawing.Point(58, 274);
            this.chkboxShowPass.Name = "chkboxShowPass";
            this.chkboxShowPass.Size = new System.Drawing.Size(104, 21);
            this.chkboxShowPass.TabIndex = 6;
            this.chkboxShowPass.Text = "Show password";
            this.chkboxShowPass.UseVisualStyleBackColor = true;
            this.chkboxShowPass.CheckedChanged += new System.EventHandler(this.chkboxShowPass_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create an Account →";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linllblForgotPass
            // 
            this.linllblForgotPass.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linllblForgotPass.LinkColor = System.Drawing.Color.Black;
            this.linllblForgotPass.Location = new System.Drawing.Point(119, 347);
            this.linllblForgotPass.Name = "linllblForgotPass";
            this.linllblForgotPass.Size = new System.Drawing.Size(98, 14);
            this.linllblForgotPass.TabIndex = 4;
            this.linllblForgotPass.TabStop = true;
            this.linllblForgotPass.Text = "Forgot Password?";
            this.linllblForgotPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linllblForgotPass.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Archivo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(64, 312);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(208, 32);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtboxPassword.Location = new System.Drawing.Point(55, 242);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '•';
            this.txtboxPassword.Size = new System.Drawing.Size(226, 29);
            this.txtboxPassword.TabIndex = 2;
            this.txtboxPassword.Text = "Password";
            this.txtboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxPassword.Enter += new System.EventHandler(this.txtboxPassword_Enter);
            this.txtboxPassword.Leave += new System.EventHandler(this.txtboxPassword_Leave);
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxUsername.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtboxUsername.Location = new System.Drawing.Point(55, 179);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(226, 29);
            this.txtboxUsername.TabIndex = 1;
            this.txtboxUsername.Text = "Username or Email";
            this.txtboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxUsername.Enter += new System.EventHandler(this.txtboxUsername_Enter);
            this.txtboxUsername.Leave += new System.EventHandler(this.txtboxUsername_Leave);
            // 
            // lblWelcomeBack
            // 
            this.lblWelcomeBack.AutoSize = true;
            this.lblWelcomeBack.Font = new System.Drawing.Font("Italianno", 33.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeBack.Location = new System.Drawing.Point(44, 64);
            this.lblWelcomeBack.Name = "lblWelcomeBack";
            this.lblWelcomeBack.Size = new System.Drawing.Size(242, 65);
            this.lblWelcomeBack.TabIndex = 0;
            this.lblWelcomeBack.Text = "Welcome Back!";
            this.lblWelcomeBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignIn_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSignIn);
            this.Controls.Add(this.picboxImage);
            this.Name = "SignIn_Form";
            this.Text = "SignIn_Form";
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).EndInit();
            this.panelSignIn.ResumeLayout(false);
            this.panelSignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxImage;
        private System.Windows.Forms.Panel panelSignIn;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.Label lblWelcomeBack;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linllblForgotPass;
        private System.Windows.Forms.CheckBox chkboxShowPass;
    }
}