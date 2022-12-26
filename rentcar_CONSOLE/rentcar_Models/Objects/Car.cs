using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentcar_CONSOLE.rentcar_Models.Objects
{
	public class Car
	{
		public String brand;
		public String model;
		public String color;
		public int year;
		public char isRented;

		public Car(string brand, string model)
		{
			this.brand = brand;
			this.model = model;
			//totalCars += 1;

		}

		public static void RemoveCar(List<Car> list)
		{
			if (list.Count <= 0)
			{
				Console.WriteLine("Nenhum carro cadastrado.");
				Console.ReadKey();
				return;
			}
			Console.Clear();
			Console.WriteLine("================================");
			Console.WriteLine("===      Removendo Carro     ===");
			Console.WriteLine("================================");
			Console.WriteLine("\n");

			Console.Write("Digite o modelo do carro que deseja remover: ");
			string modelToFind = Console.ReadLine().ToUpper();
		
			for (int i = 0; i < list.Count; i++ )
			{
				if (list[i].model == modelToFind)
				{
					list.RemoveAt(i);
					Console.WriteLine($"O carro {modelToFind} foi removido da lista");
					Console.ReadKey();
					break;
				}
				if (i == (list.Count-1))
				{
					Console.WriteLine("Carro não encontrado.");
					Console.ReadKey();
				}
			}

		}

		public static void AddCar(List<Car> list)
		{
			Console.Clear();
			Console.WriteLine("================================");
			Console.WriteLine("===     Cadastrando Carro    ===");
			Console.WriteLine("================================");
			Console.WriteLine("\n");
			Console.Write("Digite a marca do carro: ");
			string _brand = Console.ReadLine().ToUpper();
			Console.Write("Digite o modelo do carro: ");
			string _model = Console.ReadLine().ToUpper();

			Car newCar = new Car(_brand, _model);
			list.Add(newCar);

		}

		public static void ListCar(List<Car> list)
		{
			if (list.Count <= 0)
			{
				Console.WriteLine("Nenhum carro cadastrado.");
				Console.ReadKey();
				return;
			}

			Console.Clear();
			Console.WriteLine("================================");
			Console.WriteLine("===      Lista de Carros     ===");
			Console.WriteLine("================================");
			Console.WriteLine("\n");

			int i = 0;
			foreach (Car item in list)
			{
				Console.WriteLine($"        Índice: {i}     ");
				Console.WriteLine($"Marca do Carro: {item.brand}");
				Console.WriteLine($"Modelo do Carro: {item.model}");
				Console.WriteLine($"=========================");
				i++;
			}
			Console.ReadKey();

		}

		#region Estudos da classe conta corrente
		//public Client Titular { get; set; }
		//public string Nome_Agencia { get; set; }

		//private int _numero_agencia;
		//public int Numero_agencia
		//{
		//	get
		//	{
		//		return _numero_agencia;
		//	}
		//	set
		//	{
		//		if (value <= 0)
		//		{

		//		}
		//		else
		//		{
		//			_numero_agencia = value;
		//		}
		//	}

		//}

		//private string _conta;
		//public string Conta
		//{
		//	get
		//	{
		//		return _conta;
		//	}
		//	set
		//	{
		//		if (value == null)
		//		{
		//			return;
		//		}
		//		else
		//		{
		//			_conta = value;
		//		}
		//	}
		//}

		//private double saldo;
		//public double Saldo
		//{
		//	get
		//	{
		//		return saldo;
		//	}
		//	set
		//	{
		//		if (value < 0)
		//		{
		//			return;
		//		}
		//		else
		//		{
		//			saldo = value;
		//		}
		//	}
		//}

		//public bool Sacar(double valor)
		//{
		//	if (saldo < valor)
		//	{
		//		return false;
		//	}
		//	if (valor < 0)
		//	{
		//		return false;
		//	}
		//	else
		//	{
		//		saldo = saldo - valor;
		//		return true;
		//	}
		//}

		//public void Depositar(double valor)
		//{
		//	if (valor < 0)
		//	{
		//		return;
		//	}
		//	saldo = saldo + valor;
		//}

		//public bool Transferir(double valor, Car destino)
		//{
		//	if (saldo < valor)
		//	{
		//		return false;
		//	}
		//	if (valor < 0)
		//	{
		//		return false;
		//	}
		//	else
		//	{
		//		saldo = saldo - valor;
		//		destino.saldo = destino.saldo + valor;
		//		return true;
		//	}
		//}

		//public Car(int numero_agencia, string conta)
		//{
		//	Numero_agencia = numero_agencia;
		//	Conta = conta;
		//	Titular = new Client();
		//	TotalDeContasCriadas += 1;

		//}

		//public static int TotalDeContasCriadas { get; set; }
		#endregion
		#region outros estudos
		//public override bool Equals(object? conta)
		//{
		//    ContaCorrente outroConta = conta as ContaCorrente;

		//    if (outroConta == null)
		//    {
		//        return false;
		//    }

		//    return Numero_agencia == outroConta.Numero_agencia && 
		//        Conta.Equals(outroConta.Conta);
		//}
		#endregion

	}
}