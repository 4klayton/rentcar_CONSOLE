using rentcar_CONSOLE.rentcar.Models.ADM.LoginSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentcar_CONSOLE.rentcar.Models.ADM.Partner
{
	public class Partner : IAuthenticated
	{
		public string Senha { get; set; }
		public bool Autenticar(string senha)
		{
			return Senha == senha;
		}
	}
}