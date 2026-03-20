namespace GestionCompte.Classe
{
    public class Personne
    {
        public string nom { get; init; }
        public string prenom { get; init; }
        public DateTime dateNaiss { get; init; }

        public Personne(string nom, string prenom, DateTime dateNaiss)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaiss = dateNaiss;
        }
    }
}
