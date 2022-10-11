using Butiken;
using System.Xml.Linq;

//Denna kod är som den är, det är inte mitt bästa, men jag har lyckats med något i alla fall.
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

    while (nuvarandeKund == null)
    {
        Console.Clear();
        Console.WriteLine("Välkommen till HandlarN^'s Lanthandel!\n");

        view.LogInMenu();
        menuVar = Console.ReadLine();

        switch (menuVar)
        {
                
            //    1. Logga in
            case "1":
                LogInModule();
                break;

            //    2.Registrera ny användare
            case "2":
                CreateNewCustomer();
                break;

            //   0.Avsluta
            case "0":
                Console.WriteLine("Välkommen åter!");
                Environment.Exit(0);
                break;

            //alternativ för de som känner till/testning.
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
                    if (int.TryParse(Console.ReadLine(), out int produkt) || produkt != 0)
                    {
                        Console.WriteLine($"Hur många {varor[produkt - 1].Enhet} {varor[produkt - 1].Name} vill du köpa?");
                        if (int.TryParse(Console.ReadLine(), out int amount))
                        {
                            nuvarandeKund.LaeggIVagn(varor[produkt - 1], amount, nuvarandeKund.Cart);
                            break;
                        }

                    }

                    Console.WriteLine("Vänligen skriv ett heltal.");
                }

                break;

            //2. Se kundvagn
            case "2":
                Console.Clear();
                nuvarandeKund.ViewCart();
                Console.WriteLine("Tryck 'Enter' för att gå tillbaka.");
                Console.ReadLine();
                break;

            //3. Gå till kassan
            case "3":
                Console.WriteLine($"Du har handlat följande:\n");
                nuvarandeKund.ViewCart();
                Console.WriteLine($"Tack för idag, {nuvarandeKund.Name}!");
                nuvarandeKund.Cart.Clear();
                nuvarandeKund = null;
                Console.ReadLine();
                break;

            //0. Logga ut
            case "0":
                Console.WriteLine("Du kommer strax tas  till huvudmenyn.");
                nuvarandeKund = null;
                Thread.Sleep(750);
                break;
            default:
                Console.WriteLine("Vänligen välj ett alternativ från menyn.");
                Thread.Sleep(750);
                continue;
        }

        if (nuvarandeKund == null)
        {
            break;
        }
    }
}

void LogInModule()
{
    string? name;
    while (true)
    {
        if (nuvarandeKund != null)
        {
            Console.WriteLine("Skriv in ditt lösenord:");

            var pw = Console.ReadLine();

            if (nuvarandeKund.VerifieraPassword(pw))
            {
                break;
            }
        }

        else
        {
            while (true)
            {
                Console.Clear();
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
                    break;
                }
            
                Console.WriteLine("Kunden kunde inte hittas. " +
                                  "Vill du skapa en ny kund eller försöka igen?\n" +
                                  "1. Ny kund\n " +
                                  "2. Försöka igen");
                menuVar = Console.ReadLine();

                switch (menuVar)
                {
                    case "1":
                        CreateNewCustomer();
                        break;
                    case "2":
                        continue;
                    default:
                        Console.WriteLine("Vänligen välj 1 eller 2.");
                        continue;
                }
            }


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
        Console.Clear();
        Console.WriteLine("Skriv in det nya användarnamnet:");

        name = Console.ReadLine();

        if (kundLista.Any(p => p.Name.Contains(name)))
        {
            Console.WriteLine("Någon har redan det namnet! Vänligen välj ett annat namn.");
            Thread.Sleep(1200);
            continue;
        }

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
