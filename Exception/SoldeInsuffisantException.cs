namespace GestionCompte.Exception
{
    internal class SoldeInsuffisantException : ArgumentOutOfRangeException
    {
        public SoldeInsuffisantException(string message) : base(message)
        {
        }
    }
}
