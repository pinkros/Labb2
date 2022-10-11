using Butiken;
using System.Xml.Linq;

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


while (nuvarandeKund == null)
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
            CreateNewCustomer();
            break;

        case "0":
            Console.WriteLine("Välkommen åter!");
            Environment.Exit(0);
            break;
        case "kundlista":
            foreach (var kund in kundLista)
            {
                Console.WriteLine(kund);
            }

            Console.ReadLine();
            break;

        default:
            Console.WriteLine("Ej korrekt input, vänligen prova igen!");
            Thread.Sleep(750);
            continue;
            
    }
    
}

while (true)
{
    Console.Clear();
    view.ShopMenu(nuvarandeKund);
    menuVar = Console.ReadLine();

    switch (menuVar)
    {
        //1. Handla
        case "1":
            while (true)
            {
                Console.Clear();
                view.BuyMenu(varor);
                if (int.TryParse(Console.ReadLine(), out int produkt))
                {
                    Console.WriteLine($"Hur många {varor[produkt - 1].Name} vill du köpa?");
                    if (int.TryParse(Console.ReadLine(), out int amount))
                    {
                        nuvarandeKund.LaeggIVagn(varor[produkt - 1], amount, nuvarandeKund.Cart);
                        break;
                    }

                }

                Console.WriteLine("Vänligen skriv ett antal.");
            }

            break;

        //2. Se kundvagn
        case "2":
            break;

        //3. Gå till kassan
        case "3":
            break;

        //0. Logga ut
        case "4":
            break;
        default:
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
            Console.WriteLine("Skriv in ditt lösenord:");

            var pw = Console.ReadLine();

            if (nuvarandeKund.VerifieraPassword(pw))
            {
                
            }
        }

        else
        {
            
        }
    }

}

void CreateNewCustomer()
{
    var name = "";
    var pw = "";

    Console.Clear();

    while (true)
    {
        Console.WriteLine("Skriv in användarnamn:");

        name = Console.ReadLine();

        if (name != null)
        {
            foreach (var c in name)
            {
                if (c == ' ')
                {
                    name = null;
                    break;
                }
            }
            if (name != null){ break; }

        }

        

        Console.WriteLine("Vänligen skriv in ett  användarnamn, inga mellanslag, tack.");
        Thread.Sleep(750);
        Console.Clear();
    }

    while (true)
    {
        Console.WriteLine("Skriv in användarens lösenord:");

        pw = Console.ReadLine();

        if (pw != null)
        {
            foreach (var c in pw)
            {
                if (c == ' ')
                {
                    pw = null;
                    break;
                }
            }
            if (pw != null) { break; }

        }

        Console.WriteLine("Vänligen skriv in ett lösenord, använd inga mellanslag.");
        Thread.Sleep(750);
        Console.Clear();
    }
    

    

    kundLista.Add(new Kund(name, pw));
    Console.WriteLine($" Användaren {kundLista.Last().Name} har nu skapats.");

}
