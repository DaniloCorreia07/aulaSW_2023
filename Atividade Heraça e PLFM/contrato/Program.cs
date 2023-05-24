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


       Console.WriteLine(" Tipo:" + pf.tipo + " #idade: " +  pf.idade  +  " #cpf " + pf.pf );
        Console.WriteLine(" Tipo:" + pj.tipo + " #inscrição: " +  pj.inscricao  +  " #cnpj " + pj.pj );
    }
}
