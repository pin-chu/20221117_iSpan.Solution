using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_CheckBoxList
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			CheckBox[] controls = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4};

			string value = string.Empty; //記錄被勾選的值
			foreach (CheckBox control in controls)
			{
				if (control.Checked) value += "," + control.Tag.ToString();
			}

			if (string.IsNullOrEmpty(value) == false) value = value.Substring(1); //將最前面的逗號刪除

			MessageBox.Show(value);
		}

		private void setvalueButton_Click(object sender, EventArgs e)
		{
			CheckBox[] controls = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4 };
			// 先將所有checkbox都取消勾選
			foreach(CheckBox control in controls)
			{
				control.Checked = false;
			}

			// 將textbox 值切割成array,並逐一找到對應的checkbox並勾選它
			Dictionary<string, CheckBox> map = new Dictionary<string, CheckBox>();
			foreach (CheckBox control in controls)
			{
				map.Add(control.Tag.ToString(), control);
			}

			string[] values = valueTextBox.Text.Split(',');
			foreach (string value in values)
			{
				if (map.ContainsKey(value) == false) continue;
				map[value].Checked = true;
			}
		}
	}
}
