namespace contrato;

class contrato{
    public int idade {get;set;}

    public long pf {get;set;}

    public int inscricao {get;set;}

    public long pj {get;set;}

    public string? tipo {get;set;}

    public int prazo {get;set;}

    public virtual double CalculoP(){
        return 1000;
    }

}