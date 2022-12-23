﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentcar_CONSOLE.rentcar.Models.Objects
{
	public class Car
	{

		public Client Titular { get; set; }
		public string Nome_Agencia { get; set; }

		private int _numero_agencia;
		public int Numero_agencia
		{
			get
			{
				return _numero_agencia;
			}
			set
			{
				if (value <= 0)
				{

				}
				else
				{
					_numero_agencia = value;
				}
			}

		}

		private string _conta;
		public string Conta
		{
			get
			{
				return _conta;
			}
			set
			{
				if (value == null)
				{
					return;
				}
				else
				{
					_conta = value;
				}
			}
		}

		private double saldo;
		public double Saldo
		{
			get
			{
				return saldo;
			}
			set
			{
				if (value < 0)
				{
					return;
				}
				else
				{
					saldo = value;
				}
			}
		}

		public bool Sacar(double valor)
		{
			if (saldo < valor)
			{
				return false;
			}
			if (valor < 0)
			{
				return false;
			}
			else
			{
				saldo = saldo - valor;
				return true;
			}
		}

		public void Depositar(double valor)
		{
			if (valor < 0)
			{
				return;
			}
			saldo = saldo + valor;
		}

		public bool Transferir(double valor, Car destino)
		{
			if (saldo < valor)
			{
				return false;
			}
			if (valor < 0)
			{
				return false;
			}
			else
			{
				saldo = saldo - valor;
				destino.saldo = destino.saldo + valor;
				return true;
			}
		}

		public Car(int numero_agencia, string conta)
		{
			Numero_agencia = numero_agencia;
			Conta = conta;
			Titular = new Client();
			TotalDeContasCriadas += 1;

		}

		public static int TotalDeContasCriadas { get; set; }

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


	}
}