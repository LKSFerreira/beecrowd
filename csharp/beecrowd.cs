internal class Program
{
    private static void Main(string[] args)
    {
        double nota1, nota2, nota3, nota4;
        int[] pesos = { 2, 3, 4, 1 };
        string[] valorInserido = Console.ReadLine().Split();

        nota1 = double.Parse(valorInserido[0]);
        nota2 = double.Parse(valorInserido[1]);
        nota3 = double.Parse(valorInserido[2]);
        nota4 = double.Parse(valorInserido[3]);

        double media = (nota1 * pesos[0]) + (nota2 * pesos[1]) + (nota3 * pesos[2]) + (nota4 * pesos[3]);

        media = media / 10;

        System.Console.WriteLine($"Media: {media:F1}");

        if (media >= 5 && media <= 6.9)
        {

            {
                double notaExame = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Aluno em exame.");
                System.Console.WriteLine($"Nota do exame: {notaExame:F1}");
                media = (media + notaExame) / 2;
                if (media >= 5)
                {
                    System.Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    System.Console.WriteLine("Aluno reprovado.");
                }
                System.Console.WriteLine($"Media final: {media:F1}");
            }

        }
        else if (media < 5)
        {
            System.Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            System.Console.WriteLine("Aluno aprovado.");
        }

        /**
        1038 - Lanche
        https://www.beecrowd.com.br/judge/pt/problems/view/1038

        //string[] valores = "2 3".Split();
        string[] valores = Console.ReadLine().Split();
        double[] lanches = new double[] {4, 4.50, 5, 2, 1.5};

        int codigoLanche = int.Parse(valores[0]);
        int quantidade = int.Parse(valores[1]);
        double totalPagar;

        switch (codigoLanche)
        {
            case 1:
                totalPagar = quantidade * lanches[0];
                System.Console.WriteLine($"Total: R$ {totalPagar:F2}");
                break;
            case 2:
                totalPagar = quantidade * lanches[1];
                System.Console.WriteLine($"Total: R$ {totalPagar:F2}");
                break;
            case 3:
                totalPagar = quantidade * lanches[2];
                System.Console.WriteLine($"Total: R$ {totalPagar:F2}");
                break;
            case 4:
                totalPagar = quantidade * lanches[3];
                System.Console.WriteLine($"Total: R$ {totalPagar:F2}");
                break;
            case 5:
                totalPagar = quantidade * lanches[4];
                System.Console.WriteLine($"Total: R$ {totalPagar:F2}");
                break;
        }
        */


        /**
        1037 - Intervalo
        https://www.beecrowd.com.br/judge/pt/problems/view/1037

        //float valorInserido = 25.01f;
        float valorInserido = float.Parse(Console.ReadLine());

        if (valorInserido >= 0 && valorInserido <= 25)
        {
            System.Console.WriteLine("Intervalo [0,25]");
        }
        else if (valorInserido > 25 && valorInserido <= 50)
        {
            System.Console.WriteLine("Intervalo (25,50]");
        }
        else if (valorInserido > 50 && valorInserido <= 75)
        {
            System.Console.WriteLine("Intervalo (50, 75]");
        }
        else if (valorInserido > 75 && valorInserido <= 100)
        {
            System.Console.WriteLine("Intervalo (75,100]");
        } else {
            System.Console.WriteLine("Fora de intervalo");
        }
        */


        /**
        1036 - Fórmula de Bhaskara
        https://www.beecrowd.com.br/judge/pt/problems/view/1036

        //string[] valores = "10,0 3,0 5,00".Split();
        string[] valores = Console.ReadLine().Split();

        double valorA = double.Parse(valores[0]);
        double valorB = double.Parse(valores[1]);
        double valorC = double.Parse(valores[2]);

        double valorDelta = (valorB * valorB) - (4 * valorA * valorC);
        
        double formulaBhaskaraPositivo, formulaBhaskaraNegativo;

        formulaBhaskaraPositivo = ((-valorB) + (Math.Sqrt(valorDelta))) / (2 * valorA);
        formulaBhaskaraNegativo = ((-valorB) - (Math.Sqrt(valorDelta))) / (2 * valorA);

        if (valorDelta <= 0)
        {
            System.Console.WriteLine("Impossivel calcular");
        }
        else if (formulaBhaskaraPositivo.ToString() == "NaN" || formulaBhaskaraNegativo.ToString() == "NaN")
        {
            System.Console.WriteLine("Impossivel calcular");
        }
        else
        {
            System.Console.WriteLine($"R1 = {formulaBhaskaraPositivo:F5}");
            System.Console.WriteLine($"R2 = {formulaBhaskaraNegativo:F5}");
        }
        */


        /**
         1035 - Teste de Seleção 1
        https://www.beecrowd.com.br/judge/pt/problems/view/1035
    
        string[] arrayValores = Console.ReadLine().Split();

        int valorA = int.Parse(arrayValores[0]);
        int valorB = int.Parse(arrayValores[1]);
        int valorC = int.Parse(arrayValores[2]);
        int valorD = int.Parse(arrayValores[3]);

        if ((valorB > valorC) && (valorD > valorA) && ((valorC + valorD) > (valorA + valorB)) && (valorC > 0) && (valorD > 0) && (valorA % 2 == 0))
        {
            System.Console.WriteLine("Valores aceitos");
        } else
        {
            System.Console.WriteLine("Valores nao aceitos");
        }
        */


        /**
        1021 - Notas e Moedas
        https://www.beecrowd.com.br/judge/pt/problems/view/1021
        

        // Recebe um valor double do usuário e guarda esse valor na variável valorInserido.
        double valorInserido = double.Parse(Console.ReadLine());

        // Guarda apenas a parte inteiro do valor double na variável valorNotas.
        int valorNotas = (int)(valorInserido);

        // Para tabalhar com as moedas iremos subtrair o inserido do valor inteiro e multiplicar por 100 para manipula-lo com inteiro.
        // Exemplo: R$250,57 - 250 = 0,57 // 0,57 * 100 // 57 -> Agora manipularemos a parte decimal como um inteiro.

        // Lógica por tras da moeda

        // Ao multiplicar o um decimal por 100 podemos tratar o valor como inteiro.
        // Pense assim: Ao invez de ler uma como como 0,50 de Real, iremos ler ela como 50 centavos.
        double moedasConvertidas = Math.Floor((valorInserido - valorNotas)*100);

        //Remove todas as possíveis casa do número infinitéssimo gerado na manipulação dos números.
        int valorMoedas = (int)moedasConvertidas;
        
        //Agora replicamos a lógica de cima em pequenos blocos dos valores que queremos obter.

        //Obtem as notas de 100
        int notas100 = valorNotas/100;
        valorNotas -= notas100*100;
        
        //Obtem as notas de 50
        int notas50 = valorNotas/50;
        valorNotas -= notas50*50;

        //Obtem as notas de 20
        int notas20 = valorNotas/20;
        valorNotas -= notas20*20;

        //Obtem as notas de 10
        int notas10 = valorNotas/10;
        valorNotas -= notas10*10;

        //Obtem as notas de 5
        int notas5= valorNotas/5;
        valorNotas -= notas5*5;

        //Obtem as notas de 2
        int notas2 = valorNotas/2;
        valorNotas -= notas2*2;

        //Obtem as notas de 1
        int moeda1 = valorNotas/1;
        valorNotas -= moeda1*1;

        //Obtem as moedas de 50
        int moeda50 = valorMoedas/50;
        valorMoedas -= (moeda50*50);

        //Obtem as moedas de 25
        int moeda25 = valorMoedas/25;
        valorMoedas -= moeda25*25;

        //Obtem as moedas de 10
        int moeda10 = valorMoedas/10;
        valorMoedas -= moeda10*10;

        //Obtem as moedas de 05
        int moeda05 = valorMoedas/05;
        valorMoedas -= (moeda05*05);

        //Obtem as moedas de 1
        int moeda01 = valorMoedas/1;
        valorMoedas -= moeda01*1;

        Console.WriteLine("NOTAS:");
        Console.WriteLine($"{notas100} nota(s) de R$ 100.00");
        Console.WriteLine($"{notas50} nota(s) de R$ 50.00");
        Console.WriteLine($"{notas20} nota(s) de R$ 20.00");
        Console.WriteLine($"{notas10} nota(s) de R$ 10.00");
        Console.WriteLine($"{notas5} nota(s) de R$ 5.00");
        Console.WriteLine($"{notas2} nota(s) de R$ 2.00");
        Console.WriteLine("MOEDAS:");
        Console.WriteLine($"{moeda1} moeda(s) de R$ 1.00");
        Console.WriteLine($"{moeda50} moeda(s) de R$ 0.50");
        Console.WriteLine($"{moeda25} moeda(s) de R$ 0.25");
        Console.WriteLine($"{moeda10} moeda(s) de R$ 0.10");
        Console.WriteLine($"{moeda05} moeda(s) de R$ 0.05");
        Console.WriteLine($"{moeda01} moeda(s) de R$ 0.01");
        */


        /**
        1020 - Idade em Dias
        https://www.beecrowd.com.br/judge/pt/problems/view/1020

        int tempoEmDias = int.Parse(Console.ReadLine());
        int tempo = tempoEmDias;

        int anos = tempo/365;
        tempo -= anos*365;

        int meses = tempo/30;
        tempo -= meses*30;

        int dias = tempo/1;
        tempo -= dias*1;
        
        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");
        */


        /**
        1019 - Conversão de Tempo
        https://www.beecrowd.com.br/judge/pt/problems/view/1019

        int tempoEmSegundos = int.Parse(Console.ReadLine());
        int tempo = tempoEmSegundos;

        int horas = tempo/3600;
        tempo -= horas*3600;

        int minutos = tempo/60;
        tempo -= minutos*60;

        int segundos = tempo/1;
        tempo -= segundos*1;
        
        Console.WriteLine($"{horas}:{minutos}:{segundos}");
        */


        /**
        1018 - Cédulas
        https://www.beecrowd.com.br/judge/pt/problems/view/1018

        int notasInseridas = int.Parse(Console.ReadLine());
        int atual = notasInseridas;
        
        int notas100 = atual/100;
        atual -= notas100*100;

        int notas50 = atual/50;
        atual -= notas50*50;

        int notas20 = atual/20;
        atual -= notas20*20;

        int notas10 = atual/10;
        atual -= notas10*10;

        int notas5= atual/5;
        atual -= notas5*5;

        int notas2 = atual/2;
        atual -= notas2*2;

        int notas1 = atual/1;
        atual -= notas1*1;

        Console.WriteLine(notasInseridas);
        Console.WriteLine($"{notas100} nota(s) de R$ 100,00");
        Console.WriteLine($"{notas50} nota(s) de R$ 50,00");
        Console.WriteLine($"{notas20} nota(s) de R$ 20,00");
        Console.WriteLine($"{notas10} nota(s) de R$ 10,00");
        Console.WriteLine($"{notas5} nota(s) de R$ 5,00");
        Console.WriteLine($"{notas2} nota(s) de R$ 2,00");
        Console.WriteLine($"{notas1} nota(s) de R$ 1,00");
        */


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