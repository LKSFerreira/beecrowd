int result = Fibonacci(5);
Console.WriteLine($"{result}");

int Fibonacci(int numero)
{
   int penultimoNumero = 0;
   int ultimoNumero = 1;
   int somaDosNumeros = 0;

   for (int i = 2; i < numero; i++)
   {
        somaDosNumeros = penultimoNumero + ultimoNumero;
        penultimoNumero = ultimoNumero;
        ultimoNumero = somaDosNumeros;
   }

   return somaDosNumeros;
}

