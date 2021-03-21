namespace CakeArtToSQL
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbSpecial = new System.Windows.Forms.RadioButton();
            this.rbCookie = new System.Windows.Forms.RadioButton();
            this.rbCake = new System.Windows.Forms.RadioButton();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.UpdateProduct = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.gbType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAdd.Location = new System.Drawing.Point(105, 287);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 37);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPrice.Location = new System.Drawing.Point(89, 97);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 20);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblName.Location = new System.Drawing.Point(89, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPrice.Location = new System.Drawing.Point(150, 94);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(105, 26);
            this.txtPrice.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtName.Location = new System.Drawing.Point(150, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(105, 26);
            this.txtName.TabIndex = 6;
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbSpecial);
            this.gbType.Controls.Add(this.rbCookie);
            this.gbType.Controls.Add(this.rbCake);
            this.gbType.Location = new System.Drawing.Point(150, 144);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(105, 105);
            this.gbType.TabIndex = 11;
            this.gbType.TabStop = false;
            this.gbType.Text = "Type";
            // 
            // rbSpecial
            // 
            this.rbSpecial.AutoSize = true;
            this.rbSpecial.Location = new System.Drawing.Point(29, 75);
            this.rbSpecial.Name = "rbSpecial";
            this.rbSpecial.Size = new System.Drawing.Size(60, 17);
            this.rbSpecial.TabIndex = 2;
            this.rbSpecial.TabStop = true;
            this.rbSpecial.Text = "Special";
            this.rbSpecial.UseVisualStyleBackColor = true;
            // 
            // rbCookie
            // 
            this.rbCookie.AutoSize = true;
            this.rbCookie.Location = new System.Drawing.Point(29, 52);
            this.rbCookie.Name = "rbCookie";
            this.rbCookie.Size = new System.Drawing.Size(58, 17);
            this.rbCookie.TabIndex = 1;
            this.rbCookie.TabStop = true;
            this.rbCookie.Text = "Cookie";
            this.rbCookie.UseVisualStyleBackColor = true;
            // 
            // rbCake
            // 
            this.rbCake.AutoSize = true;
            this.rbCake.Location = new System.Drawing.Point(29, 29);
            this.rbCake.Name = "rbCake";
            this.rbCake.Size = new System.Drawing.Size(50, 17);
            this.rbCake.TabIndex = 0;
            this.rbCake.TabStop = true;
            this.rbCake.Text = "Cake";
            this.rbCake.UseVisualStyleBackColor = true;
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DeleteProduct.Location = new System.Drawing.Point(106, 330);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(131, 36);
            this.DeleteProduct.TabIndex = 14;
            this.DeleteProduct.Text = "Delete Product";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // UpdateProduct
            // 
            this.UpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UpdateProduct.Location = new System.Drawing.Point(105, 372);
            this.UpdateProduct.Name = "UpdateProduct";
            this.UpdateProduct.Size = new System.Drawing.Size(132, 34);
            this.UpdateProduct.TabIndex = 15;
            this.UpdateProduct.Text = "Update Product";
            this.UpdateProduct.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.UpdateProduct.UseVisualStyleBackColor = true;
            this.UpdateProduct.Click += new System.EventHandler(this.UpdateProduct_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtID.Location = new System.Drawing.Point(150, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(105, 26);
            this.txtID.TabIndex = 16;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRefresh.Location = new System.Drawing.Point(486, 397);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(134, 30);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh Table";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblID.Location = new System.Drawing.Point(101, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 20);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "ID";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblResult.Location = new System.Drawing.Point(405, 58);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 26);
            this.lblResult.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.UpdateProduct);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton rbSpecial;
        private System.Windows.Forms.RadioButton rbCookie;
        private System.Windows.Forms.RadioButton rbCake;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button UpdateProduct;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblResult;
    }
}

