namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hóspedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // IMPLEMENTADO!!!!
            if (hospedes.Count() <= Suite.Capacidade)
            {
                this.Hóspedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // IMPLEMENTADO!!!!
                throw new Exception("A quantidade de Hóspedes excede a capacidade da súite !");
            }
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // IMPLEMENTADO!!!!
            int QuantidadeTotal = Hóspedes.Count;
            return QuantidadeTotal;
        }

        public decimal CalcularValorDiaria()
        {
           decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor *= 0.90M;
            }

            return valor;
        }
    }
}
