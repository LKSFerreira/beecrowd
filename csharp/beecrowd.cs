
internal class Program
{
    static string[] valoresTesters = {
                                   "Dia 5-08 : 12 : 23-Dia 9-06 : 13 : 23",
                                   "Dia 5-08 : 12 : 23-Dia 5-09 : 13 : 25",
                                   "Dia 5-08 : 12 : 23-Dia 5-09 : 12 : 24",
                                   "Dia 5-08 : 12 : 23-Dia 6-09 : 12 : 26",
                                   "Dia 5-08 : 12 : 23-Dia 5-09 : 12 : 22",
                                   "Dia 5-08 : 12 : 23-Dia 6-09 : 12 : 22",
                                   "Dia 5-08 : 12 : 23-Dia 6-09 : 11 : 24",
                                   "Dia 5-08 : 12 : 23-Dia 5-09 : 11 : 27",
                                   "Dia 5-08 : 12 : 23-Dia 6-08 : 12 : 25",
                                   "Dia 5-08 : 12 : 43-Dia 6-08 : 11 : 39",
                                   "Dia 5-08 : 52 : 37-Dia 6-07 : 59 : 36",
                                   "Dia 5-08 : 52 : 37-Dia 6-07 : 59 : 37",
                                   "Dia 5-08 : 52 : 37-Dia 6-07 : 53 : 38",
                                   "Dia 5-08 : 50 : 37-Dia 6-07 : 49 : 38",
                                   "Dia 5-08 : 12 : 23-Dia 6-09 : 11 : 20",
                                   "Dia 5-08 : 12 : 23-Dia 5-09 : 10 : 20",
                                   "Dia 5-08 : 12 : 43-Dia 6-08 : 52 : 42",
                                   "Dia 5-08 : 50 : 38-Dia 6-07 : 05 : 37",
                                   "Dia 5-08 : 50 : 38-Dia 6-07 : 05 : 38",
                                   "Dia 11-07 : 57 : 09-Dia 15-19 : 00 : 00",
                                   "Dia 5-08 : 12 : 43-Dia 6-08 : 11 : 48",
                                   "Dia 1-01 : 12 : 23-Dia 2-01 : 12 : 23",
                                   "Dia 1-01 : 12 : 23-Dia 2-01 : 12 : 24",
                                   "Dia 1-01 : 12 : 23-Dia 2-01 : 12 : 22"};

    static string[] valoresEsperado = {
                                    "3 dia(s)-22 hora(s)-1 minuto(s)-0 segundo(s)",
                                    "0 dia(s)-1 hora(s)-1 minuto(s)-2 segundo(s)",
                                    "0 dia(s)-1 hora(s)-0 minuto(s)-1 segundo(s)",
                                    "1 dia(s)-1 hora(s)-0 minuto(s)-3 segundo(s)",
                                    "0 dia(s)-0 hora(s)-59 minuto(s)-59 segundo(s)",
                                    "1 dia(s)-0 hora(s)-59 minuto(s)-59 segundo(s)",
                                    "1 dia(s)-0 hora(s)-59 minuto(s)-1 segundo(s)",
                                    "0 dia(s)-0 hora(s)-59 minuto(s)-4 segundo(s)",
                                    "1 dia(s)-0 hora(s)-0 minuto(s)-2 segundo(s)",
                                    "0 dia(s)-23 hora(s)-58 minuto(s)-56 segundo(s)",
                                    "0 dia(s)-23 hora(s)-6 minuto(s)-59 segundo(s)",
                                    "0 dia(s)-23 hora(s)-7 minuto(s)-0 segundo(s)",
                                    "0 dia(s)-23 hora(s)-1 minuto(s)-1 segundo(s)",
                                    "0 dia(s)-22 hora(s)-59 minuto(s)-1 segundo(s)",
                                    "1 dia(s)-0 hora(s)-58 minuto(s)-57 segundo(s)",
                                    "0 dia(s)-0 hora(s)-57 minuto(s)-57 segundo(s)",
                                    "1 dia(s)-0 hora(s)-39 minuto(s)-59 segundo(s)",
                                    "0 dia(s)-22 hora(s)-14 minuto(s)-59 segundo(s)",
                                    "0 dia(s)-22 hora(s)-15 minuto(s)-0 segundo(s)",
                                    "4 dia(s)-11 hora(s)-2 minuto(s)-51 segundo(s)",
                                    "0 dia(s)-23 hora(s)-59 minuto(s)-5 segundo(s)",
                                    "1 dia(s)-0 hora(s)-0 minuto(s)-0 segundo(s)",
                                    "1 dia(s)-0 hora(s)-0 minuto(s)-1 segundo(s)",
                                    "0 dia(s)-23 hora(s)-59 minuto(s)-59 segundo(s)"};
    static void mostrarResultadoEsperado(string dia, string hora, string minuto, string segundo)
    {
        System.Console.WriteLine(dia);
        System.Console.WriteLine(hora);
        System.Console.WriteLine(minuto);
        System.Console.WriteLine(segundo);
    }

