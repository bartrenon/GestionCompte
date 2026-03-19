namespace GestionCompte.Classe
{
    public class  Courant : Compte
    {
        public decimal ligneDeCredit;
        
        public decimal LigneDeCredit
        {
            get
            {
                return ligneDeCredit;
            }

            set
            {
                 ligneDeCredit = value >= 0 ? value : ligneDeCredit;
            }
        }


        public override bool Retrait(decimal montant)
        {
            if(montant > 0 && solde - montant >= -LigneDeCredit) 
            {
                solde -= montant;
                return true;
            }

            Console.WriteLine($"le montant est invalide");
            return false;
        }

        protected override decimal CalculInteret() 
        {
            if (this.solde > 0) 
            {
                return this.solde * 0.03m;
            }

            return this.solde * 0.0975m;
        }
    }
}
