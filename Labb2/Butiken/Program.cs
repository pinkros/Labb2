using Butiken;

View view = new View();
List<Produkt> varor = new List<Produkt>();

varor.Add(new Produkt("ägg", 2.59, "st"));
varor.Add(new Produkt("bacon", 15.90, "hg"));
varor.Add(new Produkt("mjöl", 25, "kg"));
varor.Add(new Produkt("mjölk", 17, "l"));

Kund kund0 = new Kund("Knatte", "123");
Kund kund1 = new Kund("Fnatte", "321");
Kund kund2 = new Kund("Tjatte", "213");


Console.WriteLine("Hello, World!");
view.BuyMenu(varor);
