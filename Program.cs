//rollspel 0.1
//mål för idag
// 1. hälsa
// 2. skada

//Du
double hhälsa = 10;
int svärd = 3;

//Fiende Hälsa
double[] fhälsa = new double[10];
int pinne = 1;

//Namn kanske kan skriva hela historian här... får se.
Console.WriteLine("Hej hjälte, vad är ditt namn?:");
string namn = Console.ReadLine();
Console.WriteLine("Hej " + namn);

Laddar();

Console.WriteLine("Du reser dig från marken o framför dig är bara aska från en nu död lägger äld. Du tar dina saker och fortsätter på stigen du vaknade på.");
Console.WriteLine("Du har fått ett svärd");
Console.WriteLine("Skada = 3");

ui(hhälsa);





// metoder

// skada
static void skada(ref double hälsa, ref double skada){
    hälsa = hälsa - skada;
}

// laddar
static void Laddar(){
    for(int gånger = 0; gånger <3; gånger++){
        Console.WriteLine(".");
    }
}

// Ditt Hp och Skada
static void ui(double hälsa){
    Console.WriteLine("HP:"+ hälsa);
}