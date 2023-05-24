namespace contrato;

class fisica:contrato{
    public override double CalculoP(){
    if (idade <= 30)
    {
        return ((base.CalculoP()/prazo)+1);
    }
    else if (idade <= 40) 
    {
        return ((base.CalculoP()/prazo)+2);
    }
    else if (idade <= 50) 
    {
        return ((base.CalculoP()/prazo)+3);
    }
    else 
    {
        return ((base.CalculoP()/prazo)+4);
    }
}
  
}


