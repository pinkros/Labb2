using Butiken;

View view = new View();
List<Produkt> varor = new List<Produkt>();
Kund? nuvarandeKund = null;




varor.Add(new Produkt("ägg", 2.59, "st"));
varor.Add(new Produkt("bacon", 15.90, "hg"));
varor.Add(new Produkt("mjöl", 20, "kg"));
varor.Add(new Produkt("mjölk", 17, "l"));
varor.Add(new Produkt("rovor", 10, "st"));

List<Kund> kundLista = new List<Kund>();



kundLista.Add(new Kund("Knatte", "123"));
kundLista.Add(new Kund("Fnatte", "321"));
kundLista.Add(new Kund("Tjatte", "213"));

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

            LogInModule();

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
    var name = "";
    

    while (true)
    {
        Console.WriteLine("Skriv in användarnamn:");
        name = Console.ReadLine();

        foreach (var kund in kundLista)
        {
            if (kund.Name == name)
            {
                nuvarandeKund = kund;
            }
        }

        if (nuvarandeKund != null)
        {
            Console.WriteLine("Skriv in användarens lösenord:");

            var pw = Console.ReadLine();


        }

        else
        {

        }
    }

}

void CreateNewCustomer()
{

    Console.WriteLine("Skriv in användarens namn:");

    var name = Console.ReadLine();

    Console.WriteLine("Skriv in användarens lösenord:");

    var pw = Console.ReadLine();

    kundX++;

    Kund 


}
