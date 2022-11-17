using UC15_backend.Classes;
using UC15_Backend.Classes;


// Console.Clear();

// Console.ForegroundColor = ConsoleColor.DarkBlue;
// Console.BackgroundColor = ConsoleColor.DarkGray;

// Console.WriteLine($"Carregando...");

// for (int i = 0; i < 8; i++)
// {
// Console.Write("||");    
// Thread.Sleep(200);
// }

// Console.ResetColor();


Utils.BarraCarregamento("Carregando");

string? opcao;

do
{
Console.Clear();

Console.WriteLine(@$"
==============================================
|       Bem vindo ao sistema de cadastro     |
|         Pessoa Fisica & Jurídica           |
==============================================

=============================================
|                                           |
|              1 Pessoa Fisica              |        
|                                           |
|              2 Pessoa Juridica            |                                          
|                                           |
|              0 Sair                       |
|                                           |
=============================================
");

opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
        Console.WriteLine("Pessoa fisica");

        PessoaFisica novaPF = new PessoaFisica();
        Endereco novaEndPF = new Endereco();

        novaPF.nome = "Leticia";
        novaPF.cpf = "24136258447";
        novaPF.rendimento = 6000.5f;
        novaPF.dataNacs = new DateTime(2003, 06, 27);

        novaEndPF.logradouro = "Rua Matos belo";
        novaEndPF.numero = 200;
        novaEndPF.complemento = "casa A";
        novaEndPF.endComercial = false;

        novaPF.endereco = novaEndPF;

        Console.WriteLine(@$"
        Nome: {novaPF.nome} 
        Rendimento: {novaPF.rendimento}
        CPF: {novaPF.cpf} 
        Logradouro: {novaPF.endereco.logradouro}
        Numero: {novaPF.endereco.numero}
        ");


        Thread.Sleep(5000);
        break;
    
    case "2":
        Console.WriteLine("Pessoa Juridica");

        PessoaJuridica novaPj = new PessoaJuridica(); 
        Endereco novaEndPj = new Endereco();

        novaPj.nome = "Nome Pj";
        novaPj.razaoSocial = "Razão social Pj";
        novaPj.cnpj = "55.554.444/0001.21";

        novaEndPj.logradouro = "Rua fortaleza";
        novaEndPj.numero = 177;

        novaPj.endereco = novaEndPj;

        Console.WriteLine(@$"
        Nome: {novaPj.nome}
        Razão Social: {novaPj.razaoSocial}
        CNPJ: {novaPj.cnpj} - Valido - {novaPj.ValidarCnpj(novaPj.cnpj)}");

        Console.WriteLine("Tecle Enter para sair");
        Console.ReadLine();
        break;

    case "0":
    Console.WriteLine("Saiu");
        break;

    default:
    Console.WriteLine("Opção invalída");
        break;
}

} while (opcao != "0");

Utils.BarraCarregamento("Finalizando...");



//Console.WriteLine($"Bem vindo {novaPF.nome} do CPF {novaPF.cpf}!");

// PessoaFisica -----------------------------------------------------
//float impostoPagar = novaPF.CalcularImposto(novaPF.rendimento);

//Console.WriteLine(impostoPagar);
//Console.WriteLine(impostoPagar.ToString("C2"));

// PessoaJuridica -----------------------------------------------------
//PessoaJuridica novaPj = new PessoaJuridica();

//Console.WriteLine(novaPj.CalcularImposto(6600.5f));


//DateTime temp = new DateTime(2005, 01, 01);
//Console.WriteLine( novaPF.ValidarDataNasc("09/08/2005"));

