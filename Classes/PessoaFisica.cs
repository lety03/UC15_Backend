using UC15_backend.Interfaces;

namespace UC15_backend.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {

            public string? cpf { get; set; }

            public DateTime DataNacs { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime DataNasc)
        {
            throw new NotImplementedException();
        }
    }
}