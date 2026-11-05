namespace PracticaalgoritmosDeordenamientos.entities;

public class Inventory
{
    public decimal[] Prices;

    public Inventory(decimal[] prices)
    {
        Prices = prices;
    }

    // Ordenar precios de menor a mayor mediante Selection Sort.
    public void SelectionSort()
    {
        int comparisons = 0;
        int swaps = 0;

        Console.WriteLine("=== SELECTION SORT ===");

        Console.WriteLine("\nPrecios iniciales:");
        PrintPrices();

        // Recorrer el arreglo buscando el mínimo.
        for (int i = 0; i < Prices.Length - 1; i++)
        {
            // Suponer que el elemento actual es el mínimo.
            int minIndex = i;

            // Buscar el menor precio en el resto del arreglo.
            for (int j = i + 1; j < Prices.Length; j++)
            {
                comparisons++;

                if (Prices[j] < Prices[minIndex])
                {
                    minIndex = j;
                }
            }

            Console.WriteLine($"\n--- Iteración {i + 1} ---");
            Console.WriteLine($"Índice de selección mínima: {minIndex}");
            Console.WriteLine($"Precio mínimo: RD${Prices[minIndex]}");

            // Intercambiar el mínimo con la posición actual.
            if (minIndex != i)
            {
                (Prices[i], Prices[minIndex]) =
                    (Prices[minIndex], Prices[i]);

                swaps++;

                Console.WriteLine("Intercambio realizado.");
            }
            else
            {
                Console.WriteLine("No se requiere intercambio.");
            }

            // Mostrar el arreglo después de cada iteración.
            PrintPrices();
        }

        // Mostrar métricas finales.
        Console.WriteLine("\n=== RESULTADOS ===");
        Console.WriteLine($"Comparaciones: {comparisons}");
        Console.WriteLine($"Intercambios: {swaps}");

        Console.WriteLine("\nInventario ordenado:");
        PrintPrices();
    }

    // Mostrar los precios del inventario.
    private void PrintPrices()
    {
        foreach (decimal price in Prices)
        {
            Console.Write($"[RD${price}] ");
        }

        Console.WriteLine();
    }
}