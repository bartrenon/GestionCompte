using GestionCompte.Classe;

namespace GestionCompte.Classe
{
    public class Epargne : Compte
    {

        public DateTime dateDernierRetrait {get; private set;}

        public Epargne(DateTime dateDernierRetrait, string numero, decimal solde, Personne titulaire) : base(numero, solde, titulaire)
        {
            this.dateDernierRetrait = dateDernierRetrait;
        }

        public override bool Retrait(decimal montant)
        {
            if (base.Retrait(montant)) 
            {
                dateDernierRetrait = DateTime.Now;
                return true;
            }

            return false;
        }

        protected override decimal CalculInteret()
        {
            return this.solde * 0.045m;
        }
    }    
}
