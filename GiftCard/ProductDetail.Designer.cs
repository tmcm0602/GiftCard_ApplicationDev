namespace GiftCard
{
    partial class ProductDetail
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            richTextBox1 = new RichTextBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(297, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 29);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 373);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 51);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 0;
            label2.Text = "Brand:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 98);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 1;
            label3.Text = "Gift Card Name:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 146);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 2;
            label4.Text = "Description:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(117, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 26);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(170, 98);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(154, 26);
            textBox3.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(37, 181);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(287, 159);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(372, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(416, 382);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Purchase Options";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 48);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 48);
            label6.Name = "label6";
            label6.Size = new Size(165, 20);
            label6.TabIndex = 1;
            label6.Text = "Wallet Options (A$)";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 82);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(165, 264);
            listBox1.TabIndex = 2;
            // 
            // ProductDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ProductDetail";
            Text = "Product Details";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RichTextBox richTextBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private Label label5;
        private ListBox listBox1;
        private Label label6;
    }
}