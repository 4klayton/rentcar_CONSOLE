using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentcar_CONSOLE.rentcar.Models.ADM.LoginSystem
{
	public interface IAuthenticated
	{
		bool Autenticar(string senha);
	}
}
