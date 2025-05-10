//ALGORITMO_MEDIA_PONDERADA
//Entrada
double nota1, nota2, nota3, peso1, peso2, peso3, mediaPonderada;
Console.WriteLine("Informe a nota 1");
nota1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe a nota 2");
nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe a nota 3");
nota3 = Convert.ToDouble(Console.ReadLine());
//peso
Console.WriteLine("Informe o peso da 1");
peso1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe o peso da 2");
peso2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe o peso da 3");
peso3 = Convert.ToDouble(Console.ReadLine());
//Processamento
mediaPonderada=(nota1*peso1 + nota2*peso2 + nota3*peso3)/(peso1 + peso2 + peso3);

//Saída

Console.WriteLine("A média ponderada das notas informadas é" + mediaPonderada);

