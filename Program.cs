using DesafioPOO.Models;

void carregarDados(Smartphone smartphone)
{
    Console.WriteLine($"\n{new string('*', 30)} Inicializando checkups do {smartphone.GetType().Name}... {new string('*', 30)}");

    Console.WriteLine($"{nameof(smartphone.Modelo)}: {smartphone.Modelo}");
    Console.WriteLine($"{nameof(smartphone.Numero)}: {smartphone.Numero}");
    Console.WriteLine($"{nameof(smartphone.IMEI)}: {smartphone.IMEI}");
    Console.WriteLine($"{nameof(smartphone.Memoria)}: {smartphone.Memoria}");

    smartphone.Ligar();
    smartphone.ReceberLigacao();
    smartphone.InstalarAplicativo("Jogo da cobrinha");

    Console.WriteLine($"{new string('*', 30)} Checkups do {smartphone.GetType().Name} finalizados. Smartphone pronto para uso! {new string('*', 30)}");
}
Smartphone nokia = new Nokia("1499978", "3310", "449876", "32");
carregarDados(nokia);

Smartphone iphone = new Iphone("99864", "15 Pro Max", "9987", "256");
carregarDados(iphone);

