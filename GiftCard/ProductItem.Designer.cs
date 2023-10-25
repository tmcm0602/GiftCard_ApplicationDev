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
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.Anchor = AnchorStyles.None;
            pictureBoxProduct.Location = new Point(0, 0);
            pictureBoxProduct.Margin = new Padding(3, 2, 3, 2);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(205, 111);
            pictureBoxProduct.TabIndex = 0;
            pictureBoxProduct.TabStop = false;
            pictureBoxProduct.Click += product_CLick;
            // 
            // ProductItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBoxProduct);
            Margin = new Padding(9, 8, 9, 8);
            Name = "ProductItem";
            Size = new Size(205, 111);
            Load += ProductItem_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxProduct;
    }
}
