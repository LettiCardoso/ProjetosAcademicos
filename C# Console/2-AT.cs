{
    // Declaração das variáveis
    double salario, salarioReajustado;
    string profissao;

    // Entrada de dados
    Console.Write("Digite o salário: R$ ");
    salario = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite a profissão (Técnico, Gerente ou outros): ");
    profissao = Console.ReadLine();

    // Lógica de reajuste de salário
    if (profissao == "Técnico")
        salarioReajustado = salario * 1.15;
    else if (profissao == "Gerente")
        salarioReajustado = salario * 1.13;
    else
        salarioReajustado = salario * 1.11;

    // Saída de resultados
    Console.WriteLine($"Profissão: {profissao}");
    Console.WriteLine($"Salário atual: R$ {salario:F2}");
    Console.WriteLine($"Salário reajustado: R$ {salarioReajustado:F2}");
}
