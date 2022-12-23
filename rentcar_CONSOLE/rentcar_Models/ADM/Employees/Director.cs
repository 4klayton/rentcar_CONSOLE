using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentcar_CONSOLE.rentcar.Models.ADM.Employees
{
	public class Director : AuthenticatedEmployee
	{
		public Director(string cpf) : base(5000, cpf)
		{
			Console.WriteLine("Criando DIRETOR");
		}

		public override void AumentarSalario()
		{
			this.Salario *= 1.15;
		}

		public override double getBonificacao()
		{
			return this.Salario * 0.5;
		}
	}
}
