using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentcar_CONSOLE.rentcar.Models.ADM.LoginSystem
{
	public class LoginSystem
	{
		public bool Logar(IAuthenticated funcionario, string senha)
		{
			bool usuarioAutenticado = funcionario.Autenticar(senha);

			if (usuarioAutenticado)
			{
				Console.WriteLine("Bem-vindo ao sistema!");
				return true;
			}
			else
			{
				Console.WriteLine("Senha incorreta!");
				return false;
			}
		}
	}
}
