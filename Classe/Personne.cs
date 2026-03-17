namespace GestionCompte.Classe
{
    public class Personne
    {
        public string nom { get; set; }

        public string prenom { get; set; }

        public DateOnly dateNaiss { get; set; }

        public Personne(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
            dateNaiss = new DateOnly(2024, 3, 17);
        }
    }
}
