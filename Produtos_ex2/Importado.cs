namespace Produtos_ex2;
class Importado:Produto{
    public double Taxa {get;set;}

    public double Taxaimport {get;set;}

    public override double calculaValor(){
        double tx = (1+(this.Taxa/100));
        double tximp = (1+(this.Taxaimport/100));
        return base.calculaValor()+(this.Valor * tx) + (this.Valor*tximp);
    }
}
