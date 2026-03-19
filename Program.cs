using GestionCompte.Classe;

Console.WriteLine("fgf");


Courant c = new Courant();
Courant c2 = new Courant();

c.Depot(1500m);
c2.LigneDeCredit = 500;
c2.Depot(200);

Console.WriteLine(c.solde);
Console.WriteLine(c2.solde);

c2.Retrait(400);
Console.WriteLine(c2.solde);

c.AppliquerInteret();
c2.AppliquerInteret();

Console.WriteLine(c.solde);
Console.WriteLine(c2.solde);