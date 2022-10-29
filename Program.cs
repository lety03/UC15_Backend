using UC15_backend.Classes;

PessoaFisica novaPF = new PessoaFisica();

novaPF.nome = "Leticia";
novaPF.cpf = "24136258447";

Console.WriteLine($"Bem vindo {novaPF.nome} do CPF {novaPF.cpf}!");