using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentcar_CONSOLE.rentcar.Models.ADM.Employees
{
	public class Officer : Employee
	{
		public Officer(string cpf) : base(2000, cpf)
		{
		}

		public override void AumentarSalario()
		{
			Salario *= 1.1;
		}

		public override double getBonificacao()
		{
			return Salario * 0.2;
		}
	}
}