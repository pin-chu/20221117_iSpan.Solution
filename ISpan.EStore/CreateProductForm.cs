using ISpan.EStore.Infra.Extensions;
using ISpan.EStore.Models.ViewModels;
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
	public partial class CreateProductForm : Form
	{
		public CreateProductForm()
		{
			InitializeComponent();

			InitForm();
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
				// .Prepend(new ProductCategoryVM { Id = 0, CategoryName = String.Empty })
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

		private void saveButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			int categoryId = ((ProductCategoryVM)this.categoryIdComboBox.SelectedItem).Id;
			string productName = productNameTextBox.Text;
			int listPrice = listPriceTextBox.Text.ToInt(-1); //如果没填牌價,傳回-1

			// 將它們繫結到ViewModel
			ProductVM model = new ProductVM { 
				CategoryId =categoryId,
				ProductName = productName,
				ListPrice = listPrice
			};

			// 針對ViewModel進行欄位驗證
			string errorMsg = string.Empty;
			if (string.IsNullOrEmpty(model.ProductName)) errorMsg += "商品名稱必填\r\n";
			if (model.ListPrice < 0) errorMsg += "牌價必需輸入大於或等於零的整數\r\n";

			if (string.IsNullOrEmpty(errorMsg) == false) {
				//表示至少一欄有錯誤
				MessageBox.Show(errorMsg);
				return; // 不再向下執行
			}


			// 如果通過驗證,就新增記錄
			string sql = @"INSERT INTO Products
(CategoryId,ProductName, ListPrice)
VALUES
(@CategoryId,@ProductName, @ListPrice)";

			var parameters = new SqlParameterBuilder()
				.AddInt("CategoryId", model.CategoryId)
				.AddNVarchar("ProductName", 50, model.ProductName)
				.AddInt("ListPrice", model.ListPrice)				
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}
	}
}
