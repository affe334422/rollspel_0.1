//rollspel 0.1
//mål för idag
// 1. hälsa
// 2. skada
// 3. mer vapen, en random generator som väljer mälla 1-x där varje nummer är ett vapen

// bra att ha om hag vill generera ett vapen.
Random random_vapen_generator = new Random();
int random_vapen = random_vapen_generator.Next(0, 3);
string[] olika_vapen = {"ett svärd", "ett spjut", "två knivar"};


//Du
double hhälsa = 10;
int[] vapen_skada = { 2, 2, 2};
double crit_skans_hj = 30;

//Fiende Hälsa
//fiende[1] = 10; för att sätta vilken fiende och dens hälsa
double[] fiende = new double[10];
int vapen_pinne = 1;


//Namn kanske kan skriva hela historian här... får se. 

if("hitoria" != "historia"){
    Console.WriteLine("Hej hjälte, vad är ditt namn?:");
    string namn = Console.ReadLine();
    Console.Write("Hej " + namn);
    Console.ReadLine();

    Laddar();

    Console.WriteLine("Du reser dig från marken o framför dig är bara aska från en nu död lägger äld. Du tar dina saker och fortsätter på stigen du vaknade på.");
    Console.WriteLine("Du har fått " + olika_vapen[random_vapen]);
    Console.Write("skada = "+ vapen_skada[random_vapen]);
    Console.ReadLine();

    Laddar();

    Console.WriteLine("Du mötter en fiende som stoppar din väg, Den hoppar mot dig med en pinne i handen men du rullar undan");
}




// kan bara kopiera det varje gång jag ska göra en ui
do{
    ui(hhälsa, vapen_skada[random_vapen]); 
    Console.WriteLine(".");
    fiende[1] = 10;
    fi(fiende[1], vapen_pinne);
    Console.WriteLine(".");

    //crit
    Console.WriteLine("vad vill du göra. attack = 1, :");
    string om_man_attack1 = Console.ReadLine();
    int om_man_attack = int.Parse(om_man_attack1);

    if(om_man_attack == 1){
            Random crit = new Random();
            int procent_crit = crit.Next(1, 101);
            
            if(crit_skans_hj <= procent_crit){
                crit_skada(ref fiende[1], vapen_skada[random_vapen]);
            }
            else{
                skada(ref fiende[1], vapen_skada[random_vapen]);
            }
    om_man_attack = 0;
    }
}while(fiende[1] != 0);

Console.WriteLine("Han är död");




// metoder

// skada
static void skada(ref double hälsa, double skada){
    hälsa = hälsa - skada;
}

static void crit_skada(ref double hälsa, double skada){
    skada = skada * 2;
    hälsa = hälsa - skada;
}

// laddar
static void Laddar(){
    for(int gånger = 0; gånger <3; gånger++){
        Console.WriteLine(".");
    }
}

// Ditt Hp och Skada. jag försökte sätta in - Console.WriteLine(olika_vapen[random_vapen]) men det gick inte.
static void ui(double hälsa, int skada){
    Console.WriteLine("Hjälte");
    Console.WriteLine("HP:"+ hälsa);
    Console.WriteLine("Dmg:"+ skada);
}

static void fi(double hälsa, int skada){
    Console.WriteLine("Fiende");
    Console.WriteLine("HP:"+ hälsa);
    Console.WriteLine("Dmg:"+ skada);
}

//xp
// Läsa av att en fiende är död, gör en metod som är i en if() där om fiendes hälsa är x<=0 så görs if() programet.