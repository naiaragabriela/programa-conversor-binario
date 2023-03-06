int numero, resto;

int[] binario = new int[8];

int numeroDigitado()
{
    Console.WriteLine("Informe um número: ");
    return int.Parse(Console.ReadLine()); 
}
numero = numeroDigitado();

int converterBinario()
{
    resto = numero % 2;
    numero = numero / 2;
    return resto;
}

int contador = 7;
do
{
    binario[contador] = converterBinario();
    contador--;
} while (contador >= 0);


for (int posicao = 0; posicao < 8; posicao++)
{
    Console.Write(binario[posicao] + " ");
}