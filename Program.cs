using cadastropessoauc12.Classes;

Console.Clear();
Console.WriteLine(@$"
============================================
|    Bem vindo ao sistema de cadastro de   |
|        Pessoas Físicas e Jurídicas       |
============================================        
");


Utils.BarraCarregamento("Iniciando", 100, 40);

List<PessoaFisica> listaPf = new List<PessoaFisica>();
List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
============================================
|        Escolha uma das opções abaixo     |
|------------------------------------------|   
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

            string? opcaoPf;
            do
            {

                Console.Clear();
                Console.WriteLine(@$"
============================================
|        Escolha uma das opções abaixo     |
|------------------------------------------|   
|           1 - Cadastrar Pessoa Física    |
|           2 - Listar Pessoas Físicas     |
|                                          |
|           0 - Voltar ao menu anterior    |
============================================
");

                opcaoPf = Console.ReadLine();
                PessoaFisica metodosPf = new PessoaFisica();
                switch (opcaoPf)
                {
                    case "1":
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa física que deseja cadastrar");
                        novaPf.Nome = Console.ReadLine();

                        bool dataValida;
                        do
                        {

                            Console.WriteLine($"Digite a data de nascimento. Ex:DD/MM/AAAA");
                            string? dataNascimento = Console.ReadLine();

                            dataValida = metodosPf.ValidarDataNasc(dataNascimento);

                            if (dataValida) // podia ser (dataValida == true), o == true sempre está implícito
                            {
                                DateTime DataConvertida;
                                DateTime.TryParse(dataNascimento, out DataConvertida);

                                novaPf.dataNasc = DataConvertida;

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data digitada inválida. Por favor, digite uma data válida.");
                                Console.ResetColor();
                                Thread.Sleep(3000);
                            }

                        } while (dataValida == false);

                        Console.WriteLine($"Digite o número do CPF");
                        novaPf.Cpf = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento mensal (DIGITE SOMENTE NÚMEROS)");
                        novaPf.Rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEndPf.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número");
                        novoEndPf.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento (Aperte ENTER para vazio");
                        novoEndPf.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? S/N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEndPf.endComercial = true;
                        }
                        else
                        {
                            novoEndPf.endComercial = false;
                        }

                        novaPf.Endereco = novoEndPf;

                        listaPf.Add(novaPf);

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;

                    case "2":

                        Console.Clear();

                        if (listaPf.Count > 0)
                        {
                            foreach (PessoaFisica cadaPessoa in listaPf)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
Nome: {cadaPessoa.Nome}
Endereço: {cadaPessoa.Endereco.logradouro}, {cadaPessoa.Endereco.numero}
Imposto a ser pago: {metodosPf.PagarImposto(cadaPessoa.Rendimento).ToString("C")}
");


                                Console.WriteLine("Aperte 'ENTER' para continuar");
                                Console.ReadLine();

                            }
                        }
                        else
                        {
                            Console.WriteLine($"lista vazia");
                            Thread.Sleep(3000);
                        }

                        break;

                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção Inválida. Por favor, digite uma opção válida.");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;
                }


            } while (opcaoPf != "0");

            // "if ternário": condição ? "Sim" ; "Não"

            // Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}"); // Interpolação
            // Console.WriteLine("Nome: " + novaPf.Nome + " Nome: " + novaPf.Nome); // Concatenação

            break;

        case "2":

            string? opcaoPj;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
============================================
|        Escolha uma das opções abaixo     |
|------------------------------------------|   
|           1 - Cadastrar Pessoa Jurídica  |
|           2 - Listar Pessoas Jurídicas   |
|                                          |
|           0 - Voltar ao menu anterior    |
============================================
");
                opcaoPj = Console.ReadLine();
                PessoaJuridica metodosPj = new PessoaJuridica();

                switch (opcaoPj)
                {
                    case "1":

                        PessoaJuridica novaPj = new PessoaJuridica();
                        Endereco novoEndPj = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa jurídica que deseja cadastrar");
                        novaPj.Nome = Console.ReadLine();

                        Console.WriteLine($"Digite a Razão Social");
                        novaPj.RazaoSocial = Console.ReadLine();

                        bool cnpjValido;
                        do
                        {
                            Console.WriteLine($"Digite o CNPJ (APENAS NÚMEROS)");
                            string? cnpj = Console.ReadLine();

                            cnpjValido = metodosPj.ValidarCnpj(cnpj);

                            if (cnpjValido)
                            {
                                novaPj.Cnpj = cnpj;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"CNPJ inválido. Por favor, digite um CNPJ válido");
                                Console.ResetColor();
                                Thread.Sleep(3000);
                            }
                        } while (cnpjValido == false);

                        Console.WriteLine($"Digite o rendimento mensal (SOMENTE NÚMEROS)");
                        novaPj.Rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEndPj.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número");
                        novoEndPj.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento (Aperte ENTER para vazio");
                        novoEndPj.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? S/N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEndPj.endComercial = true;
                        }
                        else
                        {
                            novoEndPj.endComercial = false;
                        }

                        novaPj.Endereco = novoEndPj;

                        listaPj.Add(novaPj);

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso!");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;

                    case "2":

                        Console.Clear();

                        if (listaPj.Count > 0)
                        {
                            foreach (PessoaJuridica cadaPessoa in listaPj)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
Nome: {cadaPessoa.Nome}
Razão Social: {cadaPessoa.RazaoSocial}
CNPJ: {cadaPessoa.Cnpj}
Endereço: {cadaPessoa.Endereco.logradouro}, Nº: {cadaPessoa.Endereco.numero}
Complemento: {cadaPessoa.Endereco.complemento}
Rendimento: {cadaPessoa.Rendimento}
Imposto a ser pago: {metodosPj.PagarImposto(cadaPessoa.Rendimento).ToString("C")}
");

                                Console.WriteLine("Aperte ENTER para continuar");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Lista vazia");
                            Thread.Sleep(3000);
                        }

                        break;

                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção Inválida. Por favor, digite uma opção válida.");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;
                }

            } while (opcaoPj != "0");

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