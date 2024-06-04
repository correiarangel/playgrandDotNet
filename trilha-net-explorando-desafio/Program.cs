using System.Text;
using DesafioProjetoHospedagem.Models;

internal class Program
{
         private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Cria os modelos de hóspedes e cadastra na lista de hóspedes
            List<Pessoa> hospedes = CreateListUser();

            // Cria a suíte
            Suite suite = CreateSuite();

            // Cria uma nova reserva, passando a suíte e os hóspedes
            Reserva reserva = CreateReservas(suite, hospedes);

            // Exibe a quantidade de hóspedes e o valor da diária
            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

        } 

    static List<Pessoa> CreateListUser()
    {
        List<Pessoa> hospedes = new List<Pessoa>();

        Pessoa p1 = new Pessoa(nome: "Tião", "Hóspede 1");
        Pessoa p2 = new Pessoa(nome: "Ze", "Hóspede 2");

        hospedes.Add(p1);
        hospedes.Add(p2);
        return hospedes;
    }
    static Suite CreateSuite()
    {
        Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);
        return suite;
    }

    static Reserva CreateReservas(Suite suite, List<Pessoa> hospedes)
    {
        Reserva reserva = new Reserva(diasReservados: 20);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);
        return reserva;
    }
}