using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_CheckBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			bool isChecked = this.checkBox1.Checked;

			string message = (isChecked) ? "有勾選" : "沒有勾選";

			MessageBox.Show(message);
		}

		private void setvalueButton_Click(object sender, EventArgs e)
		{
			bool isChecked = valueTextBox.Text == "1";
			checkBox1.Checked = isChecked;
		}
	}
}
