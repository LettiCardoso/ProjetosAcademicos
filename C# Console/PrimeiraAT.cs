//2.       Criação um algoritmo que receba um valor em segundos e o converta para horas, minutos e segundos. Exiba o resultado no formato "HH:MM:SS".
// ENTRADA
double hora, minuto, segundo, HHMMSS;
// INICIO
Console.WriteLine("Informe os segundos para a conversão");
segundo = Convert.ToDouble(Console.ReadLine());
minuto = (segundo) / 60;
hora = (minuto) / 60;
// PROCESSAMENTO
HHMMSS = ( +hora / +minuto / +segundo);

Console.WriteLine("A conversão dos segundos em hora, minuto e segundos é" + HHMMSS);
