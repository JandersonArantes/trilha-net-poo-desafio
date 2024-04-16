using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.Clear();

Console.WriteLine("*** Smartphone NOKIA ***");
Nokia nokia = new(numero: "123455", modelo: "Modelo1", imei: "111111111111", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n*** Smartphone IPHONE ***");
Smartphone iphone = new Iphone(numero: "199910", modelo: "Modelo 2", imei: "55555555555", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nPOO(Programação Orientada a Objeto) é SHOW!!!");
Console.WriteLine("Obrigado professor LEONARDO BUTA!");
Console.WriteLine("Aluno: Janderson Arantes");
