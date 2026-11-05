using PracticaalgoritmosDeordenamientos.entities;

namespace PracticaalgoritmosDeordenamientos;

class Program
{
    static void Main(string[] args)
    {
        // Ejercicio 1: Bubble Sort - Ordenar libros.
        Console.WriteLine("\n========== EJERCICIO 1: BUBBLE SORT ==========");
        
        var library = new Library(15);
        
        library.AddTestBooks();
        library.OrderBooks();


        // Ejercicio 2: Selection Sort - Ordenar precios.
        Console.WriteLine("\n========== EJERCICIO 2: SELECTION SORT ==========");
        
        decimal[] prices = { 250, 120, 75, 300, 100, 180, 90, 220 };
        
        var inventory = new Inventory(prices);
        
        inventory.SelectionSort();
        
        
        // // Ejercicio 3: Insertion Sort - Ordenar tiempos.
        Console.WriteLine("\n========== EJERCICIO 3: INSERTION SORT ==========");
        
        int[] times = { 58, 54, 60, 52, 57, 56, 59 };
        
        var race = new Race(times);
        
        race.InsertionSort();
        
        Console.WriteLine("\n========== FIN DE LOS EJERCICIOS ==========");
    }
}