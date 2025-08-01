using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia: ");
Smartphone Nokia = new Nokia(numero: "25467", modelo: "Modelo Um", imei: "138790", memoria: 74);
Nokia.Ligar();
Nokia.ReceberLigacao();
Nokia.InstalarAplicativo("Linkedin");


Console.WriteLine("\n");



Console.WriteLine("Smartphone Iphone: ");
Smartphone Iphone = new Iphone(numero: "97289", modelo: "Modelo Dois", imei: "574982", memoria: 84);
Iphone.Ligar();
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Linkedin");