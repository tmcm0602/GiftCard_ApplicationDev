namespace GiftCard
{
    partial class MainForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            menuStrip1 = new MenuStrip();
            myGiftCardsToolStripMenuItem = new ToolStripMenuItem();
            myGiftCardsToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.Location = new Point(53, 55);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 395);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.MediumSeaGreen;
            menuStrip1.Font = new Font("Segoe Fluent Icons", 14F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { myGiftCardsToolStripMenuItem, myGiftCardsToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(904, 42);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // myGiftCardsToolStripMenuItem
            // 
            myGiftCardsToolStripMenuItem.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Regular, GraphicsUnit.Point);
            myGiftCardsToolStripMenuItem.Name = "myGiftCardsToolStripMenuItem";
            myGiftCardsToolStripMenuItem.Size = new Size(93, 36);
            myGiftCardsToolStripMenuItem.Text = "Home";
            myGiftCardsToolStripMenuItem.Click += myGiftCardsToolStripMenuItem_Click;
            // 
            // myGiftCardsToolStripMenuItem1
            // 
            myGiftCardsToolStripMenuItem1.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Regular, GraphicsUnit.Point);
            myGiftCardsToolStripMenuItem1.Name = "myGiftCardsToolStripMenuItem1";
            myGiftCardsToolStripMenuItem1.Size = new Size(159, 36);
            myGiftCardsToolStripMenuItem1.Text = "MyGiftCards";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 451);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem myGiftCardsToolStripMenuItem;
        private ToolStripMenuItem myGiftCardsToolStripMenuItem1;
    }
}