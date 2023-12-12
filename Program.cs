using TREINO;

Dictionary<string, int> registrocliente = new Dictionary<string, int>();

Conta_Bancaria conta = new Conta_Bancaria();
conta.titular = "nome do titular";
conta.senha = 123456;
conta.saldo = 40;
conta.idconta = 1;

loginBanco();

void loginBanco()
{
    Console.WriteLine("Seja Bem Vindo ao Banco Central");
    Console.Write("\nDigite o nome do titular: ");
    string nomedotitular = Console.ReadLine()!;
    if (registrocliente.ContainsKey(nomedotitular))
    {
        Console.WriteLine($"Seja bem vindo de volta Senhor {nomedotitular}");

    }
    else
    {
        conta.titular = nomedotitular;
        Console.WriteLine($"O senhor {nomedotitular} foi registrado com Sucesso!!");
    }
 

    Console.Write("\nRegistre sua senha: ");
    string senhadotitular = Console.ReadLine()!;
    int senhanum = int.Parse(senhadotitular);
    conta.senha = senhanum;
    if (senhadotitular.Length == 6) // Length é usado para limitar o uso de caracter, impor condição ao usuario
    {
        Console.WriteLine($"Sua senha {senhadotitular} foi registrada com Sucesso!!");
    }

    else if (senhadotitular.Length > 6)
    {
        Console.WriteLine("Sua senha deve ter no máximo 6 caracteres."); Console.WriteLine("Aguarde para uma nova tentativa"); Thread.Sleep(2800);
        Console.Clear(); RepetirRegistroSenha();

    }

    else if (senhadotitular.Length < 6)
    {
        Console.WriteLine("Sua senha deve ter no minimo 6 caracteres."); Console.WriteLine("Aguarde para uma nova tentativa"); Thread.Sleep(2800);
        Console.Clear(); RepetirRegistroSenha();
    }
    else
    {
        Console.WriteLine("Opção Invalida"); Console.WriteLine("Tente Novamente"); Thread.Sleep(1000);
        Console.Clear(); loginBanco();
    }


    Console.WriteLine("\nDigite uma tecla para verificar seu saldo"); Console.ReadKey();
    Console.WriteLine($"Saldo Atual: {conta.saldo}R$");
    Console.Write("\nDeseja depositar ou retirar: ");
    Console.WriteLine("\nDepositar");
    Console.WriteLine("Retirar");
    Console.Write("Escolha uma opção: ");
    string opcao = Console.ReadLine()!;

    if (opcao == "Depositar")
    {
        Console.Clear();
        Console.Write("Digite o valor que deseja: ");
        string valordigitado = Console.ReadLine()!;
        int valornum = int.Parse(valordigitado);

        conta.saldo += valornum;
        Console.WriteLine($"Seu saldo atual é: {conta.saldo}R$");
     
    }

    else if (opcao == "Retirar")
    {
        Console.Write("Digite o valor que deseja Retirar: ");
        string valor = Console.ReadLine()!;
        int valornum = int.Parse(valor);

        conta.saldo -= valornum;
        Console.WriteLine($"Seu saldo é: {conta.saldo}R$");
    }

    else
    {
        Console.WriteLine("Opção Inválida"); Console.WriteLine("Digite Corretamente"); Thread.Sleep(1000);
        Console.Clear(); verificarsaldo();
    }



    Console.WriteLine("\nDigite uma tecla para exibir seu ID"); Console.ReadKey();
    Console.WriteLine($"Seu ID:{conta.idconta}");

    Console.WriteLine("\nDeseja verificar suas informações cadastradas? ");
    Console.WriteLine("Sim");
    Console.WriteLine("Não");
    Console.Write("Escolha uma opção: ");
    string opcao2 = Console.ReadLine()!;

    if (opcao2 == "Sim")
    {
        Console.Clear();
        Console.WriteLine("Exibindo suas informações");
        Thread.Sleep(500);
        Console.WriteLine($"Titular da conta: {conta.titular}");
        Console.WriteLine($"Senha da conta: {conta.senha}");
        Console.WriteLine($"ID da conta: {conta.idconta}");
        Console.WriteLine($"Saldo da conta: {conta.saldo}R$");

        Console.WriteLine("\nObrigado pela preferencia");
        Console.WriteLine("Digite uma tecla para voltar a pagina inicial"); Console.ReadKey(); Console.Clear();
        loginBanco();
    }
    else if (opcao2 == "Não")
    {
        Console.WriteLine("Em breve mais funcionalidades para esta aplicação");
        Console.Clear(); loginBanco();
    }
    else
    {
        Console.WriteLine("Opção Inválida"); Console.WriteLine("Tente Novamente"); Thread.Sleep(1000);
        Console.Clear(); loginBanco();
    }

    void RepetirRegistroSenha()
    {
        Console.WriteLine("Repita sua senha");
        Console.Write("\nRegistre sua senha: ");
        string senhadotitular = Console.ReadLine()!;
        int senhanum = int.Parse(senhadotitular);
        conta.senha = senhanum;
        if (senhadotitular.Length == 6) // Length é usado para limitar o uso de caracter, impor condição ao usuario
        {
            Console.WriteLine($"Sua senha {senhadotitular} foi registrada com Sucesso!!");
        }

        else if (senhadotitular.Length > 6)
        {
            Console.WriteLine("Sua senha deve ter no máximo 6 caracteres."); Console.WriteLine("Aguarde para uma nova tentativa"); Thread.Sleep(2800);
            Console.Clear(); RepetirRegistroSenha();

        }

        else if (senhadotitular.Length < 6)
        {
            Console.WriteLine("Sua senha deve ter no minimo 6 caracteres."); Console.WriteLine("Aguarde para uma nova tentativa"); Thread.Sleep(2800);
            Console.Clear(); RepetirRegistroSenha();
        }
        else
        {
            Console.WriteLine("Opção Invalida"); Console.WriteLine("Tente Novamente"); Thread.Sleep(1000);
            Console.Clear(); loginBanco();
        }
    }
    void verificarsaldo()
    {
        Console.WriteLine("Verificação de Saldo");
        Console.WriteLine("\nDigite uma tecla para verificar seu saldo"); Console.ReadKey();
        Console.WriteLine($"Saldo Atual: {conta.saldo}R$");
        Console.Write("\nDeseja depositar ou retirar: ");
        Console.WriteLine("\nDepositar");
        Console.WriteLine("Retirar");
        Console.Write("Escolha uma opção: ");
        string opcao = Console.ReadLine()!;

        if (opcao == "Depositar")
        {
            Console.Clear();
            Console.Write("Digite o valor que deseja: ");
            string valordigitado = Console.ReadLine()!;
            int valornum = int.Parse(valordigitado);

            conta.saldo += valornum;
            Console.WriteLine($"Seu saldo atual é: {conta.saldo}R$");

        }

        else if (opcao == "Retirar")
        {
            Console.Write("Digite o valor que deseja Retirar: ");
            string valor = Console.ReadLine()!;
            int valornum = int.Parse(valor);

            conta.saldo -= valornum;
            Console.WriteLine($"Seu saldo é: {conta.saldo}R$");
        }

        else
        {
            Console.WriteLine("Opção Inválida"); Console.WriteLine("Digite Corretamente"); Thread.Sleep(1000);
            Console.Clear(); verificarsaldo();
        }
    }
}