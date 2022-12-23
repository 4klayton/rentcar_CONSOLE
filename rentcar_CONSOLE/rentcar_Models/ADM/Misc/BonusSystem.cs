using rentcar_CONSOLE.rentcar.Models.ADM.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentcar_CONSOLE.rentcar.Models.ADM.Misc
{
	public class BonusSystem
	{
		private double _totalBonificacao;

		public void Registrar(Employee funcionario)
		{
			_totalBonificacao += funcionario.getBonificacao();
		}

		public double GetTotalBonificacao()
		{
			return _totalBonificacao;
		}

	}
}