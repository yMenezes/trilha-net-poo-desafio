using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Nokia n = new Nokia(numero: "12345", modelo:"Tijolão", mei: "1111", memoria: 4);
n.ExibirSmartphone();
n.Ligar();
n.InstalarAplicativo("Google Maps...");


Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone Ip = new Iphone(numero: "12345", modelo:"Riphone2", mei: "1111", memoria: 6);
Ip.ExibirSmartphone();
Ip.Ligar();
Ip.InstalarAplicativo("Chat GPT...");