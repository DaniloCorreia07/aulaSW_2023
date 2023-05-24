namespace contrato;
class Program
{
    static void Main(string[] args)
    {
       contrato c = new contrato();
       juridica pj = new juridica();
       fisica pf = new fisica();


       pf.tipo = "Pessoa Física";
       pf.idade = 60;
       pf.pf = 12345678910;

       pj.tipo = "Pessoa Jurídica";
       pj.pj= 01987654321;
       pj.inscricao = 10754857;

       pf.prazo = 10;
       pj.prazo = 10;


       Console.WriteLine(" Tipo:" + pf.tipo + " #idade: " +  pf.idade  +  " #cpf " + pf.pf + "//Valor do contrato: " + pf.CalculoP() + "//Prazo de pagamento: "+ pf.prazo + "//Valor das prestações: " + pf.CalculoP() );
        Console.WriteLine(" Tipo:" + pj.tipo + " #inscrição: " +  pj.inscricao  +  " #cnpj " + pj.pj  + "//Valor do contrato: " + pj.CalculoP() + "//Prazo de pagamento: " + pj.prazo + "//Valor das prestações: " + pj.CalculoP());
    }
}
