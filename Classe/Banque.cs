namespace GestionCompte.Classe
{
    internal class Banque
    {
        public string nom { get; set; }
        public Dictionary<string, Compte> dictionaireCompte { get; set; }

        public Banque(string nom)
        {
            this.nom = nom;
            this.dictionaireCompte = new Dictionary<string, Compte>();
        }

        public void Ajouter(Compte compte) 
        {
            dictionaireCompte.Add(compte.numero, compte);
        }

        public void Supprimer(string numero)
        {
            if (!dictionaireCompte.ContainsKey(numero)) 
            {
                return;
            }

            dictionaireCompte.Remove(numero);
        }

    }
}
