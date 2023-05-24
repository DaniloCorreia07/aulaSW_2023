namespace fala;
class Program
{
    static void Main(string[] args)
    {
      Animal F1 = new Animal();
      Homem H1 = new Homem();
      Gato G1 = new Gato();
      Cao C1 = new Cao();


     H1.Falar = "Oi ";
     G1.Falar = "Miau ";
     C1.Falar = "Au AU";

     Console.WriteLine("Homem fala: " + H1.Falar);
     Console.WriteLine("Gato faz: " + G1.Falar);
     Console.WriteLine("Cachorro faz: " + C1.Falar);





    }
}
