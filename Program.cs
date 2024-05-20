using System.Collections.Immutable;
using DesafioDOTNETPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "N-32", imei: "1111111", memoria: 128);
nokia.ExibirInformacoes();
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "87654321", modelo: "I-12", imei: "2222222", memoria: 256);
iphone.ExibirInformacoes();
iphone.RecebendoLigacao();
iphone.InstalarAplicativo("Telegram");