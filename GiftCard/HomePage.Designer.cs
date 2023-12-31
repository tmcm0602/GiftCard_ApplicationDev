﻿namespace GiftCard
{
    partial class HomePage
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            exitButton = new Button();
            logOutButton = new Button();
            giftButton = new Button();
            buyButton = new Button();
            viewButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Menu;
            label1.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(269, 9);
            label1.Name = "label1";
            label1.Size = new Size(229, 24);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Home Page";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(exitButton);
            groupBox1.Controls.Add(logOutButton);
            groupBox1.Controls.Add(giftButton);
            groupBox1.Controls.Add(buyButton);
            groupBox1.Controls.Add(viewButton);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(793, 351);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Functionalities";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(422, 215);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(183, 101);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit the Application";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += ExitButton_Click;
            // 
            // logOutButton
            // 
            logOutButton.Location = new Point(136, 215);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(183, 101);
            logOutButton.TabIndex = 3;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += LogOutButton_Click;
            // 
            // giftButton
            // 
            giftButton.Location = new Point(558, 43);
            giftButton.Name = "giftButton";
            giftButton.Size = new Size(183, 101);
            giftButton.TabIndex = 2;
            giftButton.Text = "Gift a friend";
            giftButton.UseVisualStyleBackColor = true;
            giftButton.Click += GiftButton_Click;
            // 
            // buyButton
            // 
            buyButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buyButton.Location = new Point(282, 43);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(183, 101);
            buyButton.TabIndex = 1;
            buyButton.Text = "Buy a new card";
            buyButton.UseVisualStyleBackColor = true;
            buyButton.Click += BuyButton_Click;
            // 
            // viewButton
            // 
            viewButton.Location = new Point(6, 43);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(183, 101);
            viewButton.TabIndex = 0;
            viewButton.Text = "View your gift cards";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Click += ViewButton_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "HomePage";
            Text = "Home Page";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button viewButton;
        private Button buyButton;
        private Button giftButton;
        private Button exitButton;
        private Button logOutButton;
    }
}