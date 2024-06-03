namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            int obterQuant = hospedes.Count(); ;
            if (Suite.Capacidade < obterQuant)
            {
                throw new Exception("Ops ! Quantidade de hospede maior que Quantidade de hospedes ");
            }

            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int? qt = Hospedes.Count();
            return qt ?? 0;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            decimal desconto = Desconto(valor);
            valor = valor - desconto;
            return valor;
        }
        decimal Desconto(decimal valor)
        {
            if (DiasReservados > 10)
                return valor / 100 * 10;

            return 0;

        }
    }
}