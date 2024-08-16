using FundamentosDotNet.Models;

/* Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "André";
pessoa1.Idade = 33;
pessoa1.Apresentar();



int quantidadeEmEstoque = 10;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;


Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");


if (quantidadeCompra == 0){
    Console.WriteLine("Venda inválida");
}else if (possivelVenda){
    Console.WriteLine("Venda realizada.");
} else {
    Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
}
*/ 



Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra){
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    
    default:
        Console.WriteLine("Não é vogal");
        break;
}