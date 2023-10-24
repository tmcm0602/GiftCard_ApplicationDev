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
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(234, 148);
            pictureBoxProduct.TabIndex = 0;
            pictureBoxProduct.TabStop = false;
            pictureBoxProduct.Click += pictureBoxProduct_Click;
            // 
            // ProductItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBoxProduct);
            Margin = new Padding(10);
            Name = "ProductItem";
            Size = new Size(234, 148);
            Load += ProductItem_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxProduct;
    }
}
