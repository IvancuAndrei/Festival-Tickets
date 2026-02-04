namespace WindowsFormsApp1
{
    partial class LogInSignUpForm
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
    this.label1 = new System.Windows.Forms.Label();
    this.textBoxLogInEmail = new System.Windows.Forms.TextBox();
    this.textBoxLogInPassword = new System.Windows.Forms.TextBox();
    this.label2 = new System.Windows.Forms.Label();
    this.label3 = new System.Windows.Forms.Label();
    this.label4 = new System.Windows.Forms.Label();
    this.label5 = new System.Windows.Forms.Label();
    this.textBoxSignUpPassword = new System.Windows.Forms.TextBox();
    this.textBoxSignUpEmail = new System.Windows.Forms.TextBox();
    this.label6 = new System.Windows.Forms.Label();
    this.textBoxSignUpName = new System.Windows.Forms.TextBox();
    this.buttonLogIn = new System.Windows.Forms.Button();
    this.buttonSignUp = new System.Windows.Forms.Button();
    this.SuspendLayout();
    
    // Form properties
    this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245); // Light grey
    this.ClientSize = new System.Drawing.Size(600, 400);
    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
    this.Text = "Festival Tickets";

    // Header Label
    this.label1.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
    this.label1.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
    this.label1.Location = new System.Drawing.Point(0, 10);
    this.label1.Size = new System.Drawing.Size(600, 60);
    this.label1.Text = "Festival Tickets";
    this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

    // Login Section
    this.label2.Text = "Email";
    this.label2.Location = new System.Drawing.Point(50, 120);
    this.label2.Size = new System.Drawing.Size(50, 20);
    this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

    this.textBoxLogInEmail.Location = new System.Drawing.Point(110, 120);
    this.textBoxLogInEmail.Size = new System.Drawing.Size(150, 25);
    this.textBoxLogInEmail.BackColor = System.Drawing.Color.WhiteSmoke;
    this.textBoxLogInEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    this.label3.Text = "Password";
    this.label3.Location = new System.Drawing.Point(30, 160);
    this.label3.Size = new System.Drawing.Size(70, 20);
    this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

    this.textBoxLogInPassword.Location = new System.Drawing.Point(110, 160);
    this.textBoxLogInPassword.Size = new System.Drawing.Size(150, 25);
    this.textBoxLogInPassword.BackColor = System.Drawing.Color.WhiteSmoke;
    this.textBoxLogInPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    this.textBoxLogInPassword.PasswordChar = '*';

    this.buttonLogIn.Text = "Log In";
    this.buttonLogIn.Location = new System.Drawing.Point(110, 200);
    this.buttonLogIn.Size = new System.Drawing.Size(150, 30);
    this.buttonLogIn.BackColor = System.Drawing.Color.FromArgb(70, 130, 180); // SteelBlue
    this.buttonLogIn.ForeColor = System.Drawing.Color.White;
    this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    this.buttonLogIn.FlatAppearance.BorderSize = 0;
    this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);

    // SignUp Section
    this.label6.Text = "Name";
    this.label6.Location = new System.Drawing.Point(350, 120);
    this.label6.Size = new System.Drawing.Size(50, 20);
    this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

    this.textBoxSignUpName.Location = new System.Drawing.Point(410, 120);
    this.textBoxSignUpName.Size = new System.Drawing.Size(150, 25);
    this.textBoxSignUpName.BackColor = System.Drawing.Color.WhiteSmoke;
    this.textBoxSignUpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    this.label5.Text = "Email";
    this.label5.Location = new System.Drawing.Point(350, 155);
    this.label5.Size = new System.Drawing.Size(50, 20);
    this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

    this.textBoxSignUpEmail.Location = new System.Drawing.Point(410, 155);
    this.textBoxSignUpEmail.Size = new System.Drawing.Size(150, 25);
    this.textBoxSignUpEmail.BackColor = System.Drawing.Color.WhiteSmoke;
    this.textBoxSignUpEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    this.label4.Text = "Password";
    this.label4.Location = new System.Drawing.Point(350, 190);
    this.label4.Size = new System.Drawing.Size(50, 20);
    this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

    this.textBoxSignUpPassword.Location = new System.Drawing.Point(410, 190);
    this.textBoxSignUpPassword.Size = new System.Drawing.Size(150, 25);
    this.textBoxSignUpPassword.BackColor = System.Drawing.Color.WhiteSmoke;
    this.textBoxSignUpPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    this.textBoxSignUpPassword.PasswordChar = '*';

    this.buttonSignUp.Text = "Sign Up";
    this.buttonSignUp.Location = new System.Drawing.Point(410, 225);
    this.buttonSignUp.Size = new System.Drawing.Size(150, 30);
    this.buttonSignUp.BackColor = System.Drawing.Color.FromArgb(34, 139, 34); // ForestGreen
    this.buttonSignUp.ForeColor = System.Drawing.Color.White;
    this.buttonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    this.buttonSignUp.FlatAppearance.BorderSize = 0;
    this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);

    // Add controls to Form
    this.Controls.Add(this.label1);
    this.Controls.Add(this.label2);
    this.Controls.Add(this.textBoxLogInEmail);
    this.Controls.Add(this.label3);
    this.Controls.Add(this.textBoxLogInPassword);
    this.Controls.Add(this.buttonLogIn);
    this.Controls.Add(this.label6);
    this.Controls.Add(this.textBoxSignUpName);
    this.Controls.Add(this.label5);
    this.Controls.Add(this.textBoxSignUpEmail);
    this.Controls.Add(this.label4);
    this.Controls.Add(this.textBoxSignUpPassword);
    this.Controls.Add(this.buttonSignUp);

    this.ResumeLayout(false);
    this.PerformLayout();
}




        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Button buttonSignUp;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSignUpName;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSignUpPassword;
        private System.Windows.Forms.TextBox textBoxSignUpEmail;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox textBoxLogInPassword;

        private System.Windows.Forms.TextBox textBoxLogInEmail;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}