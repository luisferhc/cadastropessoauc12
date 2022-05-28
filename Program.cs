using cadastropessoauc12.Classes;

PessoaFisica novaPf = new PessoaFisica();
PessoaFisica metodosPf = new PessoaFisica();
Endereco novoEndPf = new Endereco();

novaPf.Nome = "Alles Blau";
novaPf.dataNasc = new DateTime(2000, 01, 01);
novaPf.Cpf = "1234567890";
novaPf.Rendimento = 3500.5F;

novoEndPf.logradouro = "Rua das Flores";
novoEndPf.numero = 594;
novoEndPf.complemento = "Livraria Globo";
novoEndPf.endComercial = true;

novaPf.Endereco = novoEndPf;


Console.WriteLine(@$"
Nome: {novaPf.Nome}
Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
Maior de idade: {metodosPf.ValidarDataNasc(novaPf.dataNasc)}
");


// Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}"); // Interpolação
// Console.WriteLine("Nome: " + novaPf.Nome + " Nome: " + novaPf.Nome); // Concatenação