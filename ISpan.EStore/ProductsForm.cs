using ISpan.EStore.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore
{
	public partial class ProductsForm : Form
	{
		private ProductIndexVM[] products = null;
		public ProductsForm()
		{
			InitializeComponent();

			InitForm();

			// 顯示商品記錄
			DisplayProducts();

			
		}

		private void InitForm()
		{
			// 設定 categoryIdComboBox property
			categoryIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			var sql = "SELECT * FROM ProductCategories ORDER BY DisplayOrder";
			var dbHelper = new SqlDbHelper("default");

			List<ProductCategoryVM> categories = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToCategoryVM(row))
				.Prepend(new ProductCategoryVM { Id=0, CategoryName=String.Empty})
				.ToList();

			this.categoryIdComboBox.DataSource = categories;

		}

		private ProductCategoryVM ToCategoryVM(DataRow row)
		{
			return new ProductCategoryVM
			{
				Id = row.Field<int>("Id"),
				CategoryName = row.Field<string>("CategoryName"),
				DisplayOrder = row.Field<int>("DisplayOrder")
			};
		}


		private void DisplayProducts()
		{
			string sql = @"SELECT P.Id, P.ProductName, P.ListPrice, C.CategoryName
FROM Products P
INNER JOIN ProductCategories C ON P.CategoryId = C.Id";

			#region 加入 where 
			SqlParameter[] parameters = new SqlParameter[] { };
			
			//取得篩選值
			int categoryId = ((ProductCategoryVM)categoryIdComboBox.SelectedItem).Id;

			if (categoryId > 0)
			{
				sql += " WHERE CategoryId=@CategoryId";
				parameters = new SqlParameterBuilder()
					.AddInt("CategoryId", categoryId)
					.Build();
			}
			#endregion

			// 加入排序子句
			sql += " ORDER BY C.DisplayOrder, P.ProductName";
			var dbHelper = new SqlDbHelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			products = dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row))
				.ToArray();
			#region 冗長的版本
			//DataTable data = dbHelper.Select(sql, null);
			//List<ProductIndexVM> vmItems = new List<ProductIndexVM>();
			//foreach (DataRow row in data.Rows)
			//{
			//	ProductIndexVM vm = ParseToIndexVM(row);
			//	vmItems.Add(vm);
			//}
			//this.products = vmItems.ToArray();
			#endregion
			BindData(products);

			
		}
		private void BindData(ProductIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private ProductIndexVM ParseToIndexVM(DataRow row)
		{
			return new ProductIndexVM
			{
				Id = row.Field<int>("Id"),
				CategoryName = row.Field<string>("CategoryName"),
				ProductName = row.Field<string>("ProductName"),
				ListPrice = row.Field<int>("ListPrice"),
			};
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			DisplayProducts();
		}

		private void addnewButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateProductForm();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayProducts();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			ProductIndexVM row = this.products[rowIndx]; // 使用者點到的那一筆記錄

			int id = row.Id; // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditProductForm(id);
			
			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayProducts();
			}
			
		}
	}
}
