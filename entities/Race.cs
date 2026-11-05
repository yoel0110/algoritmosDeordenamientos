namespace PracticaalgoritmosDeordenamientos.entities;

public class Race
{
    public int[] Times;

    public Race(int[] times)
    {
        Times = times;
    }

    // Ordenar tiempos mediante Insertion Sort.
    public void InsertionSort()
    {
        int comparisons = 0;
        int shifts = 0;

        Console.WriteLine("=== INSERTION SORT ===");

        Console.WriteLine("\nTiempos iniciales:");
        PrintTimes();

        // Recorrer los tiempos desde el segundo elemento.
        for (int i = 1; i < Times.Length; i++)
        {
            // Guardar el tiempo que se desea insertar.
            int currentTime = Times[i];

            // Última posición de la sección ordenada.
            int j = i - 1;

            Console.WriteLine($"\n--- Iteración {i} ---");
            Console.WriteLine($"Tiempo a insertar: {currentTime} segundos");

            // Desplazar los tiempos mayores hacia la derecha.
            while (j >= 0)
            {
                comparisons++;

                if (Times[j] > currentTime)
                {
                    Times[j + 1] = Times[j];
                    shifts++;

                    j--;
                }
                else
                {
                    break;
                }
            }

            // Insertar el tiempo en su posición correspondiente.
            Times[j + 1] = currentTime;

            Console.WriteLine($"Posición de inserción: {j + 1}");

            // Mostrar el arreglo después de cada inserción.
            PrintTimes();
        }

        // Mostrar métricas finales.
        Console.WriteLine("\n=== RESULTADOS ===");
        Console.WriteLine($"Comparaciones: {comparisons}");
        Console.WriteLine($"Desplazamientos: {shifts}");

        Console.WriteLine("\nTiempos ordenados:");
        PrintTimes();
    }

    // Mostrar los tiempos registrados.
    private void PrintTimes()
    {
        foreach (int time in Times)
        {
            Console.Write($"[{time}s] ");
        }

        Console.WriteLine();
    }
}
