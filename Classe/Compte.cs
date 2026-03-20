using GestionCompte.Interface;

namespace GestionCompte.Classe
{
    public abstract class Compte : IBanker, ICustomer
    {

        public string numero { get; set; }
        public decimal solde { get; protected set; }
        public Personne titulaire { get; set; }
        protected abstract decimal CalculInteret();

        public Compte(string numero)
        {
            this.numero = numero;
        }

        public Compte(string numero, decimal solde, Personne titulaire) : this(numero)
        {
            this.solde = solde;
            this.titulaire = titulaire;
        }

        public virtual bool Retrait(decimal montant)
        {
            if ((montant > 0 && (solde - montant) >= 0))
            {
                solde -= montant;
                return true;
            }

            Console.WriteLine($"le montant est invalide");
            return false;
        }

        public virtual bool Depot(decimal montant)
        {
            if (montant > 0)
            {
                solde += montant;
                return true;
            }

            Console.WriteLine($"le montant est invalide");
            return false;
        }

        public void AppliquerInteret() 
        {
            solde += CalculInteret();
        }
    }
}
