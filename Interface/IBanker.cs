using GestionCompte.Classe;

namespace GestionCompte.Interface
{
    interface IBanker
    {
        public decimal solde { get;}

        public string numero { get;}

        public Personne titulaire { get;}

        public bool Depot(decimal montant);
        public bool Retrait(decimal montant);
        public void AppliquerInteret();

    }
}
