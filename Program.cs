double horas, custo, estimado, KWH;

Console.WriteLine("Bem-vindo ao calculo de conta de luz");
Console.WriteLine("Aqui você conseguira calcular o quanto cada aparelho consome na sua casa");

Console.WriteLine("por favor digite o consumo do seu aparelho (em KWH/mês)");
KWH = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Por favor digite o tempo de uso do aparelho");
horas = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Por favor insira o Custo da energia");
custo = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("--- Custo de Energia ---");

Console.WriteLine($"Consumo do aparelho (em kWh/mês)...: {KWH}");
Console.WriteLine($"Horas de uso por dia...............: {horas}");
Console.WriteLine($"Custo da energia (em R$/kWh).......: {custo}");

estimado = horas * KWH * custo;

Console.WriteLine($"Custo estimado: R${estimado:F2}");