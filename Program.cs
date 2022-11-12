using UC15_backend.Classes;

PessoaFisica novaPF = new PessoaFisica();

novaPF.nome = "Leticia";
novaPF.cpf = "24136258447";
novaPF.rendimento = 6000.5f;

//Console.WriteLine($"Bem vindo {novaPF.nome} do CPF {novaPF.cpf}!");

// PessoaFisica -----------------------------------------------------
float impostoPagar = novaPF.CalcularImposto(novaPF.rendimento);

Console.WriteLine(impostoPagar);
Console.WriteLine(impostoPagar.ToString("C2"));

// PessoaJuridica -----------------------------------------------------
PessoaJuridica novaPj = new PessoaJuridica();

Console.WriteLine(novaPj.CalcularImposto(6600.5f));



