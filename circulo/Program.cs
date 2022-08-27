namespace circulo;

public class Program
{
    static void Main(string[] args)
    {
        //Fazer um programa para ler o valor "r" do raio de um circulo e depois mostrar o valor da area
        //do circulo com três casas decimais.
        //A formula da area do circulo é a seguinte: area = A = π r².
        //Você pode usar o valor π fornecido pela biblioteca de sua linguagem de programação,
        //ou então, se preferir, use diretamente o valor 3.14159

        double raio, area;

        Console.WriteLine("Digite o valor do raio do circulo!");
        Console.Write("Raio = ");
        raio = double.Parse(Console.ReadLine());

        area = 3.14159 * raio * raio;

        Console.WriteLine("A area do raio é = " + area);
    }
}