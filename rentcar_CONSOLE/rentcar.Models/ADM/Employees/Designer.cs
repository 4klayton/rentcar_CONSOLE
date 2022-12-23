using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentcar_CONSOLE.rentcar.Models.ADM.Employees
{
	public class Designer : Employee
	{
		public Designer(string cpf) : base(3000, cpf)
		{
		}

		public override void AumentarSalario()
		{
			this.Salario *= 1.11;
		}

		public override double getBonificacao()
		{
			return this.Salario * 0.17;
		}
	}
}
