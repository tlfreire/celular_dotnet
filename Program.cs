using DesafioPOO.Models;

Console.WriteLine("TELEFONE");
var nokia = new Nokia("1010", "K", "353535", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

var iphone = new Iphone("3030", "C", "505050", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");