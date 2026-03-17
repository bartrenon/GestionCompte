namespace GestionProjet.Classe
{
    public class Personne
    {
        public string nom { get; set; }

        public string prenom { get; set; }

        public DateTime dateNaiss { get; set; }

        public Personne(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
            dateNaiss = DateTime.Now;
        }
    }
}
