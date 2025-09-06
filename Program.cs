using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Criar um Nokia
string nokiaNumero = "11 99999-1111";
string nokiaModelo = "Modelo 2025-NK";
string nokiaIMEI = "1111111111111111111111";
int nokiaMemoria = 6144;
Smartphone nokia = new Nokia(numero: nokiaNumero, modelo: nokiaModelo, imei: nokiaIMEI, memoria: nokiaMemoria);

// Criar um Iphone
string iphoneNumero = "11 99999-2222";
string iphoneModelo = "Iphone 2025 Premium";
string iphoneIMEI = "2222222222222222222222";
int iphoneMemoria = 16384;
Smartphone iphone = new Iphone(numero: iphoneNumero, modelo: iphoneModelo, imei: iphoneIMEI, memoria: iphoneMemoria);

// ligar do Nokia
System.Console.WriteLine("Nokia:");
nokia.Ligar();

// receber ligação Nokia
nokia.ReceberLigacao();

// Instalar aplicativo do Nokia
nokia.InstalarAplicativo("Tetris");

System.Console.WriteLine();

// ligar do Iphone
System.Console.WriteLine("Iphone:");
iphone.Ligar();

// receber ligação Iphone
iphone.ReceberLigacao();

// Instalar aplicativo do Iphone
iphone.InstalarAplicativo("Tetris");