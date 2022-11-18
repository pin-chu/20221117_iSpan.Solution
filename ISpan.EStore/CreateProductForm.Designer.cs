namespace ISpan.EStore
{
	partial class CreateProductForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.productNameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.listPriceTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
			this.productCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.saveButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "商品名稱:";
			// 
			// productNameTextBox
			// 
			this.productNameTextBox.Location = new System.Drawing.Point(108, 52);
			this.productNameTextBox.Name = "productNameTextBox";
			this.productNameTextBox.Size = new System.Drawing.Size(178, 22);
			this.productNameTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(46, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "牌價:";
			// 
			// listPriceTextBox
			// 
			this.listPriceTextBox.Location = new System.Drawing.Point(108, 80);
			this.listPriceTextBox.Name = "listPriceTextBox";
			this.listPriceTextBox.Size = new System.Drawing.Size(178, 22);
			this.listPriceTextBox.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(46, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "分類:";
			// 
			// categoryIdComboBox
			// 
			this.categoryIdComboBox.DataSource = this.productCategoryVMBindingSource;
			this.categoryIdComboBox.DisplayMember = "CategoryName";
			this.categoryIdComboBox.FormattingEnabled = true;
			this.categoryIdComboBox.Location = new System.Drawing.Point(108, 25);
			this.categoryIdComboBox.Name = "categoryIdComboBox";
			this.categoryIdComboBox.Size = new System.Drawing.Size(178, 20);
			this.categoryIdComboBox.TabIndex = 2;
			this.categoryIdComboBox.ValueMember = "Id";
			// 
			// productCategoryVMBindingSource
			// 
			this.productCategoryVMBindingSource.DataSource = typeof(ISpan.EStore.Models.ViewModels.ProductCategoryVM);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(211, 122);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 3;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// CreateProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(335, 171);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.categoryIdComboBox);
			this.Controls.Add(this.listPriceTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.productNameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "CreateProductForm";
			this.Text = "新增商品記錄";
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox productNameTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox listPriceTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox categoryIdComboBox;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.BindingSource productCategoryVMBindingSource;
	}
}