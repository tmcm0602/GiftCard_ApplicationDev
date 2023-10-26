namespace GiftCard
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
            label1 = new Label();
            usernameTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            passwordTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(361, 75);
            label1.Name = "label1";
            label1.Size = new Size(89, 37);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(328, 152);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(161, 27);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 155);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 219);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(328, 216);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(161, 27);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(361, 264);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(passwordTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(usernameTextBox);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usernameTextBox;
        private Label label2;
        private Label label3;
        private TextBox passwordTextBox;
        private Button button1;
    }
}