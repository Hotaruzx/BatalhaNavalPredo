//Pedro Elias dos Santos Vincensi
using System.Text;
internal class Program

{

    //Variaveis

    //Strings:
        string nome;

    //Inteiros:
        byte opcaoMenu = 0;

    public Program()
    {
        Menu();
    }

    public void Configuracoes()
    {
        Console.WriteLine("Configurações Iniciadas!");
    }

    public void Jogo() 
    {
        Console.WriteLine("O Jogo começou!");
    }

    public void Menu()
    {
        Console.WriteLine("Olá, seja bem vindo! Gostariamos de saber como podemos chama-lo!");
        nome = Console.ReadLine();

        if (string.IsNullOrEmpty(nome))
        {
            nome = "Marinheiro";
        }

        do {
        Console.WriteLine($"Muito prazer {nome}, é um prazer te conhecer!\nE agora, o que deseja fazer?\n1 - Iniciar o Jogo\n2 - Configurações\n3 - Sair");
        opcaoMenu = byte.Parse(Console.ReadLine());

        switch (opcaoMenu) 
        {
            case 1:
                Console.WriteLine("Batalha Iniciada!");
                Jogo();
                break;
            case 2:
                Configuracoes();
                break;
            case 3:
                Console.WriteLine("Saindo do Jogo!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção Inválida!");
                break;
        }                
        
        } while (opcaoMenu != 3);

    }

    private static void Main()
    {
        _ = new Program();
    }

}