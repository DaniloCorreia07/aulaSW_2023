namespace Produtos_ex2;
class Nacional:Produto{

    public double Taxa {get;set;}

    public override double calculaValor(){
        double tx = (1+(this.Taxa/100));
        return base.calculaValor()+(this.Valor * tx);
    }
}