using eshop_s_detmi;

double Pokladna = 0;
MaleDite dite1 = new MaleDite()
{
    Cena = 1000,
    JeHodne = false,
    Jmeno = "Nina",
    Vek = 4,
};
MaleDite dite2 = new MaleDite()
{
    Cena = 500,
    JeHodne = true,
    Jmeno = "Milan",
    Vek = 2,
};


VelkeDite dite3 = new VelkeDite()
{
    Cena = 5000,
    JeHodne = true,
    Jmeno = "Jirka",
    Vek = 14,
};
VelkeDite dite4 = new VelkeDite()
{
    Cena = 1000,
    JeHodne = false,
    Jmeno = "Mikuláš",
    Vek = 16,
};

List<ZakladniDite> seznamDeti = new List<ZakladniDite>() { dite4,dite3,dite2,dite1 };
bool isTrue = true;
while(isTrue) { 
Console.WriteLine("1 - Vypiš všechny děti");
Console.WriteLine("2 - Jaký je stav pokladny?");
Console.WriteLine("3 - Vychovej dítě");
Console.WriteLine("4 - Naskladni dítě");
Console.WriteLine("5 - Prodej dítě");
Console.WriteLine("6 - Ukonči tenhle nelidský experiment!");
int volba = Convert.ToInt32(Console.ReadLine());
switch (volba)
{
    case 1:
        Console.WriteLine("Celkem je na skladě " + seznamDeti.Count + " dětí:");
        for (int i = 0; i < seznamDeti.Count; i++)
        {
            Console.WriteLine(seznamDeti[i].Jmeno + " " + seznamDeti[i].Vek + " roky");
        }
        break;
    case 2:
        Console.WriteLine("Stav pokladny: " + Pokladna + " Kč");
        break;
    case 3:
        foreach (var dite in seznamDeti)
        {
            Console.WriteLine(dite.Jmeno + "-" + (dite.JeHodne ? " Je hodné" : " Není hodné"));
        }
        Console.WriteLine("Zadej jméno dítěte, které si zaslouží vychovat: ");
        string jmeno = Console.ReadLine();
        //string dostaneVyprask = seznamDeti[seznamDeti.FindIndex(x => x.Jmeno == jmeno)].DostanVyprask(); //jak můžu použít tohle rozhraní? - nejde to, protože používám interface na bázovou třídu, která ho neimplementuje?
        break;
    case 4:
        Console.WriteLine("Zadej, jestli je to malé nebo velké dítě (male / velke");
        string vyberTridyDitete = Console.ReadLine();
        if (vyberTridyDitete == "male")
        {
           MaleDite noveDite = new MaleDite();
        }
        else if (vyberTridyDitete == "velke")
        {
            VelkeDite noveDite = new VelkeDite(); 
        }
        else
        {
            Console.WriteLine("Chyba. Zadej velke nebo male dítě");
        }

        Console.WriteLine("Zadej jméno dítěte");
        string jmenoDitete = Console.ReadLine();
        Console.WriteLine("Zadej věk dítěte");
        int vekDitete = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Zadej cenu dítěte");
        double cenaDitete = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Je dítě hodné? Ano/Ne");
        string volbaHodne = Console.ReadLine();
        bool diteJeHodne;
       
        if (volbaHodne == "Ano")
        {
            diteJeHodne = true; 
        }
        else if (volbaHodne == "Ne")
        {
            diteJeHodne = false;
        }
        else
        {
            Console.WriteLine("Zadej Ano/Ne.");
        }
        //noveDite.Jmeno = jmenoDitete; //noveDite zde není přístupné?
        //noveDite.Vek = vekDitete;
        //noveDite.Cena = cenaDitete;
        //noveDite.JeHodne = diteJeHodne; //nejde použít tahle proměnná?
        //seznamDeti.Add(noveDite);
        break;

    case 5:
        foreach (var dite in seznamDeti)
        {
            Console.WriteLine(dite.Jmeno);
        }
        Console.WriteLine("Zadej jméno dítěte, které chceš prodat");
        string jmenoProdej = Console.ReadLine();
            double cena = seznamDeti[seznamDeti.FindIndex(x => x.Jmeno == jmenoProdej)].Cena;

            // -> jak zničit objekt?
            Pokladna += cena; //z objektu diteNaProdej získám cenu a přidám ji k Pokladně

            break;
        case 6:
            isTrue = false;
            break;
}
}
Console.ReadLine();
