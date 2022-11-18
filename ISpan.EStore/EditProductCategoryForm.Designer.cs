namespace ISpan.EStore
{
	partial class EditProductCategoryForm
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
			this.deleteButton = new System.Windows.Forms.Button();
			this.displayOrderTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.categoryNameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.updateButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(218, 78);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 3;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// displayOrderTextBox
			// 
			this.displayOrderTextBox.Location = new System.Drawing.Point(115, 50);
			this.displayOrderTextBox.Name = "displayOrderTextBox";
			this.displayOrderTextBox.Size = new System.Drawing.Size(178, 22);
			this.displayOrderTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(53, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "顯示順序:";
			// 
			// categoryNameTextBox
			// 
			this.categoryNameTextBox.Location = new System.Drawing.Point(115, 22);
			this.categoryNameTextBox.Name = "categoryNameTextBox";
			this.categoryNameTextBox.Size = new System.Drawing.Size(178, 22);
			this.categoryNameTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(53, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "分類名稱:";
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(137, 78);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(75, 23);
			this.updateButton.TabIndex = 2;
			this.updateButton.Text = "Update";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// EditProductCategoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(345, 144);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.displayOrderTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.categoryNameTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "EditProductCategoryForm";
			this.Text = "編輯商品分類";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.TextBox displayOrderTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox categoryNameTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button updateButton;
	}
}