
double payment, increase, newPayment; // Declarando as variaveis

Console.WriteLine("Digite o salário do colaborador: ");
payment = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o % de reajuste: ");
increase = double.Parse(Console.ReadLine());
increase = increase / 100;

Console.WriteLine("Pressione qualquer tecla para visualizar o novo salário");
Console.Read();
// Console.Clear(); // limpar o console

newPayment = payment + (payment * increase;

Console.WriteLine($"Seu novo salário é de: {newPayment}");
Console.Read();
Console.WriteLine("Aperte alguma tecla para encerrar");
