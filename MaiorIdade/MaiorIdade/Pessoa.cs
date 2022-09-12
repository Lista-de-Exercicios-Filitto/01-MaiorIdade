namespace MaiorIdade
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string? nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"{Nome} tem {Idade} anos.");
        }

        public void MaiorIdadePessoa()
        {
            Pessoa pessoa = new Pessoa();
            Pessoa pessoa2 = new Pessoa();
            Pessoa pessoa3 = new Pessoa();

            Console.WriteLine("Informe o nome da 1ª pessoa: ");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da 1ª pessoa: ");
            pessoa.Idade = Convert.ToInt32(Console.ReadLine());
            pessoa.ExibirDados();

            Console.WriteLine("Informe o nome da 2ª pessoa: ");
            pessoa2.Nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da 2ª pessoa: ");
            pessoa2.Idade = Convert.ToInt32(Console.ReadLine());
            pessoa2.ExibirDados();

            Console.WriteLine("Informe o nome da 3ª pessoa: ");
            pessoa3.Nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da 3ª pessoa: ");
            pessoa3.Idade = Convert.ToInt32(Console.ReadLine());
            pessoa3.ExibirDados();

            if (pessoa.Idade > pessoa2.Idade && pessoa.Idade > pessoa3.Idade)
            {
                Console.WriteLine($"A pessoa com maior idade é {pessoa.Nome} com {pessoa.Idade}");
            }
            else if (pessoa2.Idade > pessoa.Idade && pessoa2.Idade > pessoa3.Idade)
            {
                Console.WriteLine($"A pessoa com maior idade é {pessoa2.Nome} com {pessoa2.Idade}");
            }
            else
            {
                Console.WriteLine($"A pessoa com maior idade é {pessoa3.Nome} com {pessoa3.Idade}");
            }
        }
    }
}
