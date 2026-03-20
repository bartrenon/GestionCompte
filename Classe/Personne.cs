namespace GestionCompte.Classe
{
    public class Personne
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime dateNaiss { get; set; }

        public Personne(string nom, string prenom, DateTime dateNaiss)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaiss = dateNaiss;
        }
    }
}
