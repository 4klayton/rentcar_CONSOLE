using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentcar_CONSOLE.rentcar.Models.ADM.Employees
{
	public abstract class Employee
	{
		public static int TotalDeFuncionarios { get; private set; }

		public string Nome { get; set; }
		public string CPF { get; private set; }
		public double Salario { get; protected set; }

		public Employee(double salario, string cpf)
		{
			Console.WriteLine("Criando FUNCIONARIO");

			this.CPF = cpf;
			this.Salario = salario;

			TotalDeFuncionarios++;
		}

		public abstract void AumentarSalario();

		public abstract double getBonificacao();
	}
}
