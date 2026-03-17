using GestionCompte.Classe;

namespace GestionCompte.Classe
{
    public class Epargne : Compte
    {
        public DateOnly dateDernierRetrait {get; set;}

        public void Retrait(decimal montant)
        {
            if (montant > 0 && (solde - montant) >= 0)
            {
                solde -= montant;
                return;
            }

            Console.WriteLine($"le montant est invalide");
        }

        public Epargne(string numero, decimal solde, DateOnly dateDernierRetrait, Personne p)
        {
            this.numero = numero;
            this.solde = solde;
            this.dateDernierRetrait = dateDernierRetrait;
            titulaire = p;
        }
    }    
}
