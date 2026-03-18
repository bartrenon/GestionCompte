namespace GestionCompte.Classe
{
    internal class Banque
    {
        public string nom { get; set; }
        public Dictionary<string, Courant>
            dictionaireCompte = new Dictionary<string, Courant>();


        public void Ajouter(Courant compte) 
        {
            dictionaireCompte.Add(compte.numero, compte);
        }

        public void Supprimer(string numero)
        {
            dictionaireCompte.Remove(numero);
        }

    }
}
