using GestionCompte.Classe;

namespace GestionCompte.Classe
{
    public class Epargne : Compte
    {
        public DateTime dateDernierRetrait {get; private set;}

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
            return this.solde * (4.5m/100);
        }
    }    
}
