int numero, resto, quociente;
int[] posicao = new int[8];

Console.WriteLine("Informe um número: ");
numero = int.Parse(Console.ReadLine());

int binario (int numero) 
{
    quociente = numero;

    if ( numero == 0)
    {
        return numero;
    }
    else
    {
        resto = quociente % 2;
        posicao[numero] = resto;
        quociente = numero;
        numero = quociente;

        return binario(numero - 1);
    }

}
Console.Write(binario(numero));