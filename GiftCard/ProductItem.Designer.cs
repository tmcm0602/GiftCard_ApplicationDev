namespace GiftCard
{
    partial class ProductItem
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
            pictureBoxProduct = new PictureBox();
            buttonPrice = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.Location = new Point(0, 0);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(216, 127);
            pictureBoxProduct.TabIndex = 0;
            pictureBoxProduct.TabStop = false;
            // 
            // buttonPrice
            // 
            buttonPrice.Location = new Point(63, 127);
            buttonPrice.Name = "buttonPrice";
            buttonPrice.Size = new Size(94, 29);
            buttonPrice.TabIndex = 1;
            buttonPrice.Text = "button1";
            buttonPrice.UseVisualStyleBackColor = true;
            // 
            // ProductItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonPrice);
            Controls.Add(pictureBoxProduct);
            Margin = new Padding(10);
            Name = "ProductItem";
            Size = new Size(216, 159);
            Load += ProductItem_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxProduct;
        private Button buttonPrice;
    }
}
