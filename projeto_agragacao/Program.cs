namespace projeto_agragacao;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto Agregação!"); 

        CartaoCredito cdc = new CartaoCredito();
        Cliente cli = new Cliente();


        cli.Nome = "Dan Correia";

        cdc.Numero = "123456789";
        cdc.DataValidade = "04/2027";

        cdc.Cliente = cli;

        Console.WriteLine("O nome do cliente é: " + cli.Nome);
        Console.WriteLine("O número do cartão é: " + cdc.Numero);
        Console.WriteLine("A data de validade: " + cdc.DataValidade);
        Console.WriteLine("O nome do cliente AGREGADO é: " + cdc.Cliente.Nome);

    }
}
