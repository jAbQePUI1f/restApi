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
            this.bttnPostSales = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
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
            // bttnPostSales
            // 
            this.bttnPostSales.Location = new System.Drawing.Point(323, 151);
            this.bttnPostSales.Name = "bttnPostSales";
            this.bttnPostSales.Size = new System.Drawing.Size(115, 57);
            this.bttnPostSales.TabIndex = 2;
            this.bttnPostSales.Text = "Sales";
            this.bttnPostSales.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(49, 97);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(392, 102);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(47, 15);
            this.lblLoading.TabIndex = 4;
            this.lblLoading.Text = "loading";
            // 
            // splashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 314);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bttnPostSales);
            this.Controls.Add(this.bttnPostStock);
            this.Controls.Add(this.bttnPostRetailer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "splashScreen";
            this.Text = "RTDC Integrator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bttnPostRetailer;
        private Button bttnPostStock;
        private Button bttnPostSales;
        private ProgressBar progressBar1;
        private Label lblLoading;
    }
}