    static int[] calcularTempoEvento(int diaInicial, int diaFinal,
                                     int horaInicial, int horaFinal,
                                        int minutoInicial, int minutoFinal,
                                            int segundoInicial, int segundoFinal)
    {
        int segundos = calcularSegundos(segundoInicial, segundoFinal);
        if (segundoFinal > segundoInicial)
        {
            minutoFinal++;
        }

        int minutos = calcularMinutos(minutoInicial, minutoFinal);
        if (minutoFinal > minutoInicial)
        {
            horaFinal++;
        }

        int horas = calcularHoras(horaInicial, horaFinal);

        if (horaFinal > horaInicial)
        {
            diaFinal++;
        }

        int dias = Math.Abs(calcularDias(diaInicial, diaFinal));

        int[] arrayEventos = { dias, horas, minutos, segundos };

        return arrayEventos;
    }

    static int calcularDias(int diaInicial, int diaFinal)
    {
        /**
        Quando essa função for chamada, aplicar o módulo ao final do precesso
        */
        return diaInicial - diaFinal;
    }
    static int calcularHoras(int horaInicial, int horaFinal)
    {
        if (horaFinal >= horaInicial)
        {
            return horaFinal - horaInicial;
        }

        return (24 - horaInicial) + horaFinal;
    }

    static int calcularMinutos(int minutoInicial, int minutoFinal)
    {
        if (minutoFinal >= minutoInicial)
        {
            return minutoFinal - minutoInicial;
        }
        return (60 - minutoInicial) + minutoFinal;
    }

    static int calcularSegundos(int segundoInicial, int segundoFinal)
    {
        if (segundoFinal >= segundoInicial)
        {
            return segundoFinal - segundoInicial;
        }
        return (60 - segundoInicial) + 22;
    }



    static void mostrarResultado(int dia, int hora, int minuto, int segundo)
    {
        System.Console.WriteLine($"{dia} dia(s)");
        System.Console.WriteLine($"{hora} hora(s)");
        System.Console.WriteLine($"{minuto} minuto(s)");
        System.Console.WriteLine($"{segundo} segundo(s)");
    }


