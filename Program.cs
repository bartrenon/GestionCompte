using GestionCompte.Classe;
using GestionCompte.Interface;

Personne titulaire = new Personne("renon","bart", DateTime.Now) ;

Console.WriteLine("Pour les compte Epargne");

ICustomer client = new Epargne(DateTime.Now, "123", 500, titulaire);

client.Depot(500);
client.Retrait(200);
Console.WriteLine(client.solde);

Console.WriteLine("Fin Pour le customer");

IBanker banquier = new Epargne(DateTime.Now, "124", 500, titulaire);

banquier.Depot(500);
banquier.Retrait(200);
banquier.AppliquerInteret();
Console.WriteLine(banquier.solde);
Console.WriteLine(banquier.numero);
Console.WriteLine(banquier.titulaire.prenom);

Console.WriteLine("Fin Pour le banquier");
Console.WriteLine("Pour les compte courant");

ICustomer client1 = new Courant(200, "125", 500, titulaire);

client1.Depot(500);
client1.Retrait(200);
Console.WriteLine(client1.solde);

Console.WriteLine("Fin Pour le customer");

IBanker banquier1 = new Courant(200, "126", 500, titulaire);

banquier1.Depot(500);
banquier1.Retrait(200);
banquier1.AppliquerInteret();
Console.WriteLine(banquier1.solde);
Console.WriteLine(banquier1.numero);
Console.WriteLine(banquier1.titulaire.prenom);

Console.WriteLine("Fin Pour le banquier");