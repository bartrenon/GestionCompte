using GestionProjet.Classe;

Personne p = new Personne("bart", "renon");

Courant c = new Courant("5",150,80,p);

Console.WriteLine($"{p.nom} {p.prenom} {p.dateNaiss}");

Console.WriteLine($"{c.solde} {c.ligneDeCredit}");

c.Depot(50000);

Console.WriteLine($"{c.solde} {c.ligneDeCredit}");

c.Retrait(150);

Console.WriteLine($"{c.solde} {c.ligneDeCredit}");

c.LigneDeCredit = 500;

Console.WriteLine($"{c.solde} {c.ligneDeCredit}");

c.Retrait(100000);

Console.WriteLine($"{c.solde} {c.ligneDeCredit}");

c.LigneDeCredit = -1500;

Console.WriteLine($"{c.solde} {c.ligneDeCredit}");

Banque b = new Banque("ING");

Console.WriteLine(b.nom);