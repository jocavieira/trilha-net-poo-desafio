using DesafioPOO.Models;

Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789", 32);
Iphone iphone = new Iphone("987654321", "iPhone 13", "987654321", 128);


nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
