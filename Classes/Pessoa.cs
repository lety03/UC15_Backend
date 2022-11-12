using UC15_backend.Interfaces;
using UC15_Backend.Classes;

namespace UC15_backend.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? nome {get; set;}

        public float rendimento { get; set; }

        public Endereco? endereco { get; set; }

        public abstract float CalcularImposto(float rendimento);

    }
}