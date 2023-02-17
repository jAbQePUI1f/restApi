namespace restApi
{
    partial class splashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splashScreen));
            this.bttnPostRetailer = new System.Windows.Forms.Button();
            this.bttnPostStock = new System.Windows.Forms.Button();
            this.bttnPostProduct = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // bttnPostRetailer
            // 
            this.bttnPostRetailer.Location = new System.Drawing.Point(49, 151);
            this.bttnPostRetailer.Name = "bttnPostRetailer";
            this.bttnPostRetailer.Size = new System.Drawing.Size(115, 57);
            this.bttnPostRetailer.TabIndex = 0;
            this.bttnPostRetailer.Text = "Retailers";
            this.bttnPostRetailer.UseVisualStyleBackColor = true;
            // 
            // bttnPostStock
            // 
            this.bttnPostStock.Location = new System.Drawing.Point(188, 151);
            this.bttnPostStock.Name = "bttnPostStock";
            this.bttnPostStock.Size = new System.Drawing.Size(115, 57);
            this.bttnPostStock.TabIndex = 1;
            this.bttnPostStock.Text = "Stocks";
            this.bttnPostStock.UseVisualStyleBackColor = true;
            // 
            // bttnPostProduct
            // 
            this.bttnPostProduct.Location = new System.Drawing.Point(323, 151);
            this.bttnPostProduct.Name = "bttnPostProduct";
            this.bttnPostProduct.Size = new System.Drawing.Size(115, 57);
            this.bttnPostProduct.TabIndex = 2;
            this.bttnPostProduct.Text = "Products";
            this.bttnPostProduct.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(105, 97);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(328, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // splashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 314);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bttnPostProduct);
            this.Controls.Add(this.bttnPostStock);
            this.Controls.Add(this.bttnPostRetailer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "splashScreen";
            this.Text = "RTDC Integrator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button bttnPostRetailer;
        private Button bttnPostStock;
        private Button bttnPostProduct;
        private ProgressBar progressBar1;
    }
}