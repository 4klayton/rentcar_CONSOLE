using rentcar_CONSOLE.rentcar.Models.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace rentcar_CONSOLE.rentcar.Misc

{
    public class CarList
{
	private Car[] _itens = null;
	private int _proximaPosicao = 0;
	public CarList(int tamanhoInicial = 5)
	{
		_itens = new Car[tamanhoInicial];
	}

	public void Adicionar(Car item)
	{
		Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
		VerificarCapacidade(_proximaPosicao + 1);
		_itens[_proximaPosicao] = item;
		_proximaPosicao++;
	}

	private void VerificarCapacidade(int tamanhoNecessario)
	{
		if (_itens.Length >= tamanhoNecessario)
		{
			return;
		}
		Console.WriteLine("Aumentando a capacidade da lista!");
		Car[] novoArray = new Car[tamanhoNecessario];

		for (int i = 0; i < _itens.Length; i++)
		{
			novoArray[i] = _itens[i];
		}
		_itens = novoArray;
	}

	public void Remover(Car conta)
	{
		int indiceItem = -1;
		for (int i = 0; i < _proximaPosicao; i++)
		{
			Car contaAtual = _itens[i];
			if (contaAtual == conta)
			{
				indiceItem = i;
				break;
			}
		}
		// 0         1       2
		//[conta1][conta2][conta4][conta5][null]
		for (int i = indiceItem; i < _proximaPosicao - 1; i++)
		{
			_itens[i] = _itens[i + 1];
		}
		_proximaPosicao--;
		_itens[_proximaPosicao] = null;
	}

	public void ExibeLista()
	{
		for (int i = 0; i < _itens.Length; i++)
		{
			if (_itens[i] != null)
			{
				var conta = _itens[i];
				Console.WriteLine($" Indice[{i}] = " +
					$"Conta:{conta.Conta} - " +
					$"N° da Agência: {conta.Numero_agencia}");
			}
		}
	}

	public Car RecuperarContaNoIndice(int indice)
	{
		if (indice < 0 || indice >= _proximaPosicao)
		{
			throw new ArgumentOutOfRangeException(nameof(indice));
		}

		return _itens[indice];
	}

	public int Tamanho
	{
		get
		{
			return _proximaPosicao;
		}
	}

	public Car this[int indice]
	{
		get
		{
			return RecuperarContaNoIndice(indice);
		}
	}



}
}
