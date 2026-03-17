namespace GestionCompte.Classe
{
    public class Compte
    {
        public string numero { get; set; }
        public decimal solde { get; protected set; }
        public Personne titulaire { get; set; }

        public virtual void Retrait(decimal montant)
        {
            if ((montant > 0 && (solde - montant) >= 0)
            {
                solde -= montant;
                return;
            }

            Console.WriteLine($"le montant est invalide");
        }

        public virtual void Depot(decimal montant)
        {
            if (montant > 0)
            {
                solde += montant;
                return;
            }

            Console.WriteLine($"le montant est invalide");
        }
    }
}
