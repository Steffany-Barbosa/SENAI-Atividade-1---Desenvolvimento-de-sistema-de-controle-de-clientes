using Codificacao.Classes;

string opcao = "";

do
{
    Console.Clear();

    Console.WriteLine(@"
1 - Cadastrar PJ
2 - Visualizar PJ
3 - Sair
");

    opcao = Console.ReadLine()!;
    PessoaJuridica metodosPJ = new PessoaJuridica();

    if (opcao == "1")
    {
        Console.Clear();

        PessoaJuridica pj = new PessoaJuridica();

        Console.WriteLine("Digite o nome da Pessoa Juridica: ");
        pj.Nome = Console.ReadLine()!;

        Console.WriteLine("Digite o CNPJ da Pessoa Juridica: ");
        pj.CNPJ = Console.ReadLine()!;

        Console.WriteLine("Digite o Rendimento da Pessoa Juridica: ");
        pj.Rendimento = float.Parse(Console.ReadLine()!);

        metodosPJ.Inserir(pj);
    }
    else if(opcao == "2")
    {
        //LER PESSOA JURIDICA
    }
    else if(opcao == "3")
    {
        Console.Clear();
        Console.WriteLine("Obrigado por usar o sistema");
    }

} while (opcao != "3");