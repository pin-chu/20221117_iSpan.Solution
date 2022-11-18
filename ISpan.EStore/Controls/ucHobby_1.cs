using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ISpan.EStore.Controls
{
	public partial class ucHobby : UserControl
	{
		public ucHobby()
		{
			InitializeComponent();
		}

		public string GetValue() {
			CheckBox[] controls = new CheckBox[] {checkBox1, checkBox2, checkBox3,
													checkBox4, checkBox5, checkBox6 };

			string value = string.Empty; //記錄哪些值被勾選
			foreach (CheckBox item in controls)
			{
				if (item.Checked)
				{
					value += "," + item.Tag.ToString();
				}
			}
			if (string.IsNullOrEmpty(value) == false)
			{
				value = value.Substring(1); // 把最前面的逗號刪除
			}
			
			return value;

		}

		public void SetValue(string valueInDb)
		{
			CheckBox[] controls = new CheckBox[] {checkBox1, checkBox2, checkBox3,
													checkBox4, checkBox5, checkBox6 };
			// 先將所有checkbox取消勾選
			foreach (CheckBox item in controls)
			{
				item.Checked = false;
			}

			if (string.IsNullOrEmpty(valueInDb)) return;

			// 找出checkbox, tag 對照表
			Dictionary<string, CheckBox> map = new Dictionary<string, CheckBox>();

			// [{"A", checkbox1}, {"B", checkbox2}, {"C", checkbox3},,,,,]
			foreach (CheckBox item in controls)
			{
				map.Add(item.Tag.ToString(), item);
			}

			//根據 valueInDb值,決定哪些checkbox要勾選
			string[] values = valueInDb.Split(','); // {"C","F", "XXXX"}
			foreach (string key in values)
			{
				if (map.ContainsKey(key))
				{
					CheckBox control = map[key];
					control.Checked = true;
				}
			}
		}
	}
}
