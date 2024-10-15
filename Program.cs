//rollspel 0.1
//mål för idag
// 1. hälsa
// 2. skada
// 3. mer vapen, en random generator som väljer mälla 1-x där varje nummer är ett vapen

// bra att ha om hag vill generera ett vapen.
Random rnd =new Random();
int random_vapen = rnd.Next(0, 3);
string[] olika_vapen = {"svärd", "spjut", "knivar"};

Console.WriteLine(olika_vapen[random_vapen]);

//Du
double hhälsa = 10;
int svärd = 3;

//Fiende Hälsa
//fiende[1] = 10; för att sätta vilken diende och dens hälsa
double[] fiende = new double[10];
int vapen_pinne = 1;


//Namn kanske kan skriva hela historian här... får se.
Console.WriteLine("Hej hjälte, vad är ditt namn?:");
string namn = Console.ReadLine();
Console.WriteLine("Hej " + namn);
Console.ReadLine();

Laddar();

Console.WriteLine("Du reser dig från marken o framför dig är bara aska från en nu död lägger äld. Du tar dina saker och fortsätter på stigen du vaknade på.");
Console.WriteLine("Du har fått ett svärd"); // göre det till en if() för om jag vill ha mer vapen
Console.WriteLine("Skada = 3");
Console.ReadLine();

Laddar();

Console.WriteLine("Du mötter en fiende som stoppar din väg, Den hoppar mot dig med en pinne i handen men du rullar undan");
Console.WriteLine("Vad vill du göra nu?");

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


//xp
// Läsa av att en fiende är död, gör en metod som är i en if() där om fiendes hälsa är x<=0 så görs if() programet.