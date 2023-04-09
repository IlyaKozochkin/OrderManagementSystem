namespace rkeeper1
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LogIn_button = new System.Windows.Forms.Button();
            this.Login_label = new System.Windows.Forms.Label();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogIn_button
            // 
            resources.ApplyResources(this.LogIn_button, "LogIn_button");
            this.LogIn_button.Name = "LogIn_button";
            this.LogIn_button.UseVisualStyleBackColor = true;
            this.LogIn_button.Click += new System.EventHandler(this.LogIn_button_Click);
            // 
            // Login_label
            // 
            resources.ApplyResources(this.Login_label, "Login_label");
            this.Login_label.Name = "Login_label";
            // 
            // Login_textBox
            // 
            resources.ApplyResources(this.Login_textBox, "Login_textBox");
            this.Login_textBox.Name = "Login_textBox";
            // 
            // Password_textBox
            // 
            resources.ApplyResources(this.Password_textBox, "Password_textBox");
            this.Password_textBox.Name = "Password_textBox";
            // 
            // Password_label
            // 
            resources.ApplyResources(this.Password_label, "Password_label");
            this.Password_label.Name = "Password_label";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Login_textBox);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.LogIn_button);
            this.Name = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LogIn_button;
        private Label Login_label;
        private TextBox Login_textBox;
        private TextBox Password_textBox;
        private Label Password_label;
    }
}