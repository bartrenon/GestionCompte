using GestionCompte.Classe;

namespace GestionCompte.Interface
{
    interface ICustomer
    {
        public decimal solde { get; }

        public bool Depot(decimal montant);
        public bool Retrait(decimal montant);
     
    }
}
