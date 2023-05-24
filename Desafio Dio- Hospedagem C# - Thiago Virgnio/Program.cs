using System.Text;
using DesafioProjetoHospedagemThiago.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Thiago Virginio 1");
Pessoa p2 = new Pessoa(nome: "Dayanna Maria");
Pessoa p2 = new Pessoa(nome: "Samuel Alexandre");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
try
{
	Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
}
catch (Exception ex)
{
	Console.WriteLine($"Quantidade de hóspedes não pode exceder {suite.Capacidade}.\n{ex.Message}");
}
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");