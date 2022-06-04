using cadastropessoauc12.Classes;

// PessoaFisica novaPf = new PessoaFisica();
// PessoaFisica metodosPf = new PessoaFisica();
// Endereco novoEndPf = new Endereco();

// novaPf.Nome = "Alles Blau";
// novaPf.dataNasc = new DateTime(2000, 01, 01);
// novaPf.Cpf = "1234567890";
// novaPf.Rendimento = 3500.5F;

// novoEndPf.logradouro = "Rua das Flores";
// novoEndPf.numero = 594;
// novoEndPf.complemento = "Livraria Globo";
// novoEndPf.endComercial = true;

// novaPf.Endereco = novoEndPf;


// Console.WriteLine(@$"
// Nome: {novaPf.Nome}
// Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
// Maior de idade: {metodosPf.ValidarDataNasc(novaPf.dataNasc)}
// ");

// Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}"); // Interpolação
// Console.WriteLine("Nome: " + novaPf.Nome + " Nome: " + novaPf.Nome); // Concatenação

PessoaJuridica novaPj = new PessoaJuridica();
PessoaJuridica metodosPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.Nome = "Nome Pj";
novaPj.RazaoSocial = "Razão Social Pj";
novaPj.Cnpj = "00000000000100";
novaPj.Rendimento = 10000.5F;

novoEndPj.logradouro = "Vereda dos Buritis";
novoEndPj.numero = 3;
novoEndPj.complemento = "Girassol Informática";
novoEndPj.endComercial = true;

novaPj.Endereco = novoEndPj;

Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}, Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
Endereço: {novaPj.Endereco.logradouro}, Nº: {novaPj.Endereco.numero}
Complemento: {novaPj.Endereco.complemento}
");
