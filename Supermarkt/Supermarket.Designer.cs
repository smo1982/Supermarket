namespace Supermarkt
{
    partial class Supermarket
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbInsertProducts = new System.Windows.Forms.TextBox();
            this.tbInsertValue = new System.Windows.Forms.TextBox();
            this.btPlus = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.lBoxProducts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbInsertProducts
            // 
            this.tbInsertProducts.Location = new System.Drawing.Point(46, 25);
            this.tbInsertProducts.Name = "tbInsertProducts";
            this.tbInsertProducts.Size = new System.Drawing.Size(251, 22);
            this.tbInsertProducts.TabIndex = 0;
            // 
            // tbInsertValue
            // 
            this.tbInsertValue.Location = new System.Drawing.Point(340, 25);
            this.tbInsertValue.Name = "tbInsertValue";
            this.tbInsertValue.Size = new System.Drawing.Size(71, 22);
            this.tbInsertValue.TabIndex = 1;
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(439, 23);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(93, 41);
            this.btPlus.TabIndex = 2;
            this.btPlus.Text = "Hinzufügen";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btMinus
            // 
            this.btMinus.Location = new System.Drawing.Point(564, 23);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(86, 41);
            this.btMinus.TabIndex = 3;
            this.btMinus.Text = "Entfernen";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // lBoxProducts
            // 
            this.lBoxProducts.FormattingEnabled = true;
            this.lBoxProducts.ItemHeight = 16;
            this.lBoxProducts.Location = new System.Drawing.Point(68, 116);
            this.lBoxProducts.Name = "lBoxProducts";
            this.lBoxProducts.Size = new System.Drawing.Size(282, 308);
            this.lBoxProducts.TabIndex = 4;
            // 
            // Supermarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lBoxProducts);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.tbInsertValue);
            this.Controls.Add(this.tbInsertProducts);
            this.Name = "Supermarket";
            this.Text = "Supermarket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInsertProducts;
        private System.Windows.Forms.TextBox tbInsertValue;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.ListBox lBoxProducts;
    }
}

