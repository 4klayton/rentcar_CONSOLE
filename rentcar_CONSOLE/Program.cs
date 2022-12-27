// 4klayton - Project based on Alura C# course (byteBank)

using rentcar_CONSOLE.rentcar_Models.Objects;

Console.WriteLine("Boas Vindas ao Rentcar...");
Console.ReadKey();

#region estudos de array
////TestaArrayInt();
////TestaBuscarPalavra();


//void TestaArrayInt()
//{
//    int[] idades = new int[5];
//    idades[0] = 30;
//    idades[1] = 40;
//    idades[2] = 17;
//    idades[3] = 21;
//    idades[4] = 18;

//    Console.WriteLine($"Tamanho do Array {idades.Length}");

//    int acumulador = 0;
//    for (int i = 0; i < idades.Length; i++)
//    {
//        int idade = idades[i];
//        Console.WriteLine($"índice [{i}] = {idade}");
//        acumulador += idade;
//    }

//    int media = acumulador / idades.Length;
//    Console.WriteLine($"Média de idades = {media}");
//}

//void TestaBuscarPalavra()
//{
//    string[] arrayDePalavras = new string[5];

//    for (int i = 0; i < arrayDePalavras.Length; i++)
//    {
//        Console.Write($"Digite {i + 1}ª Palavra: ");
//        arrayDePalavras[i] = Console.ReadLine();
//    }

//    Console.Write("Digite palavara a ser encontrada: ");
//    var busca = Console.ReadLine();

//    foreach (string palavra in arrayDePalavras)
//    {
//        if (palavra.Equals(busca))
//        {
//            Console.WriteLine($"Palavra encontrada = {busca}.");
//            break;
//        }
//    }

//}

//Array amostra = new double[5];
//amostra.SetValue(5.9, 0);
//amostra.SetValue(1.8, 1);
//amostra.SetValue(7.1, 2);
//amostra.SetValue(10, 3);
//amostra.SetValue(6.9, 4);

////[5,9][1,8][7,1][10][6,9]
////TestaMediana(amostra);


//void TestaMediana(Array array)
//{
//    if ((array == null) || (array.Length == 0))
//    {
//        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
//    }

//    double[] numerosOrdenados = (double[])array.Clone();
//    Array.Sort(numerosOrdenados);
//    //[1,8][5,9][6,9][7,1][10]

//    int tamanho = numerosOrdenados.Length;
//    int meio = tamanho / 2;
//    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
//                                   (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
//    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
//}

//int[] valores = { 10, 58, 36, 47 };
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(valores[i]);
//}

#endregion

List<Car> _listCar = new List<Car>()
{
	new Car("Renault".ToUpper(), "Clio".ToUpper()),
	new Car("Renault".ToUpper(), "Sandero".ToUpper()),
	new Car("Renault".ToUpper(), "Kwid".ToUpper()),
};

MainMenu();

void MainMenu()
{
	repeatMainMenu:
	char option = '0';
	while (option != '9')
	{
		Console.Clear();
		Console.WriteLine("================================");
		Console.WriteLine("===      Menu Principal      ===");
		Console.WriteLine("=== 1 - Carro                ===");
		Console.WriteLine("=== 2 - Cliente              ===");
		Console.WriteLine("=== 3 - Acessório            ===");
		Console.WriteLine("=== 9 - Sair do Sistema      ===");
		Console.WriteLine("================================");
		Console.WriteLine("\n\n");
		Console.Write("Digite a opção desejada: ");
		try
		{
			option = Console.ReadLine()[0];
		}
		catch (IndexOutOfRangeException)
		{
			Console.WriteLine("Digite algum número");
			Console.ReadKey();
			goto repeatMainMenu;
			break;
		}
		
		switch (option)
		{
			case '1':
				CarMenu();
				break;
			case '9':
				Console.WriteLine("Tchau!");
				Console.ReadKey();
				break;
			default:
				Console.WriteLine("Opção não implementada.");
				Console.ReadKey();
				break;
		}
	}
}

void CarMenu()
{
	repeatCarMenu:
	char option = '0';
	while (option != '9')
	{
		Console.Clear();
		Console.WriteLine("================================");
		Console.WriteLine("===         Menu Carro       ===");
		Console.WriteLine("=== 1 - Cadastrar Carro      ===");
		Console.WriteLine("=== 2 - Listar Carros        ===");
		Console.WriteLine("=== 3 - Remover Carros       ===");
		Console.WriteLine("=== 4 - Ordenar Carros       ===");
		Console.WriteLine("=== 5 - Pesquisar Carros     ===");
		Console.WriteLine("=== 9 - Menu Principal       ===");
		Console.WriteLine("================================");
		Console.WriteLine("\n\n");
		Console.Write("Digite a opção desejada: ");
		try
		{
			option = Console.ReadLine()[0];
		}
		catch (IndexOutOfRangeException)
		{
			Console.WriteLine("Digite algum número");
			Console.ReadKey();
			goto repeatCarMenu;
			break;
		}
		try
		{
			switch (option)
			{
				case '1':
					Car.AddCar(_listCar);
					break;
				case '2':
					Car.ListCar(_listCar);
					break;
				case '3':
					Car.RemoveCar(_listCar);
					break;
				case '5':
					Console.WriteLine(Car.FindCar(_listCar).ToString());
					Console.ReadKey();
					break;
				case '9':
					Console.WriteLine("Voltando para menu principal...");
					Console.ReadKey();
					break;
				default:
					Console.WriteLine("Opção não implementada.");
					Console.ReadKey();
					break;
			}
		}
		catch (ArgumentOutOfRangeException)
		{
			Console.WriteLine("Esse posição não é válida");
			Console.ReadKey();
			goto repeatCarMenu;
		}
	}
}




