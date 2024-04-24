int[] arrayOriginal = new int[6];
int[] arrayOrdenado;
int aux;
Random random = new Random();

for (int i = 0; i < 6; i++)
{
    arrayOriginal[i] = random.Next(1, 60);

}
arrayOrdenado = arrayOriginal;

for (int i = 0; i < 6; i++)
{
    for (int j = (i + 1); j < 6; j++)
    {
        if (arrayOrdenado[i] != arrayOrdenado[j])
        {
            if (arrayOrdenado[i] > arrayOrdenado[j])
            {
                aux = arrayOrdenado[j];
                arrayOrdenado[j] = arrayOrdenado[i];
                arrayOrdenado[i] = aux;
            }
        }
        else
        {
            arrayOrdenado[j] = 0;
            if (arrayOrdenado[j] == 0)
            {

            }
        }
    }
}


for (int i = 0; i < 6; i++)
{
    Console.Write(arrayOrdenado[i] + " ");
}
Console.WriteLine();