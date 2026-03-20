using GestionCompte.Classe;

namespace GestionCompte.Interface
{
    interface IBanker : ICustomer
    {
        public string numero { get;}

        public Personne titulaire { get;}

        public void AppliquerInteret();

    }
}
