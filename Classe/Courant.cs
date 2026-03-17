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

        public Courant(string numero, decimal solde, decimal ligneDeCredit, Personne p)
        {
            this.numero = numero;
            this.solde = solde;
            this.ligneDeCredit = ligneDeCredit;
            titulaire = p;
        }

        public void Retrait(decimal montant)
        {
            if(montant > 0 && solde - montant >= -LigneDeCredit) 
            {
                solde -= montant;
                return;
            }

            Console.WriteLine($"le montant est invalide");
        }
    }
}
