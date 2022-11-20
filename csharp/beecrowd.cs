internal class Program
{


    private static void Main(string[] args)
    {   
        
        /**
        1017 - Gasto de Combustível
        https://www.beecrowd.com.br/judge/pt/problems/view/1017

        double tempoViagem = double.Parse(Console.ReadLine());
        double velocidadeMedia = double.Parse(Console.ReadLine());

        double combustivelGasto = tempoViagem*velocidadeMedia/12;

        Console.WriteLine($"{combustivelGasto:F3}");
        */


        /**
        1016 - Distância
        https://www.beecrowd.com.br/judge/pt/problems/view/1016

        int resposta = int.Parse(Console.ReadLine())*2;
        Console.WriteLine($"{resposta} minutos");
        */


        /**
        1015 - Distância Entre Dois Pontos
        https://www.beecrowd.com.br/judge/pt/problems/view/1015

        string[] primeiroArray = Console.ReadLine().Split();
        string[] segundoArray = Console.ReadLine().Split();

        double x1 = double.Parse(primeiroArray[0]);
        double y1 = double.Parse(primeiroArray[1]);

        double x2 = double.Parse(segundoArray[0]);
        double y2 = double.Parse(segundoArray[1]);

        double resultadoDistancia = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));

        Console.WriteLine($"{resultadoDistancia:F4}");
        */


        /**
        1014 - Consumo
        https://www.beecrowd.com.br/judge/pt/problems/view/1014

        double kmTotal = double.Parse(Console.ReadLine());
        double combustivelGasto = double.Parse(Console.ReadLine());

        double consumoCarro = kmTotal/combustivelGasto;

        Console.WriteLine($"{consumoCarro:F3} km/l");
        */


        /**
        1013 - O Maior
        https://www.beecrowd.com.br/judge/pt/problems/view/1013

        String[] arrayA = Console.ReadLine().Split(' ');

        int valorA = int.Parse(arrayA[0]);
        int valorB = int.Parse(arrayA[1]);
        int valorC = int.Parse(arrayA[2]);

        double maiorValor = (valorA + valorB + Math.Abs(valorA-valorB))/2;

        maiorValor = (maiorValor + valorC + Math.Abs(maiorValor-valorC))/2;

        Console.WriteLine($"{maiorValor} eh o maior");
        */


        /**
        1012 - Área
        https://www.beecrowd.com.br/judge/pt/runs/code/30858287

        String[] valores = Console.ReadLine().Split(' ');
        
        double areaTriangulo = (double.Parse(valores[0])*double.Parse(valores[2]))/2;
        double areaCirculo = 3.14159 * (Math.Pow(double.Parse(valores[2]), 2));
        double areaTrapesio = ((double.Parse(valores[0])+double.Parse(valores[1]))*double.Parse(valores[2]))/2;

        Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3")}");
        Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3")}");
        Console.WriteLine($"TRAPEZIO: {areaTrapesio.ToString("F3")}");
        Console.WriteLine($"QUADRADO: {Math.Pow(double.Parse(valores[1]),2).ToString("F3")}");
        Console.WriteLine($"RETANGULO: {(double.Parse(valores[0])*double.Parse(valores[1])).ToString("F3")}");
        */


        /**
        1011 - Esfera
        https://www.beecrowd.com.br/judge/pt/problems/view/1011

        double volume = (4.0 / 3) * 3.14159 * (Math.Pow(double.Parse(Console.ReadLine()), 3));
        Console.WriteLine($"VOLUME = {volume.ToString("F3")}");
        */


        /**
        1010 - Cálculo Simples
        https://www.beecrowd.com.br/judge/pt/problems/view/1010

        String[] arrayPrimaria = Console.ReadLine().Split(' ');
        String[] arraySecundaria = Console.ReadLine().Split(' ');

        double totalPecaA = int.Parse(arrayPrimaria[1]) * double.Parse(arrayPrimaria[2]);
        double totalPecaB = int.Parse(arraySecundaria[1]) * double.Parse(arraySecundaria[2]);
            
        System.Console.WriteLine($"VALOR A PAGAR: R$ {(totalPecaA + totalPecaB).ToString("F2")}");
        */


        /**
        1009 - Salário com Bônus
        https://www.beecrowd.com.br/judge/pt/problems/view/1009

        Console.ReadLine();
        double salarioVendedor = double.Parse(Console.ReadLine());
        double totalVendas = double.Parse(Console.ReadLine());

        Console.WriteLine($"TOTAL = R$ {(salarioVendedor + (totalVendas * 0.15)).ToString("F2")}");
        */

        /**
        1008 - Salário
        https://www.beecrowd.com.br/judge/pt/problems/view/1008

        int numeroFuncionario = int.Parse(Console.ReadLine());
        int horasTrabalhadas = int.Parse(Console.ReadLine());
        double salarioFuncionario = double.Parse(Console.ReadLine());

        Console.WriteLine($"NUMBER = {numeroFuncionario}");
        Console.WriteLine($"SALARY = U$ {(salarioFuncionario*horasTrabalhadas).ToString("F2")}");
        */


        /**
        1007 - Diferença
        https://www.beecrowd.com.br/judge/pt/problems/view/1007

        int primeiroValor = int.Parse(Console.ReadLine());
        int segundoValor = int.Parse(Console.ReadLine());
        int terceiroValor = int.Parse(Console.ReadLine());
        int quartoValor = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"DIFERENCA = {primeiroValor*segundoValor-terceiroValor*quartoValor}");
        */


        /**
        1006 - Média 2
        https://www.beecrowd.com.br/judge/pt/problems/view/1006

        double primeiroValor = double.Parse(Console.ReadLine()) * 2;
        double segundoValor = double.Parse(Console.ReadLine()) * 3;
        double terceiroValor = double.Parse(Console.ReadLine()) * 5;

        Console.WriteLine($"MEDIA = {((primeiroValor + segundoValor + terceiroValor) / (2 + 3 + 5)).ToString("F1")}");
        */


        /**
        1005 - Média 1
        https://www.beecrowd.com.br/judge/pt/problems/view/1005

        double primeiroValor = double.Parse(Console.ReadLine()) * 3.5;
        double segundoValor = double.Parse(Console.ReadLine()) * 7.5;
    
        Console.WriteLine($"MEDIA = {((primeiroValor + segundoValor) / (3.5 + 7.5)).ToString("F5")}");
        */


        /**
        1004 - Produto Simples
        https://www.beecrowd.com.br/judge/pt/problems/view/1004

        int primeiroValor = int.Parse(Console.ReadLine());
        int segundoValor = int.Parse(Console.ReadLine());

        Console.WriteLine($"PROD = {primeiroValor*segundoValor}");
        */


        /**
        1003 - Soma Simples
        https://www.beecrowd.com.br/judge/pt/problems/view/1003

        int primeiroValor = int.Parse(Console.ReadLine());
        int segundoValor = int.Parse(Console.ReadLine());

        Console.WriteLine($"SOMA = {(primeiroValor + segundoValor)}");
        */


        /** 
        1002 - Área do Círculo
        https://www.beecrowd.com.br/judge/pt/problems/view/1002

        const double valorPI = 3.14159;
        double raio = double.Parse(Console.ReadLine());
        double resultado = valorPI * (Math.Pow(raio, 2));
        
        Console.WriteLine($"A={resultado.ToString("f4")}");
        */


        /**
        1001 - Extremamente Básico
        https://www.beecrowd.com.br/judge/pt/problems/view/1001

        static int somarDoisValores(int primeiroValor, int segundoValor)
        {
            return primeiroValor + segundoValor;
        }

        int primeiroValor = int.Parse(Console.ReadLine());
        int segundoValor = int.Parse(Console.ReadLine());

        Console.WriteLine($"X = {somarDoisValores(primeiroValor, segundoValor)}");
        */


        /**
        1000 - Hello World!
        https://www.beecrowd.com.br/judge/pt/problems/view/1000

        static void helloWorld()
        {
        Console.WriteLine("Hello World!");
        }
    
        static void Main(string[] args)
        { 
        helloWorld();
        }
        */



    }

}