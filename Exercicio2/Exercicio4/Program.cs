// See https://aka.ms/new-console-template for more information

using Exercicio4;

var entrega = ServicoFabrica<Entrega>.NovaInstancia();
var venda = ServicoFabrica<Venda>.NovaInstancia();

entrega.Executar();
venda.Executar();