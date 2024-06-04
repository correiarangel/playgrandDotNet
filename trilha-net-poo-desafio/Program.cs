using DesafioPOO.Models;

Nokia nokia = new Nokia("(19)9.99130-6907","N-9000","1'234-5432-23456-6645523-3456-2456",8192);

Smartphone iphone = new Nokia("(19)9.89930-6907","iphone 18","1'254-5732-29456-6345523-7416-1416",8192);

Console.WriteLine("Iphone");
Console.WriteLine(iphone.Numero);
iphone.InstalarAplicativo("ZecariocaApp");
iphone.Ligar();
iphone.ReceberLigacao();

Console.WriteLine("---------------------------------");

Console.WriteLine("Nokia");
Console.WriteLine(nokia.Numero);
nokia.InstalarAplicativo("ZecariocaApp");
nokia.Ligar();
nokia.ReceberLigacao();
