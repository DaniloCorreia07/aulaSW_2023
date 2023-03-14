namespace ExercicioAlunos;
class Program
{
    static void Main(string[] args)
    {
      Alunos aluno1 = new Alunos();
       //aluno1.nome = "Fulano da Silva";
       //aluno1.nota1 = 4;
       //aluno1.nota2 = 5;

       //aluno1.menssagem();

       Console.WriteLine("Digite seu nome: ");
       aluno1.nome = Console.ReadLine();
       Console.WriteLine("Seu nome é: " + aluno1.nome);

       Console.WriteLine("Digite a primeira nota: ");
       aluno1.nota1 = double.Parse(Console.ReadLine());
       Console.WriteLine("O número digitado é:  " +aluno1.nota1);

       Console.WriteLine("Digite a segunda nota: ");
       aluno1.nota2 = double.Parse(Console.ReadLine());
       Console.WriteLine("O numero digitado é: " + aluno1.nota2);

       aluno1.menssagem();

    }
}
