namespace GestionCompte.Classe
{
    public class Compte
    {
        public string numero { get; set; }
        public decimal solde { get; protected set; }
        public Personne titulaire { get; set; }

        public void Retrait(decimal montant)
        {
            if (montant > 0)
            {
                solde -= montant;
                return;
            }

            Console.WriteLine($"le montant est invalide");
        }

        public void Depot(decimal montant)
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
