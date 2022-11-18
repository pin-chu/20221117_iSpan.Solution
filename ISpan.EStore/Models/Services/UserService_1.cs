using ISpan.EStore.Infra.DAOs;
using ISpan.EStore.Models.DTOs;
using ISpan.EStore.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ISpan.EStore.Models.Services
{
	public class UserService
	{
		private UserDAO _dao;

		public UserService()
		{
			_dao = new UserDAO();	
		}

		public void Create(UserDTO model)
		{
			bool isExists = _dao.AccountExists(model.Account);
			if (isExists) throw new Exception("帳號已存在");

			new UserDAO().Create(model);

		}

		private UserIndexVM ParseToIndexVM(DataRow row)
		{
			return new UserIndexVM
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Name = row.Field<string>("Name")
			};
		}

		internal void Update(UserDTO model)
		{
			bool isExists = _dao.AccountExists(model);
			if (isExists) throw new Exception("帳號已存在");

			new UserDAO().Update(model);
		}

		internal void Delete(int id)
		{
			_dao.Delete(id);
		}

		public bool Authenticate(LoginVM model)
		{
			var user = _dao.Get(model.Account);
			if (user == null) return false; // 找不到符合的帳號

			return (user.Password == model.Password);
		}
		
	}
}
