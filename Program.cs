using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("123456", "Modelo 1", "1111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");


Console.WriteLine("Smartphone IPhone:");
Iphone iphone = new Iphone("789384", "Modelo 2", "2222222", 139);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
