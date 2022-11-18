using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			errorProvider1.SetError(textBox1, "姓名必填");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			errorProvider1.SetError(textBox1, string.Empty);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			errorProvider1.SetError(textBox1, "姓名必填");
			errorProvider1.SetError(textBox2, "身高必需輸入整數");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			errorProvider1.Clear();
		}
	}
}
