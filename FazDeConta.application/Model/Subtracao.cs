namespace FazDeConta.Application.Model
{
    public class Subtrair : OperacaoModel
    {
        public double NumeroASubtrair { get; set; }
        public override double CalcularResultado()
        {
            return NumeroInicial - NumeroASubtrair;
        }
        public override bool Validar()
        {
            if (NumeroASubtrair <= 0)
                return false;

            return true;
        }
    }
}
