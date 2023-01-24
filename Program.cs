using DesafioPOO.Model;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("SmartPhone Nokia");
Smartphone nokia = new Nokia(numero: "111", modelo: "A20", imei: "44149184", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("DIO");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone");
Smartphone iphone = new Iphone(numero: "1122", modelo: "iphode20", imei: "9214148", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("DIO");