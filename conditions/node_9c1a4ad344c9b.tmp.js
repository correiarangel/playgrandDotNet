// See https://aka.ms/new-console-template for more information

int quantEstoque=3;
int quantItensCompra = 4;
bool possivelVenda = quantEstoque >=  quantItensCompra;

Console.WriteLine($"Qt em Estoque: {quantEstoque}");
Console.WriteLine($"Qt Itens de compra: {quantItensCompra}");
Console.WriteLine($"Venada e valida : {possivelVenda}");

if(possivelVenda)Console.WriteLine($"Venada Realizada !");
if(!possivelVenda)Console.WriteLine($"Estoque insuficiente para venda !");
