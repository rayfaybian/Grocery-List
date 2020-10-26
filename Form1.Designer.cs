namespace Grocery_List
{
    partial class Form1
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
            this.labProduct = new System.Windows.Forms.Label();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.labAmount = new System.Windows.Forms.Label();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labProduct
            // 
            this.labProduct.AutoSize = true;
            this.labProduct.Location = new System.Drawing.Point(47, 66);
            this.labProduct.Name = "labProduct";
            this.labProduct.Size = new System.Drawing.Size(57, 17);
            this.labProduct.TabIndex = 0;
            this.labProduct.Text = "Produkt";
            // 
            // tbProduct
            // 
            this.tbProduct.Location = new System.Drawing.Point(111, 66);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(235, 22);
            this.tbProduct.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(519, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 37);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Location = new System.Drawing.Point(650, 59);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(106, 37);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Entfernen";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(432, 66);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(59, 22);
            this.tbAmount.TabIndex = 4;
            // 
            // labAmount
            // 
            this.labAmount.AutoSize = true;
            this.labAmount.Location = new System.Drawing.Point(375, 66);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(51, 17);
            this.labAmount.TabIndex = 5;
            this.labAmount.Text = "Anzahl";
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 16;
            this.lbItems.Location = new System.Drawing.Point(48, 155);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(705, 244);
            this.lbItems.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.labAmount);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbProduct);
            this.Controls.Add(this.labProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labProduct;
        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label labAmount;
        private System.Windows.Forms.ListBox lbItems;
    }
}

