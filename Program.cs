using cadastropessoauc12.Classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.Nome = "Alles Blau";

Console.WriteLine(novaPf.Nome);

Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}"); // Interpolação
Console.WriteLine("Nome: " + novaPf.Nome + " Nome: " + novaPf.Nome); // Concatenação