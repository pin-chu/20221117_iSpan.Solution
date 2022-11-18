using ISpan.EStore.Infra;
using ISpan.EStore.Models.DTOs;
using ISpan.EStore.Models.Services;
using ISpan.EStore.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore
{
	public partial class CreateUserForm : Form
	{
		public CreateUserForm()
		{
			InitializeComponent();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			string account = accountTextBox.Text;
			string password = passwordTextBox.Text;
			string name = nameTextBox.Text;
			
			// 將它們繫結到ViewModel
			UserVM model = new UserVM
			{
				Account = account,
				Password = password,
				Name = name,
			};

			// 針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", accountTextBox},
				{"Password", passwordTextBox},
				{"Name", nameTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;


			// 如果通過驗證,就新增記錄
			// 將ViewModel轉成DTO
			UserDTO dto = model.ToDTO();


			try
			{
				// new UserService().Create(model);
				new UserService().Create(dto);

				this.DialogResult = DialogResult.OK;
			}catch(Exception ex)
			{
				MessageBox.Show("新增失敗, 原因: " + ex.Message);
			}
		}

		//private bool Validate(UserVM model, Dictionary<string, Control> map, ErrorProvider errorProvider)
		//{
		//	// 得知要驗證規則
		//	ValidationContext context = new ValidationContext(model, null, null);
		//	// 用來存放錯誤的集合,因為可能有零到多個錯誤
		//	List<ValidationResult> errors = new List<ValidationResult>();
		//	// 驗證 model
		//	errorProvider.Clear();
		//	bool validateAllProperties = true; // 是否驗證所有規則,而非只驗證Required規則
		//	bool isValid = Validator.TryValidateObject(model, context, errors, validateAllProperties);
		//	if (!isValid)
		//	{
		//		DisplayErrorsByErrorProvider(errors, map);
		//	}
		//	return isValid;
		//}
		//private void DisplayErrorsByErrorProvider(List<ValidationResult> errors, Dictionary<string, Control> map)
		//{
		//	// this.errorProvider1.Clear();
		//	foreach (ValidationResult error in errors)
		//	{
		//		string propName = error.MemberNames.FirstOrDefault();
		//		if (map.TryGetValue(propName, out Control ctrl))
		//		{
		//			this.errorProvider1.SetError(ctrl, error.ErrorMessage);
		//		}
		//	}
		//}
	}
}
