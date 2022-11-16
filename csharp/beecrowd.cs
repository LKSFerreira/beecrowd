internal class Program
{


    private static void Main(string[] args)
    {

        /** beecrowd 1001

        static int somarDoisValores(int primeiroValor, int segundoValor)
        {
            return primeiroValor + segundoValor;
        }

        int primeiroValor = int.Parse(Console.ReadLine());
        int segundoValor = int.Parse(Console.ReadLine());

        Console.WriteLine($"X = {somarDoisValores(primeiroValor, segundoValor)}");
        */

        static double calcularArea(double raio)
        {
            return Math.PI * (Math.Pow(raio, 2));
        }

        double area = double.Parse(Console.ReadLine());

        Console.WriteLine($"A={calcularArea(area)}");
    }

}