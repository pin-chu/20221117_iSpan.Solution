namespace ISpan.EStore
{
	partial class EditProductForm
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
			this.components = new System.ComponentModel.Container();
			this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
			this.listPriceTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.productNameTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.updateButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.productCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// categoryIdComboBox
			// 
			this.categoryIdComboBox.DisplayMember = "CategoryName";
			this.categoryIdComboBox.FormattingEnabled = true;
			this.categoryIdComboBox.Location = new System.Drawing.Point(115, 38);
			this.categoryIdComboBox.Name = "categoryIdComboBox";
			this.categoryIdComboBox.Size = new System.Drawing.Size(178, 20);
			this.categoryIdComboBox.TabIndex = 0;
			this.categoryIdComboBox.ValueMember = "Id";
			// 
			// listPriceTextBox
			// 
			this.listPriceTextBox.Location = new System.Drawing.Point(115, 93);
			this.listPriceTextBox.Name = "listPriceTextBox";
			this.listPriceTextBox.Size = new System.Drawing.Size(178, 22);
			this.listPriceTextBox.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(53, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "牌價:";
			// 
			// productNameTextBox
			// 
			this.productNameTextBox.Location = new System.Drawing.Point(115, 65);
			this.productNameTextBox.Name = "productNameTextBox";
			this.productNameTextBox.Size = new System.Drawing.Size(178, 22);
			this.productNameTextBox.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(53, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "分類:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(53, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "商品名稱:";
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(136, 121);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 3;
			this.updateButton.Text = "Update";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(217, 121);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 4;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// productCategoryVMBindingSource
			// 
			this.productCategoryVMBindingSource.DataSource = typeof(ISpan.EStore.Models.ViewModels.ProductCategoryVM);
			// 
			// EditProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(355, 200);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.categoryIdComboBox);
			this.Controls.Add(this.listPriceTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.productNameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "EditProductForm";
			this.Text = "編輯商品";
			this.Load += new System.EventHandler(this.EditProductForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox categoryIdComboBox;
		private System.Windows.Forms.TextBox listPriceTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox productNameTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource productCategoryVMBindingSource;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button deleteButton;
	}
}