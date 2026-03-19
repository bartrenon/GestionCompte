using GestionCompte.Classe;
using GestionCompte.Interface;

ICustomer client = new Courant
{
    numero = "123",
    titulaire = new Personne() { prenom = "bart"},
    LigneDeCredit = 200
};

client.Depot(500);
client.Retrait(200);
Console.WriteLine(client.solde);

IBanker banquier = new Courant
{
    numero = "124",
    titulaire = new Personne() { prenom = "bart" },
    LigneDeCredit = 600
};

banquier.Depot(500);
banquier.Retrait(200);
banquier.AppliquerInteret();
Console.WriteLine(banquier.solde);
Console.WriteLine(banquier.numero);
Console.WriteLine(banquier.titulaire.prenom);
