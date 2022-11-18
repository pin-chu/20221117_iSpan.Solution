namespace ISpan.EStore
{
	partial class DemoCheckBoxList
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
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.getvalueButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.setvalueButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(52, 32);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(77, 16);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Tag = "A";
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(135, 32);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(77, 16);
			this.checkBox2.TabIndex = 0;
			this.checkBox2.Tag = "B";
			this.checkBox2.Text = "checkBox2";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(218, 32);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(77, 16);
			this.checkBox3.TabIndex = 0;
			this.checkBox3.Tag = "C";
			this.checkBox3.Text = "checkBox3";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new System.Drawing.Point(52, 54);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(77, 16);
			this.checkBox4.TabIndex = 0;
			this.checkBox4.Tag = "D";
			this.checkBox4.Text = "checkBox4";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// checkBox5
			// 
			this.checkBox5.AutoSize = true;
			this.checkBox5.Location = new System.Drawing.Point(135, 54);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(77, 16);
			this.checkBox5.TabIndex = 0;
			this.checkBox5.Tag = "E";
			this.checkBox5.Text = "checkBox5";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// checkBox6
			// 
			this.checkBox6.AutoSize = true;
			this.checkBox6.Location = new System.Drawing.Point(218, 54);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(77, 16);
			this.checkBox6.TabIndex = 0;
			this.checkBox6.Tag = "F";
			this.checkBox6.Text = "checkBox6";
			this.checkBox6.UseVisualStyleBackColor = true;
			// 
			// getvalueButton
			// 
			this.getvalueButton.Location = new System.Drawing.Point(345, 41);
			this.getvalueButton.Name = "getvalueButton";
			this.getvalueButton.Size = new System.Drawing.Size(75, 23);
			this.getvalueButton.TabIndex = 1;
			this.getvalueButton.Text = "Get Value";
			this.getvalueButton.UseVisualStyleBackColor = true;
			this.getvalueButton.Click += new System.EventHandler(this.getvalueButton_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(52, 174);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 2;
			// 
			// setvalueButton
			// 
			this.setvalueButton.Location = new System.Drawing.Point(173, 172);
			this.setvalueButton.Name = "setvalueButton";
			this.setvalueButton.Size = new System.Drawing.Size(75, 23);
			this.setvalueButton.TabIndex = 3;
			this.setvalueButton.Text = "Set Value";
			this.setvalueButton.UseVisualStyleBackColor = true;
			this.setvalueButton.Click += new System.EventHandler(this.setvalueButton_Click);
			// 
			// DemoCheckBoxList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(475, 231);
			this.Controls.Add(this.setvalueButton);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.getvalueButton);
			this.Controls.Add(this.checkBox6);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox5);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.checkBox1);
			this.Name = "DemoCheckBoxList";
			this.Text = "DemoCheckBoxList";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.Button getvalueButton;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button setvalueButton;
	}
}