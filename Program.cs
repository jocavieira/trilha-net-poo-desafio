using DesafioPOO.Models;

// Creating phone instances
Nokia nokia = new Nokia("123456789", "Nokia 3310", 32);
Iphone iphone = new Iphone("987654321", "iPhone 13", 128);

// Nokia actions
nokia.Call();           
nokia.IncomingCall();   
nokia.InstallApp("WhatsApp");

// iPhone actions
iphone.Call();          
iphone.IncomingCall();  
iphone.InstallApp("Instagram");

