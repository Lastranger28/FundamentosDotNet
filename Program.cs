using FundamentosDotNet.Models;

/* Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "André";
pessoa1.Idade = 33;
pessoa1.Apresentar();
*/ 


int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;


Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (possivelVenda){
    Console.WriteLine("Venda realizada.");
} else {
    Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
}