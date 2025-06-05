using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("NOKIA:");
Nokia nokia = new Nokia("99999-9999", "Modelo 01", "789456123", 500);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nIPHONE:");
Iphone iphone = new Iphone("98888-8888", "Modelo 02", "123456789", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");