namespace contrato;

class juridica:contrato{
    public override double CalculoP(){
    return ((base.CalculoP()/prazo)+3);
   }
}