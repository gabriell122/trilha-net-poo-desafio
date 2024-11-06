using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia( "12345", "tijolo", "12345", 1024);
nokia.InstalarAplicativo("minecraft");
nokia.Ligar();
nokia.ReceberLigacao();
Console.WriteLine($"O número do seus celular é {nokia.Numero}\nO Imae é {nokia.Imei} \nO modelo é {nokia.Modelo} \nE a memoria e de {nokia.Memoria}");

Console.WriteLine();
Iphone iphone = new Iphone( "54321", "6tadoido", "54321", 512);
iphone.InstalarAplicativo("pou");
iphone.Ligar();
iphone.ReceberLigacao();
Console.WriteLine($"O número do seus celular é {iphone.Numero}\nO Imae é {iphone.Imei} \nO modelo é {iphone.Modelo} \nE a memoria e de {iphone.Memoria}");



