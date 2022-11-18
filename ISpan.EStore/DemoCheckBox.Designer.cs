namespace ISpan.EStore
{
	partial class DemoCheckBox
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.getvalueButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.setvalueButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(50, 39);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(77, 16);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// getvalueButton
			// 
			this.getvalueButton.Location = new System.Drawing.Point(168, 39);
			this.getvalueButton.Name = "getvalueButton";
			this.getvalueButton.Size = new System.Drawing.Size(75, 23);
			this.getvalueButton.TabIndex = 1;
			this.getvalueButton.Text = "Get Value";
			this.getvalueButton.UseVisualStyleBackColor = true;
			this.getvalueButton.Click += new System.EventHandler(this.getvalueButton_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(50, 164);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 2;
			// 
			// setvalueButton
			// 
			this.setvalueButton.Location = new System.Drawing.Point(168, 162);
			this.setvalueButton.Name = "setvalueButton";
			this.setvalueButton.Size = new System.Drawing.Size(75, 23);
			this.setvalueButton.TabIndex = 3;
			this.setvalueButton.Text = "Set Value";
			this.setvalueButton.UseVisualStyleBackColor = true;
			this.setvalueButton.Click += new System.EventHandler(this.setvalueButton_Click);
			// 
			// DemoCheckBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 238);
			this.Controls.Add(this.setvalueButton);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.getvalueButton);
			this.Controls.Add(this.checkBox1);
			this.Name = "DemoCheckBox";
			this.Text = "DemoCheckBox";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button getvalueButton;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button setvalueButton;
	}
}