using eshop_s_detmi;

MaleDite dite1 = new MaleDite()
{
    Cena = 1000,
    JeHodne = false,
    Jmeno = "Nina",
    Vek = 4,
};
dite1.DostanVyprask();

dite1.PredstavSe();

VelkeDite dite2 = new VelkeDite()
{
    Cena = 5000,
    JeHodne = true,
    Jmeno = "Kluk",
    Vek = 14,
};
dite2.PredstavSe();
//po fyzickém trestu
dite2.DostanVyprask();
dite2.PredstavSe();
