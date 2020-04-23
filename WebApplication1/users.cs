using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class users
    {

		private int _id;

		public int id
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _login;

		public string login
		{
			get { return _login; }
			set { _login = value; }
		}
		private string _password;

		public string password
		{
			get { return _password; }
			set { _password = value; }
		}

	}
}
