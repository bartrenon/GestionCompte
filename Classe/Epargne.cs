using GestionCompte.Classe;

namespace GestionCompte.Classe
{
    public class Epargne : Compte
    {
        public DateTime dateDernierRetrait {get; set;}

        public override bool Retrait(decimal montant)
        {
            if (base.Retrait(montant)) 
            {
                dateDernierRetrait = DateTime.Now;
                return true;
            }

            return false;
        }
    }    
}
