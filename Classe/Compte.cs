using GestionCompte.Exception;
using GestionCompte.Interface;

namespace GestionCompte.Classe
{
    public abstract class Compte : IBanker, ICustomer
    {

        public string numero { get; private set; }
        public decimal solde { get; private set; }
        public Personne titulaire { get; private set; }
        protected abstract decimal CalculInteret();

        protected Compte(string numero)
        {
            this.numero = numero;
        }

        protected Compte(string numero, decimal solde, Personne titulaire) : this(numero)
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
            else 
            {
                throw new SoldeInsuffisantException
                    ("Solde insuffisant pour effectuer le retrait.");
                return false;
            }
        }

        public virtual bool Depot(decimal montant)
        {

            if (montant <= 0) 
            {
                throw new ArgumentOutOfRangeException();
                return false;
            }

            solde += montant;
            return true;
        }

        public void AppliquerInteret() 
        {
            solde += CalculInteret();
        }

        protected void SetSolde(decimal montant)
        {
            solde = montant;
        }
    }
}
