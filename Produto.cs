using System;
using System.Globalization;

public class Produto
{
    public string Nome; //variavel do nome do produto
    public int Quantidade; //variavel da quantidade de produtos
    public double Preco; //variavel do preço do produto

    public Produto(string nome, double preco, int quantidade) //Construtor
    {
        Nome = nome;
        Quantidade = quantidade;
        Preco = preco;
    }

    public double ValorTotalEmEstoque() //metodo que mostra o valor total em reais do estoque
    {
        return Preco * Quantidade;
    }

    public void AdcionarProdutos(int quantidade) //metodo que adciona produtos no estoque
    {
        Quantidade = Quantidade + quantidade;
    }

    public void RemoverProdutos(int quantidade) //metodo que remove produtos do estoque
    {
        Quantidade = Quantidade - quantidade;
    }

    public override string ToString() //metodo que mostra todos os dados do produtos
    {
        return Nome
        + ", R$"
        + Preco.ToString("F2", CultureInfo.InvariantCulture) //mostra apenas 2(F2) numeros depois da virgula
        + ", "
        + Quantidade
        + " unidades, Total: R$"
        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); //mostra apenas 2(F2) numeros depois da virgula
    }
}
