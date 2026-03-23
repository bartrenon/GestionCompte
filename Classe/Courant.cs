namespace GestionCompte.Classe
{
    public class  Courant : Compte
    {
        public decimal ligneDeCredit;

        public Courant(string numero,  Personne titulaire, decimal ligneDeCredit) : base(numero, 0, titulaire)
        {
            LigneDeCredit = ligneDeCredit;
        }

        public Courant(decimal ligneDeCredit ,string numero, decimal solde, Personne titulaire) : base(numero, solde, titulaire)
        {
            LigneDeCredit = ligneDeCredit;
        }

        public decimal LigneDeCredit
        {
            get
            {
                return ligneDeCredit;
            }

            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException
                        ("La ligne de crédit doit être supérieure ou égale à 0.");
                }
                else
                {
                    ligneDeCredit = value;
                }
            }
        }


        public override bool Retrait(decimal montant)
        {
            if(montant > 0 && solde - montant >= -LigneDeCredit) 
            {
                this.SetSolde(solde - montant);
                return true;
            }

            Console.WriteLine($"le montant est invalide");
            return false;
        }

        protected override decimal CalculInteret() 
        {
            if (solde > 0) 
            {
                return solde * 0.03m;
            }

            return solde * 0.0975m;
        }
    }
}
