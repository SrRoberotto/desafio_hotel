using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra nas listas de hóspedes
List<Pessoa> hospedes_suite = new List<Pessoa>();
List<Pessoa> hospedes_quarto = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Hóspede 3");
Pessoa p4 = new Pessoa(nome: "Hóspede 4");

hospedes_suite.Add(p1);
hospedes_suite.Add(p2);

hospedes_quarto.Add(p1);
hospedes_quarto.Add(p2);
hospedes_quarto.Add(p3);
//hospedes_quarto.Add(p4);


// Cria as suítes
Suite suiteP = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 100);
Suite suiteN = new Suite(tipoSuite: "Normal", capacidade: 3, valorDiaria: 60);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva1 = new Reserva(diasReservados: 5);
reserva1.CadastrarSuite(suiteP);
reserva1.CadastrarHospedes(hospedes_suite);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva2 = new Reserva(diasReservados: 2);
reserva2.CadastrarSuite(suiteN);
reserva2.CadastrarHospedes(hospedes_quarto);


// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hospedagem tipo: {reserva1.Suite.TipoSuite}");
Console.WriteLine($"Hóspedes: {reserva1.ObterQuantidadeHospedes()}");
Console.WriteLine($"Diárias: {reserva1.DiasReservados}");
Console.WriteLine($"Valor diária: R$ {reserva1.Suite.ValorDiaria}");
Console.WriteLine($"Valor Total: R$ {reserva1.CalcularValorDiaria()}");
//
Console.WriteLine("----------------");
// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hospedagem tipo: {reserva2.Suite.TipoSuite}");
Console.WriteLine($"Hóspedes: {reserva2.ObterQuantidadeHospedes()}");
Console.WriteLine($"Diárias: {reserva2.DiasReservados}");
Console.WriteLine($"Valor diária: R$ {reserva2.Suite.ValorDiaria}");
Console.WriteLine($"Valor Total: R$ {reserva2.CalcularValorDiaria()}");