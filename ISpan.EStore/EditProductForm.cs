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
	public partial class EditProductForm : Form
	{
		private int id;
		public EditProductForm(int id)
		{
			InitializeComponent();
			InitForm();
			this.id = id;
		}
		private void EditProductForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			string sql = "SELECT * FROM Products WHERE Id=@Id";
			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉, 找不到要編輯的記錄");
				this.DialogResult = DialogResult.Abort;

				// this.Close();
				return;
			}

			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			ProductVM model = ToProductVM(data.Rows[0]);

			// 再將 viewModel值繫結到各控制項
			categoryIdComboBox.SelectedItem = ((List<ProductCategoryVM>)categoryIdComboBox.DataSource)
												.FirstOrDefault(x => x.Id == model.CategoryId);

			productNameTextBox.Text = model.ProductName;
			listPriceTextBox.Text = model.ListPrice.ToString();

		}
		private ProductVM ToProductVM(DataRow row)
		{
			return new ProductVM
			{
				Id = row.Field<int>("Id"),
				CategoryId = row.Field<int>("CategoryId"),
				ProductName = row.Field<string>("ProductName"),
				ListPrice = row.Field<int>("ListPrice")
			};
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

		


		private void updateButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			int categoryId = ((ProductCategoryVM)this.categoryIdComboBox.SelectedItem).Id;
			string productName = productNameTextBox.Text;
			int listPrice = listPriceTextBox.Text.ToInt(-1); //如果没填牌價,傳回-1

			// 將它們繫結到ViewModel
			ProductVM model = new ProductVM
			{
				CategoryId = categoryId,
				ProductName = productName,
				ListPrice = listPrice
			};

			// 針對ViewModel進行欄位驗證
			string errorMsg = string.Empty;
			if (string.IsNullOrEmpty(model.ProductName)) errorMsg += "商品名稱必填\r\n";
			if (model.ListPrice < 0) errorMsg += "牌價必需輸入大於或等於零的整數\r\n";

			if (string.IsNullOrEmpty(errorMsg) == false)
			{
				//表示至少一欄有錯誤
				MessageBox.Show(errorMsg);
				return; // 不再向下執行
			}

			// update record
			string sql = @"UPDATE Products
			SET CategoryId=@CategoryId, ProductName=@ProductName, ListPrice = @ListPrice
			WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("CategoryId", model.CategoryId)
				.AddNVarchar("ProductName",50, model.ProductName)
				.AddInt("ListPrice", model.ListPrice)
				.AddInt("Id", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox
				.Show("您真的要刪除嗎?",
						"刪除記錄",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			string sql = @"DELETE FROM Products WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("Id", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}
	}
}
