namespace GiftCard
{
    partial class GiftFriends
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
            viewGiftCardsPanel = new FlowLayoutPanel();
            label1 = new Label();
            usernameBox = new TextBox();
            searchButton = new Button();
            informationBox = new RichTextBox();
            SuspendLayout();
            // 
            // viewGiftCardsPanel
            // 
            viewGiftCardsPanel.Location = new Point(12, 101);
            viewGiftCardsPanel.Name = "viewGiftCardsPanel";
            viewGiftCardsPanel.Size = new Size(776, 325);
            viewGiftCardsPanel.TabIndex = 0;
            viewGiftCardsPanel.Paint += viewGiftCardsPanel_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter the username:";
            label1.Click += label1_Click;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(191, 30);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(148, 23);
            usernameBox.TabIndex = 2;
            usernameBox.TextChanged += usernameBox_TextChanged;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(348, 30);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 3;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // informationBox
            // 
            informationBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            informationBox.Location = new Point(481, 12);
            informationBox.Name = "informationBox";
            informationBox.ReadOnly = true;
            informationBox.Size = new Size(307, 67);
            informationBox.TabIndex = 4;
            informationBox.Text = "";
            // 
            // GiftFriends
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 456);
            Controls.Add(informationBox);
            Controls.Add(searchButton);
            Controls.Add(usernameBox);
            Controls.Add(label1);
            Controls.Add(viewGiftCardsPanel);
            Name = "GiftFriends";
            Text = "Gift a Friend";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel viewGiftCardsPanel;
        private Label label1;
        private TextBox usernameBox;
        private Button searchButton;
        private RichTextBox informationBox;
    }
}