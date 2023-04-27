using Controllers;
using Models;

Console.WriteLine("Projeto Loja");

var data = new Store()
{
    Description = "Test",
    Address = "Rua do Alem"
};

//Parte do INSERT
var returInformation = (new StoreController().Insert(data) ? "Inserido" : "Erro");
Console.WriteLine(returInformation);

//Parte da COnsulta
new StoreController().GetAll().ForEach(x => Console.WriteLine(x));