using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore
{
	public partial class DemoGender : Form
	{
		public DemoGender()
		{
			InitializeComponent();
		}

		private void getvalueButton_Click(object sender, EventArgs e)
		{
			int gender = this.ucGender1.GetValue();

			MessageBox.Show(gender.ToString());
		}

		private void setvalueButton_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(textBox1.Text, out int number);
			int value = isInt ? number : -1;

			this.ucGender1.SetValue(value);
		}
	}
}
