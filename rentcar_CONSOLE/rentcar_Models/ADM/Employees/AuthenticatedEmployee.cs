using rentcar_CONSOLE.rentcar.Models.ADM.LoginSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentcar_CONSOLE.rentcar.Models.ADM.Employees
{
	public abstract class AuthenticatedEmployee : Employee, IAuthenticated
	{
		public string Senha { get; set; }

		public AuthenticatedEmployee(double salario, string cpf)
			: base(salario, cpf)
		{

		}

		public bool Autenticar(string senha)
		{
			return Senha == senha;
		}
	}
}
