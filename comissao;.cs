comissao;

string vendedor, cod;
double comissao, preco, qnt, valor;

Console.WriteLine("identificação do vendedor: ");
vendedor = Console.ReadLine();

Console.WriteLine("codigo da peça: ");
cod = Console.ReadLine();

Console.WriteLine("preço da peça: ");
preco = int.Parse(Console.ReadLine());

Console.WriteLine("quantidade vendido: ");
qnt = int.Parse(Console.ReadLine());

valor = qnt * preco;
comissao = valor * 0.05;

Console.WriteLine("comissão: " + comissao);