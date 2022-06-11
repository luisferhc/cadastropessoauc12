using cadastropessoauc12.Classes;

Console.Clear();
Console.WriteLine(@$"
============================================
|    Bem vindo ao sistema de cadastro de   |
|        Pessoas Físicas e Jurídicas       |
============================================        
");


Utils.BarraCarregamento("Iniciando", 100, 40);


string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
============================================
|        Escolha uma das opções abaixo     |
|------------------------------------------|   |
|           1 - Pessoa Física              |
|           2 - Pessoa Jurídica            |
|                                          |
|           0 - Sair                       |
============================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
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

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPf.Nome}
Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
Maior de idade: {metodosPf.ValidarDataNasc(novaPf.dataNasc)}
");
            // Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}"); // Interpolação
            // Console.WriteLine("Nome: " + novaPf.Nome + " Nome: " + novaPf.Nome); // Concatenação

            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();

            break;

        case "2":
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

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}, Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
Endereço: {novaPj.Endereco.logradouro}, Nº: {novaPj.Endereco.numero}
Complemento: {novaPj.Endereco.complemento}
");

            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();

            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema!");
            Thread.Sleep(3000);

            Utils.BarraCarregamento("Finalizando", 500, 6);

            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Opção Inválida. Por favor, digite uma opção válida.");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }

} while (opcao != "0");


// static void BarraCarregamento(string texto, int tempo, int quantidade)
// {
//     Console.BackgroundColor = ConsoleColor.Green;
//     Console.ForegroundColor = ConsoleColor.Yellow;

//     Console.Write(texto);

//     for (var contador = 0; contador < quantidade; contador++)
//     {
//         Console.Write(".");
//         Thread.Sleep(tempo);
//     }

//     Console.ResetColor();
// }