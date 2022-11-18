using ISpan.Utility;
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
	public partial class ProductCategoriesForm : Form
	{
		DataTable categories;

		public ProductCategoriesForm()
		{
			InitializeComponent();

			DisplayProductCatetories();
		}

		private void DisplayProductCatetories()
		{
			string sql = @"SELECT [Id]
      ,[CategoryName]
      ,[DisplayOrder] FROM ProductCategories ORDER BY DisplayOrder";

			categories = new SqlDbHelper("default").Select(sql, null);

			BindData(categories);
		}

		private void BindData(DataTable model)
		{
			dataGridView1.DataSource = model;
		}

		private void addnewButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateProductCategoryForm();
			// frm.Show();
			DialogResult result = frm.ShowDialog();

			if(result == DialogResult.OK)
			{
				DisplayProductCatetories();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			DataRow row = this.categories.Rows[rowIndx]; // 使用者點到的那一筆記錄
			int id = row.Field<int>("Id"); // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditProductCategoryForm(id);
			// frm.Show();
			// DialogResult result = frm.ShowDialog();

			if (frm.ShowDialog() == DialogResult.OK )
			{
				DisplayProductCatetories();
			}
			//if (result == DialogResult.Abort)
			//{
			//	frm.Close();
			//}

			//DialogResult result = frm.ShowDialog();

			//if (result == DialogResult.OK || 
			//	result == DialogResult.Abort)
			//{
			//	DisplayProductCatetories();
			//}
			//if(result == DialogResult.Abort)
			//{
			//	frm.Close();
			//}

		}
	}
}
