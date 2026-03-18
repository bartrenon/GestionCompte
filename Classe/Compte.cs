namespace GestionCompte.Classe
{
    public class Compte
    {
        public string numero { get; set; }
        public decimal solde { get; protected set; }
        public Personne titulaire { get; set; }

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
    }
}
