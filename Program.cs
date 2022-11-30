using UC15_Backend.Classes;

List<PessoaFisica> listaPf = new List<PessoaFisica>();

Utils.BarraCarregamento("Carregando");

string? opcao;

do
{
Console.Clear();

Console.WriteLine(@$"
=============================================
|       Bem vindo ao sistema de cadastro    |
|         Pessoa Fisica & Jurídica          |
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

        string? opcaoPf;

            do
            {
                Console.Clear();     
                Console.WriteLine(@$"
=============================================
|       Escolha uma das opções abaixo       | 
|-------------------------------------------|
|        1 -  Cadastrar Pessoa Física       |        
|                                           |
|        2 -  Listar Pessoa Física          |                                          
|                                           |
|        0 -  Sair                          |
=============================================
");

            opcaoPf = Console.ReadLine();


            PessoaFisica metodosPf = new PessoaFisica();
            // Endereco novaEndPF = new Endereco();

            switch (opcaoPf)
            {
                case "1":

            PessoaFisica novaPF = new PessoaFisica();
            Endereco novaEndPF = new Endereco();

                Console.Clear();

                Console.WriteLine("Digite o nome da pessoa fisica, tecle ENTER depois.");

                novaPF.nome = Console.ReadLine();

                bool dataValida;

                do
                {
                
                Console.WriteLine("Digite a data de nascimento(EX: DD/MM/AAAA):");

                string? dataNascimento = Console.ReadLine();

                dataValida = novaPF.ValidarDataNasc(dataNascimento);

                if (dataValida)
                {
                    DateTime.TryParse( dataNascimento, out DateTime dataConvertida );
                    novaPF.dataNacs = dataConvertida;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error: Data Inválida! Exemplo: DD/MM/AAAA");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Console.Clear();
                    
                }

                } while (dataValida == false); //loop da validação da data até que ela seja verdadeira


                Console.WriteLine($"Digite o numero do CPF, tecle ENTER");
            
                novaPF.cpf = Console.ReadLine();


                Console.WriteLine($"Digite o rendimento mensal, somente números, e tecle ENTER");
            
                novaPF.rendimento = float.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o logradouro, tecle ENTER");
                novaEndPF.logradouro = Console.ReadLine();

                Console.WriteLine($"Digite o número, tecle ENTER");
                novaEndPF.numero = int.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o complemento, tecle ENTER");
                novaEndPF.complemento = Console.ReadLine();

                Console.WriteLine($"Este endereço é comercial? S/N");
                string endCom = Console.ReadLine().ToUpper();

                if (endCom == "S")
                {
                    novaEndPF.endComercial = true;

                }
                else
                {
                    novaEndPF.endComercial = false;
                }
                
                novaPF.endereco = novaEndPF;

                listaPf.Add(novaPF);

                StreamWriter cw = new StreamWriter($"{novaPF.nome}.txt");

                cw.WriteLine(novaPF.nome);

                cw.Close();

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Cadastro concluido!");
                        Console.ResetColor();
                        Thread.Sleep(1000);

                        break;
                    
                    case "2":

                    Console.Clear();

                    if (listaPf.Count > 0)
                    {
                        
                        foreach (PessoaFisica cadaPessoa in listaPf)
                        {
                            Console.Clear();
                            Console.WriteLine(@$"
Nome: {cadaPessoa.nome}
Endereço:{cadaPessoa.endereco.logradouro},{cadaPessoa.endereco.numero}
Imposto a ser pago:{metodosPf.CalcularImposto(cadaPessoa.rendimento).ToString("c")}
CPF: {cadaPessoa.cpf}
");
                    Console.WriteLine($"Aperte ENTER para continuar");
                    
                    Console.ReadLine();                          
                        }
                    }else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Lista vázia, cadastre uma pessoa fisica");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                    }

                    

                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine("Voltando a tela anterior...");
                        Thread.Sleep(1000);

                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Opção invalída");
                        Console.ResetColor();
                        Thread.Sleep(2000);

                        break;
                }
                


                    } while (opcaoPf != "0");


                    // Data de nascimento:{metodosPf.ValidarDataNasc.ToString("d")}


            // novaPF.nome = "Leticia";
            // novaPF.cpf = "24136258447";
            // novaPF.rendimento = 6000.5f;
            // novaPF.dataNacs = new DateTime(2003, 06, 27);

            // novaEndPF.logradouro = "Rua Matos belo";
            // novaEndPF.numero = 200;
            // novaEndPF.complemento = "casa A";

            // novaPF.endereco = novaEndPF;

            // Console.WriteLine(@$"
            // Nome: {novaPF.nome} 
            // Rendimento: {novaPF.rendimento}
            // CPF: {novaPF.cpf} 
            // Logradouro: {novaPF.endereco.logradouro}
            // Numero: {novaPF.endereco.numero}
            // ");


            Thread.Sleep(5000);
            break;
        
        case "2":
            Console.WriteLine("Pessoa Juridica");

            PessoaJuridica novaPj = new PessoaJuridica(); 
            PessoaJuridica metodosPj = new PessoaJuridica(); 
            Endereco novaEndPj = new Endereco();

            // novaPj.nome = "Isabele";
            // novaPj.razaoSocial = "Razão social Pj";
            // novaPj.cnpj = "55.554.444/0001.21";

            // novaEndPj.logradouro = "Rua fortaleza";
            // novaEndPj.numero = 177;

            // novaPj.endereco = novaEndPj;

            // Console.WriteLine(@$"
            // Nome: {novaPj.nome}
            // Razão Social: {novaPj.razaoSocial}
            // CNPJ: {novaPj.cnpj} - Valido - {novaPj.ValidarCnpj(novaPj.cnpj)}");

            // Console.WriteLine("Tecle ENTER para sair");
            // Console.ReadLine();

            // metodosPj.Inserir(novaPj);
            List<PessoaJuridica> listaExibicaoPj = metodosPj.LerArquivo();

            foreach ( PessoaJuridica cadaPessoa in listaExibicaoPj)
            {
            Console.WriteLine(@$"
Nome: {cadaPessoa.nome}
Razão Social: {cadaPessoa.razaoSocial}
CNPJ: {cadaPessoa.cnpj} - Valido - {cadaPessoa.ValidarCnpj(cadaPessoa.cnpj)}");

            Console.WriteLine("Tecle ENTER para sair");
            Console.ReadLine();
            }

            break;

        case "0":
        Console.Clear();
        Console.WriteLine("Obrigada por utilizar nosso sistema!^.^");
        Thread.Sleep(2000);
        Utils.BarraCarregamento("Finalizando...");
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

