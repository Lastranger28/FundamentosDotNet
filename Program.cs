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



/* Console.WriteLine("Digite uma letra");
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


Calculadora calc = new Calculadora();
calc.Somar(2, 5);
calc.Subtrair(10, 2);
calc.Dividir(15, 3);
calc.Multiplicar(2, 3);
calc.Potencia(2, 4);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30); 
calc.RaizQuadrada(9);


int soma = 0, numero = 0;

do{
    Console.WriteLine("Digite um numero (0 para parar):");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;
}while(numero != 0);


Console.WriteLine($"Sua soma é: {soma}");
*/

string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.WriteLine("Digite sua opção");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();
    

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente");
            break;
        
        case "2":
            Console.WriteLine("Busca de Cliente");
            break;
        
        case "3":
            Console.WriteLine("Apagar Cliente");
            break;
        
        case "4":
            Console.WriteLine("Encerrado");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}