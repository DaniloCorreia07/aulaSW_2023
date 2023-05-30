namespace Produtos_ex2;
class Program
{
    static void Main(string[] args)
    {
        //intância de cada classe
       Estadual prodEstadual = new Estadual();
       Nacional prodNacional = new Nacional();
       Importado prodImport = new Importado();


       //Instaciando valores para os atributos comuns
       Console.WriteLine("Digite sua descrição do Prod Estadual");
       prodEstadual.Descricao = Console.ReadLine();
       Console.WriteLine("Digite o valor do Prod Estadual");
       prodEstadual.Valor = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("Digite o valor do Imposto Prod Estadual");
       prodEstadual.Imposto = Convert.ToDouble(Console.ReadLine());


       Console.Write("Valor do produto calculado com o Imposto: ");
       Console.Write(prodEstadual.calculaValor());


       //Instaciando valores para os produtos Nacional
       Console.WriteLine("Digite sua descrição do Prod Nacional");
       prodNacional.Descricao = Console.ReadLine();
       Console.WriteLine("Digite o valor do Prod Nacional");
       prodNacional.Valor = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("Digite o valor do Imposto Prod Nacional");
       prodNacional.Imposto = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("Digite o Valor da Taxa Prod Nacional");
       prodNacional.Taxa = Convert.ToDouble(Console.ReadLine());


       Console.Write("Valor do produto calculado com o Imposto: ");
       Console.Write(prodNacional.calculaValor());


       //Instaciando valores para os produtos Importados
       Console.WriteLine("Digite sua descrição do Prod Importado");
       prodImport.Descricao = Console.ReadLine();
       Console.WriteLine("Digite o valor do Prod Importado");
       prodImport.Valor = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("Digite o valor do Imposto Prod Importado");
       prodImport.Imposto = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("Digite o Valor da Taxa Prod Importado");
       prodNacional.Taxa = Convert.ToDouble(Console.ReadLine());


       Console.Write("Valor do produto calculado com o Imposto e a taxa de importação: ");
       Console.Write(prodImport.calculaValor());

       
    }
}
