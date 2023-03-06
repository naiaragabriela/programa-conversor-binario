int valor, resto, quociente;

int[] binario = new int[8];
int[] convertido = new int[8];

Console.WriteLine("Informe um número inteiro a ser convertido");
valor = int.Parse(Console.ReadLine());

convertido = converter(valor);
int[] converter (int valor)
{
    quociente = valor;
    for (int i = 0; i < binario.Length; i++)
    {
        resto = quociente % 2;
        binario[i] = resto;
        quociente = valor / 2;
        valor = quociente;
    }
    return binario;
}
 for (int i = binario.Length -1; i>= 0; i--)
{
    Console.Write(binario[i] + " ");
}