using DesafioPOO.Models;

int delay = 2000;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("123456", "Nokia", "1111111", 128);
nokia.Ligar();
Thread.Sleep(delay);
nokia.InstalarAplicativo("Whatsapp");
Thread.Sleep(delay);

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone("654321", "Iphone", "222222", 64);
iphone.Ligar();
Thread.Sleep(delay);
iphone.InstalarAplicativo("Youtube");
Thread.Sleep(delay);