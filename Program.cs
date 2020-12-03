using System;

namespace Exercicio_individual_Tema_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto;"); //Pede os dados do produto para o usuario
            Console.Write("Nome: "); //nome do produto
            string nome = Console.ReadLine();
            Console.Write("Preço: "); //preço do produto
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: "); // quantidade de produtos
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade); //atribui os dados dos produtos ao objeto

            Console.WriteLine("Dados do produto: " + p); //mostra os dados do produto

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine()); 
            p.AdcionarProdutos(qtd); //adciona uma quantidade de produtos no estoque

            Console.WriteLine("Dados do produtos: " + p); //mostra os dados do produto

            Console.Write("Digite o número de produtos a serem removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd); //remove uma quantidade de produtos no estoque

            Console.WriteLine("Dados do produtos: " + p); //mostra os dados do produto

            Console.ReadKey();
        }
    }
}
