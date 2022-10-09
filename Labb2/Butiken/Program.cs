using Butiken;

View view = new View();
List<Produkt> varor = new List<Produkt>();

Produkt aegg = new Produkt("ägg", 2.59, "st");
Produkt bacon = new Produkt("bacon", 15.90, "hg");
Produkt mjoel = new Produkt("mjöl", 20, "kg");
Produkt mjoelk = new Produkt("mjölk", 17, "l");
Produkt rovor = new Produkt("rovor", 10, "st");

varor.Add(aegg);
varor.Add(bacon);
varor.Add(mjoel);
varor.Add(mjoelk);
varor.Add(rovor);

List<Kund> kundLista = new List<Kund>();

Kund kund0 = new Kund("Knatte", "123");
Kund kund1 = new Kund("Fnatte", "321");
Kund kund2 = new Kund("Tjatte", "213");

kundLista.Add(kund0);
kundLista.Add(kund1);
kundLista.Add(kund2);

var menuVar = "";

//kund0.LaeggIVagn(aegg, 12, kund0.Cart);
//kund0.LaeggIVagn(bacon, 2, kund0.Cart);

//Console.WriteLine(kund0);


while (true)
{
    Console.Clear();
    Console.WriteLine("Välkommen till HandlarN^'s Lanthandel!\n");

    view.LogInMenu();
    menuVar = Console.ReadLine();

    switch (menuVar)
    {
        case "1":



            break;
        case "2":
            break;
        case "0":
            break;
        default:
            Console.WriteLine("Ej korrekt input, vänligen prova igen!");
            Thread.Sleep(750);
            continue;
            
    }

}

void LogInModule()
{

    while (true)
    {
        Console.WriteLine("Skriv in användarnamn:");
        Console.ReadLine();
    }

}