    private static void Main(string[] args)
    {

        for (int i = 0; i < valoresTesters.Length; i++)
        {
            string[] testeUnitario = valoresTesters[i].Split('-');
            string[] valorEsperadoUnitario = valoresEsperado[i].Split('-');

            string diaInicialString = testeUnitario[0];
            string[] horarioInicio = testeUnitario[1].Replace(" ", "").Replace(":", " ").Split();
            string diaFinalString = testeUnitario[2];
            string[] horarioFinal = testeUnitario[3].Replace(" ", "").Replace(":", " ").Split();

            // string diaInicialString = Console.ReadLine();
            // string[] horarioInicio = Console.ReadLine().Replace(" ", "").Replace(":", " ").Split();
            // string diaFinalString = Console.ReadLine();
            // string[] horarioFinal = Console.ReadLine().Replace(" ", "").Replace(":", " ").Split();

            int diaInicial = int.Parse(diaInicialString.Last().ToString());
            int diaFinal = int.Parse(diaFinalString.Last().ToString());

            int horaInicial = int.Parse(horarioInicio[0]);
            int minutoInicial = int.Parse(horarioInicio[1]);
            int segundoInicial = int.Parse(horarioInicio[2]);

            int horaFinal = int.Parse(horarioFinal[0]);
            int minutoFinal = int.Parse(horarioFinal[1]);
            int segundoFinal = int.Parse(horarioFinal[2]);

            int duracaoJogoHoras = 0, duracaoJogoMinutos = 0, duracaoJogoSegundos = 0, duracaoJogoDias = 0;

            duracaoJogoDias = calcularDias(diaInicial, diaFinal);
            duracaoJogoHoras = calcularHoras(horaInicial, horaFinal);
            duracaoJogoMinutos = calcularMinutos(minutoInicial, minutoFinal);
            duracaoJogoSegundos = calcularSegundos(segundoInicial, segundoFinal);




            System.Console.WriteLine("Teste número: " + i);
            System.Console.WriteLine("-------");
            mostrarResultado(duracaoJogoDias, duracaoJogoHoras, duracaoJogoMinutos, duracaoJogoSegundos);
            System.Console.WriteLine("-------");

            System.Console.WriteLine(valorEsperadoUnitario[0].Equals($"{duracaoJogoDias} dia(s)"));
            System.Console.WriteLine(valorEsperadoUnitario[1].Equals($"{duracaoJogoHoras} hora(s)"));
            System.Console.WriteLine(valorEsperadoUnitario[2].Equals($"{duracaoJogoMinutos} minuto(s)"));
            System.Console.WriteLine(valorEsperadoUnitario[3].Equals($"{duracaoJogoSegundos} segundo(s)"));
            System.Console.WriteLine("------");

        }
        //string diaInicialString = Console.ReadLine();
        //string[] horarioInicio = Console.ReadLine().Replace(" ", "").Replace(":", " ").Split();
        //string diaFinalString = Console.ReadLine();
        //string[] horarioFinal = Console.ReadLine().Replace(" ", "").Replace(":", " ").Split();

        /*
            CODIGO DO BEECROWD
        */




        /*
        1060 - Números Positivos
        https://www.beecrowd.com.br/judge/pt/problems/view/1060

        int valoresPositivos = 0;

        for (int i = 0; i < 6; i++)
        {
            double valoresEntrada = double.Parse(Console.ReadLine());
            if (valoresEntrada > 0)     {
                valoresPositivos++;
            }
        }

        System.Console.WriteLine($"{valoresPositivos} valores positivos");
        */

        /*
        1059 - Números Pares
        https://www.beecrowd.com.br/judge/pt/problems/view/1059
        for (int i = 2; i <= 100; i += 2)
        {
            System.Console.WriteLine(i);
        }
        */


        /*
        1052 - Mês
        https://www.beecrowd.com.br/judge/pt/problems/view/1052

        static void buscarMes (int numeroDoMes){
            switch (numeroDoMes)
            {
                case 1:
                System.Console.WriteLine("January");
                break;

                case 2:
                System.Console.WriteLine("February");
                break;

                case 3:
                System.Console.WriteLine("March");
                break;

                case 4:
                System.Console.WriteLine("April");
                break;

                case 5:
                System.Console.WriteLine("May");
                break;

                case 6:
                System.Console.WriteLine("June");
                break;

                case 7:
                System.Console.WriteLine("July");
                break;

                case 8:
                System.Console.WriteLine("August");
                break;

                case 9:
                System.Console.WriteLine("September");
                break;

                case 10:
                System.Console.WriteLine("October");
                break;

                case 11:
                System.Console.WriteLine("November");
                break;

                case 12:
                System.Console.WriteLine("December");
                break;

            }
        }
        private static void Main(string[] args)
        {   
            int numeroDoMes = int.Parse(Console.ReadLine());

            buscarMes(numeroDoMes);

            */

        /*
        1051 - Imposto de Renda
        https://www.beecrowd.com.br/judge/pt/problems/view/1051

        static void calcularImpostoDeRenda(double salario)
        {
            double faixaIsenta = 2000, faixa8Porcento = 3000, faixa18Porcento = 4500;

            if (salario <= 2000)
            {
                System.Console.WriteLine("Isento");
            }
            else if (salario > 2000 && salario <= 3000)
            {
                double valorImposto = imposto8Porcento(salario - faixaIsenta);

                System.Console.WriteLine($"R$ {valorImposto:F2}");
            }
            else if (salario > 3000 && salario <= 4500)
            {
                double valorImposto = 0;
                valorImposto = imposto8Porcento(faixa8Porcento - faixaIsenta);
                valorImposto += imposto18Porcento(salario - faixa8Porcento);

                System.Console.WriteLine($"R$ {valorImposto:F2}");
            }
            else
            {
                double valorImposto = 0;
                valorImposto = imposto8Porcento(faixa8Porcento - faixaIsenta);
                valorImposto += imposto18Porcento(faixa18Porcento - faixa8Porcento);
                valorImposto += imposto28Porcento(salario - faixa18Porcento);

                System.Console.WriteLine($"R$ {valorImposto:F2}");
            }
        }

        static double imposto8Porcento(double salario)
        {
            return salario * 0.08;
        }

        static double imposto18Porcento(double salario)
        {
            return salario * 0.18;
        }

        static double imposto28Porcento(double salario)
        {
            return salario * 0.28;
        }

        private static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine());
            calcularImpostoDeRenda(salario);
            */




        /*
        1050 - DDD
        https://www.beecrowd.com.br/judge/pt/problems/view/1050

        private static void buscarCidadePeloDDD(int ddd){
            switch (ddd)
            {
                case 61:
                System.Console.WriteLine("Brasilia");
                break;

                case 71:
                System.Console.WriteLine("Salvador");
                break;

                case 11:
                System.Console.WriteLine("Sao Paulo");
                break;

                case 21:
                System.Console.WriteLine("Rio de Janeiro");
                break;

                case 32:
                System.Console.WriteLine("Juiz de Fora");
                break;

                case 19:
                System.Console.WriteLine("Campinas");
                break;

                case 27:
                System.Console.WriteLine("Vitoria");
                break;

                case 31:
                System.Console.WriteLine("Belo Horizonte");
                break;

                default:
                System.Console.WriteLine("DDD nao cadastrado");
                break;
            }
        }

        private static void Main(string[] args)
        {   
            int ddd = int.Parse(Console.ReadLine());

            buscarCidadePeloDDD(ddd);
        */


        /*
        1049 - Animal
        https://www.beecrowd.com.br/judge/pt/problems/view/1049

        public static void classificar(string filo, string classe, string genero)
        {
            switch (filo)
            {
                case "vertebrado":
                    buscarClasseVertebrado(classe, genero);
                    break;

                case "invertebrado":
                    buscarClasseInvertebrado(classe, genero);
                    break;
            }
        }

        public static void buscarClasseVertebrado(string classe, string genero)
        {
            switch (classe)
            {
                case "ave":
                    buscarGeneroAve(genero);
                    break;

                case "mamifero":
                    buscarGeneroMamifero(genero);
                    break;
            }
        }

        public static void buscarClasseInvertebrado(string classe, string genero)
        {
            switch (classe)
            {
                case "inseto":
                    buscarGeneroInseto(genero);
                    break;

                case "anelideo":
                    buscarGeneroAnelideo(genero);
                    break;
            }
        }

        public static void buscarGeneroAve(string genero)
        {
            switch (genero)
            {
                case "carnivoro":
                    aguia();
                    break;

                case "onivoro":
                    pomba();
                    break;
            }
        }

        public static void buscarGeneroMamifero(string genero)
        {
            switch (genero)
            {
                case "onivoro":
                    homem();
                    break;

                case "herbivoro":
                    vaca();
                    break;
            }
        }

        public static void buscarGeneroInseto(string genero)
        {
            switch (genero)
            {
                case "hematofago":
                    pulga();
                    break;

                case "herbivoro":
                    lagarta();
                    break;
            }
        }

        public static void buscarGeneroAnelideo(string genero)
        {
            switch (genero)
            {
                case "hematofago":
                    sanguessuga();
                    break;

                case "onivoro":
                    minhoca();
                    break;
            }
        }

        public static void aguia() { System.Console.WriteLine("aguia"); }
        public static void pomba() { System.Console.WriteLine("pomba"); }
        public static void homem() { System.Console.WriteLine("homem"); }
        public static void vaca() { System.Console.WriteLine("vaca"); }
        public static void pulga() { System.Console.WriteLine("pulga"); }
        public static void lagarta() { System.Console.WriteLine("lagarta"); }
        public static void sanguessuga() { System.Console.WriteLine("sanguessuga"); }
        public static void minhoca() { System.Console.WriteLine("minhoca"); }

        private static void Main(string[] args)
        {   

            string filo = Console.ReadLine();
            string classe = Console.ReadLine();
            string genero = Console.ReadLine();

            classificar(filo, classe, genero);
        */





        /*
        1048 - Aumento de Salário
        https://www.beecrowd.com.br/judge/pt/problems/view/1048

        public static void reajustarSalario(double salario, double percentualReajuste)
        {
            percentualReajuste = percentualReajuste / 100;
            double reajuste = salario * percentualReajuste;
            salario += reajuste;

            System.Console.WriteLine($"Novo salario: {salario:F2}");
            System.Console.WriteLine($"Reajuste ganho: {reajuste:F2}");

            percentualReajuste = percentualReajuste * 100;
            System.Console.WriteLine($"Em percentual: {(int)percentualReajuste} %");
        }
        private static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine());
            double percentualReajuste = 0;

            if (salario <= 400)
            {
                percentualReajuste = 15;
                reajustarSalario(salario, percentualReajuste);
            }
            else if (salario > 400 && salario <= 800)
            {
                percentualReajuste = 12;
                reajustarSalario(salario, percentualReajuste);
            }
            else if (salario > 800 && salario <= 1200)
            {
                percentualReajuste = 10;
                reajustarSalario(salario, percentualReajuste);
            }
            else if (salario > 1200 && salario <= 2000)
            {
                percentualReajuste = 7;
                reajustarSalario(salario, percentualReajuste);
            }
            else
            {
                percentualReajuste = 4;
                reajustarSalario(salario, percentualReajuste);
            }
            */


        /*
        1047 - Tempo de Jogo com Minutos
        https://www.beecrowd.com.br/judge/pt/problems/view/1047

        public static int calcularMinutos(int minutoInicial, int minutoFinal)
        {
            if (minutoInicial > minutoFinal)
            {
                return (60 - minutoInicial) + minutoFinal;
            }
            else
            {
                return minutoFinal - minutoInicial;
            }
        }

        private static void Main(string[] args)
        {
            string[] valoresTesters = {
                "7 8 9 10",
                "7 7 7 7",
                "7 10 8 9",
                "10 12 10 11",
                "1 1 1 1",
                "1 1 1 0",
                "1 1 1 2",
                "10 12 12 12",
                "1 59 2 59",
                "11 23 10 22",
                "11 39 19 15"};

            string[] valoresEsperados = {
                "O JOGO DUROU 2 HORA(S) E 2 MINUTO(S)",
                "O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)",
                "O JOGO DUROU 0 HORA(S) E 59 MINUTO(S)",
                "O JOGO DUROU 23 HORA(S) E 59 MINUTO(S)",
                "O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)",
                "O JOGO DUROU 23 HORA(S) E 59 MINUTO(S)",
                "O JOGO DUROU 0 HORA(S) E 1 MINUTO(S)",
                "O JOGO DUROU 2 HORA(S) E 0 MINUTO(S)",
                "O JOGO DUROU 1 HORA(S) E 0 MINUTO(S)",
                "O JOGO DUROU 22 HORA(S) E 59 MINUTO(S)",
                "O JOGO DUROU 7 HORA(S) E 36 MINUTO(S)"};

            for (int i = 0; i < valoresTesters.Length; i++)
            {
                string[] valoresInseridos = valoresTesters[i].Split();
                //string[] valoresInseridos = Console.ReadLine().Split();

                int horaInicial = int.Parse(valoresInseridos[0]);
                int minutoInicial = int.Parse(valoresInseridos[1]);
                int horaFinal = int.Parse(valoresInseridos[2]);
                int minutoFinal = int.Parse(valoresInseridos[3]);
                int duracaoJogoHoras = 0, duracaoJogosMinutos = 0;

                duracaoJogosMinutos = calcularMinutos(minutoInicial, minutoFinal);

                if (horaInicial > horaFinal)
                {
                    duracaoJogoHoras = (24 - horaInicial) + horaFinal;
                    if (minutoInicial > minutoFinal)
                    {
                        duracaoJogoHoras--;
                    }
                    System.Console.WriteLine($"O JOGO DUROU {duracaoJogoHoras} HORA(S) E {duracaoJogosMinutos} MINUTO(S)");
                }
                else if (horaInicial < horaFinal)
                {
                    duracaoJogoHoras = horaFinal - horaInicial;
                    if (horaInicial < horaFinal && minutoInicial > minutoFinal)
                    {
                        duracaoJogoHoras--;
                    }
                    System.Console.WriteLine($"O JOGO DUROU {duracaoJogoHoras} HORA(S) E {duracaoJogosMinutos} MINUTO(S)");
                }
                else
                {
                    duracaoJogoHoras = 24;
                    if (minutoInicial > minutoFinal)
                    {
                        duracaoJogoHoras--;
                    }
                    else if (minutoInicial < minutoFinal)
                    {
                        duracaoJogoHoras = 0;
                    }
                    System.Console.WriteLine($"O JOGO DUROU {duracaoJogoHoras} HORA(S) E {duracaoJogosMinutos} MINUTO(S)");
                }
                System.Console.WriteLine(valoresEsperados[i]);
                System.Console.WriteLine("-----------------");
            }
            */


        /*
        1046 - Tempo de Jogo
        https://www.beecrowd.com.br/judge/pt/problems/view/1046

        string[] valoresInseridos = Console.ReadLine().Split();
        int horaInicial = int.Parse(valoresInseridos[0]), horaFinal = int.Parse(valoresInseridos[1]), duracaoJogoHoras = 0;

        if (horaInicial > horaFinal)
        {
            duracaoJogoHoras = (24 -horaInicial) + horaFinal;
            System.Console.WriteLine($"O JOGO DUROU {duracaoJogoHoras} HORA(S)");
        }

        if (horaInicial == horaFinal)
        {
            System.Console.WriteLine("O JOGO DUROU 24 HORA(S)");
        }

        if (horaInicial < horaFinal)
        {   
            duracaoJogoHoras = horaFinal-horaInicial;
            System.Console.WriteLine($"O JOGO DUROU {duracaoJogoHoras} HORA(S)");
        }
        */


        /*
        1045 - Tipos de Triângulos
        https://www.beecrowd.com.br/judge/pt/problems/view/1045

        private static double[] OrdenarValoresDecrescente(string[] valores)
            {
                string[] valoresOriginais = valores;
                double[] valoresOrdenados = new double[3];
                double valorA, valorB, valorC, aux;

                valorA = double.Parse(valoresOriginais[0]);
                valorB = double.Parse(valoresOriginais[1]);
                valorC = double.Parse(valoresOriginais[2]);

                if (valorA > valorB)
                {
                    aux = valorB;
                    valorB = valorA;
                    valorA = aux;
                }

                if (valorB > valorC)
                {
                    aux = valorC;
                    valorC = valorB;
                    valorB = aux;
                    if (valorA > valorB)
                    {
                        aux = valorB;
                        valorB = valorA;
                        valorA = aux;
                    }
                }
                valoresOrdenados[0] = valorC;
                valoresOrdenados[1] = valorB;
                valoresOrdenados[2] = valorA;

                return valoresOrdenados;
            }

        private static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Replace(".", ",").Split();
            double[] valoresTriangulos = OrdenarValoresDecrescente(valores);
            double valorA, valorB, valorC;

            valorA = valoresTriangulos[0];
            valorB = valoresTriangulos[1];
            valorC = valoresTriangulos[2];


            if (valorA >= valorB + valorC)
            {
                System.Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(valorA, 2) > Math.Pow(valorB, 2) + Math.Pow(valorC, 2))
                {
                    System.Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
            }

            if ((valorA * valorA) == (valorB * valorB) + (valorC * valorC))
            {
                System.Console.WriteLine("TRIANGULO RETANGULO");
            }

            if ((valorA * valorA) < (valorB * valorB) + (valorC * valorC))
            {
                System.Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (valorA == valorB && valorA == valorC)
            {
                System.Console.WriteLine("TRIANGULO EQUILATERO");
            }

            if (((valorA == valorB || valorA == valorC) && (valorB != valorC)) || ((valorB == valorA || valorB == valorC)) && (valorA != valorC))
            {
                System.Console.WriteLine("TRIANGULO ISOSCELES");
            }
            */


        /*
        1044 - Múltiplos
        https://www.beecrowd.com.br/judge/pt/problems/view/1044

        string[] valoresInseridos = Console.ReadLine().Split();
        int valorA = int.Parse(valoresInseridos[0]);
        int valorB = int.Parse(valoresInseridos[1]);

        if (valorA % valorB == 0 || valorB % valorA == 0)
        {
            System.Console.WriteLine("Sao Multiplos");
        }
        else
        {
            System.Console.WriteLine("Nao sao Multiplos");
        }
        */


        /*
        1043 - Triângulo
        https://www.beecrowd.com.br/judge/pt/problems/view/1043

        private static double[] OrdenarValores(string[] valores)
        {
            string[] valoresOriginais = valores;
            double[] valoresOrdenados = new double[3];
            double valorA, valorB, valorC, aux;

            valorA = double.Parse(valoresOriginais[0]);
            valorB = double.Parse(valoresOriginais[1]);
            valorC = double.Parse(valoresOriginais[2]);

            if (valorA > valorB)
            {
                aux = valorB;
                valorB = valorA;
                valorA = aux;
            }

            if (valorB > valorC)
            {
                aux = valorC;
                valorC = valorB;
                valorB = aux;
                if (valorA > valorB)
                {
                    aux = valorB;
                    valorB = valorA;
                    valorA = aux;
                }
            }
            valoresOrdenados[0] = valorA;
            valoresOrdenados[1] = valorB;
            valoresOrdenados[2] = valorC;

            return valoresOrdenados;
        }

        private static void Main(string[] args)
        {
            string[] valoresInseridos = Console.ReadLine().Split();
            double[] valores = new double[3];

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = OrdenarValores(valoresInseridos)[i];
            }

            double valorA, valorB, valorC, perimetro, area;
            valorA = valores[0];
            valorB = valores[1];
            valorC = valores[2];

            if (valorA + valorB > valorC)
            {
                perimetro = valorA + valorB + valorC;
                System.Console.WriteLine($"Perimetro = {perimetro:F1}");
            }
            else
            {
                valorA = double.Parse(valoresInseridos[0]);
                valorB = double.Parse(valoresInseridos[1]);
                valorC = double.Parse(valoresInseridos[2]);

                area = ((valorA + valorB) * valorC) / 2;
                System.Console.WriteLine($"Area = {area:F1}");
            }
            */


        /*
        1042 - Sort Simples
        https://www.beecrowd.com.br/judge/pt/problems/view/1042

        string[] valoresOriginais = Console.ReadLine().Split();
        int[] valoresOrdenados = new int[3];
        int valorA, valorB, valorC, aux;

        valorA = int.Parse(valoresOriginais[0]);
        valorB = int.Parse(valoresOriginais[1]);
        valorC = int.Parse(valoresOriginais[2]);

        if (valorA > valorB)
        {
            aux = valorB;
            valorB = valorA;
            valorA = aux;
        }

        if (valorB > valorC)
        {
            aux = valorC;
            valorC = valorB;
            valorB = aux;

            if (valorA > valorB)
            {
                aux = valorB;
                valorB = valorA;
                valorA = aux;
            }

        }

        valoresOrdenados[0] = valorA;
        valoresOrdenados[1] = valorB;
        valoresOrdenados[2] = valorC;

        foreach (var valor in valoresOrdenados)
        {
            System.Console.WriteLine(valor);
        }

        System.Console.WriteLine();

        foreach (var numero in valoresOriginais)
        {
            System.Console.WriteLine(numero);
        }
        */


        /*
        1041 - Coordenadas de um Ponto
        https://www.beecrowd.com.br/judge/pt/problems/view/1041

        string[] valoresInserido = Console.ReadLine().Split();

        double valorX = double.Parse(valoresInserido[0]);
        double valorY = double.Parse(valoresInserido[1]);

        if (valorX == 0 && valorY == 0)
        {
            System.Console.WriteLine("Origem");
        }
        else if (valorX == 0 && valorY != 0)
        {
            System.Console.WriteLine("Eixo Y");
        }
        else if (valorX != 0 && valorY == 0)
        {
            System.Console.WriteLine("Eixo X");
        }
        else if (valorX > 0 && valorY > 0)
        {
            System.Console.WriteLine("Q1");
        }
        else if (valorX < 0 && valorY > 0)
        {
            System.Console.WriteLine("Q2");
        }
        else if (valorX < 0 && valorY < 0)
        {
            System.Console.WriteLine("Q3");
        }
        else
        {
            System.Console.WriteLine("Q4");
        }
        */


        /*        
        1040 - Média 3
        https://www.beecrowd.com.br/judge/pt/problems/view/1040

        double nota1, nota2, nota3, nota4;
        string[] valorInserido = Console.ReadLine().Split();

        nota1 = double.Parse(valorInserido[0]);
        nota2 = double.Parse(valorInserido[1]);
        nota3 = double.Parse(valorInserido[2]);
        nota4 = double.Parse(valorInserido[3]);

        double media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 4) + (nota4 * 1)) / 10;
        media = Math.Round(media, 1);

        System.Console.WriteLine($"Media: {media:F1}");

        if (media >= 7)
        {
            System.Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5)
        {
            System.Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            System.Console.WriteLine("Aluno em exame.");
            double notaExame = double.Parse(Console.ReadLine());
            notaExame = Math.Round(notaExame, 1);
            System.Console.WriteLine($"Nota do exame: {notaExame:F1}");
            media = (media + notaExame) / 2;
            media = Math.Round(notaExame, 1);
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
        */


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
