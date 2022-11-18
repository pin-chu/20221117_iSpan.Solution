namespace ISpan.EStore
{
	partial class DemoGender
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
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.getvalueButton = new System.Windows.Forms.Button();
			this.setvalueButton = new System.Windows.Forms.Button();
			this.ucGender1 = new ISpan.EStore.Controls.ucGender();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(31, 183);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(85, 16);
			this.radioButton1.TabIndex = 4;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "radioButton1";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(122, 183);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(85, 16);
			this.radioButton2.TabIndex = 5;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "radioButton1";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// getvalueButton
			// 
			this.getvalueButton.Location = new System.Drawing.Point(233, 44);
			this.getvalueButton.Name = "getvalueButton";
			this.getvalueButton.Size = new System.Drawing.Size(75, 23);
			this.getvalueButton.TabIndex = 2;
			this.getvalueButton.Text = "Get Value";
			this.getvalueButton.UseVisualStyleBackColor = true;
			this.getvalueButton.Click += new System.EventHandler(this.getvalueButton_Click);
			// 
			// setvalueButton
			// 
			this.setvalueButton.Location = new System.Drawing.Point(233, 74);
			this.setvalueButton.Name = "setvalueButton";
			this.setvalueButton.Size = new System.Drawing.Size(75, 23);
			this.setvalueButton.TabIndex = 3;
			this.setvalueButton.Text = "Set Value";
			this.setvalueButton.UseVisualStyleBackColor = true;
			this.setvalueButton.Click += new System.EventHandler(this.setvalueButton_Click);
			// 
			// ucGender1
			// 
			this.ucGender1.Location = new System.Drawing.Point(48, 30);
			this.ucGender1.Name = "ucGender1";
			this.ucGender1.Size = new System.Drawing.Size(152, 38);
			this.ucGender1.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(100, 76);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 0;
			// 
			// DemoGender
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.setvalueButton);
			this.Controls.Add(this.getvalueButton);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.ucGender1);
			this.Name = "DemoGender";
			this.Text = "DemoGender";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Controls.ucGender ucGender1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Button getvalueButton;
		private System.Windows.Forms.Button setvalueButton;
		private System.Windows.Forms.TextBox textBox1;
	}
}