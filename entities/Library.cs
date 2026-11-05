namespace PracticaalgoritmosDeordenamientos.entities;

public class Library
{
    public Book[] Books;
    private int lastInsert;

    public Library(int capacity)
    {
        Books = new Book[capacity];
        lastInsert = 0;
    }
    
    public void AddTestBooks()
    {
        Add(Book.Builder(1, "George Orwell", "1984"));
        Add(Book.Builder(2, "J.R.R. Tolkien", "El Hobbit"));
        Add(Book.Builder(3, "Gabriel García Márquez", "Cien años de soledad"));
        // Add(Book.Builder(4, "Miguel de Cervantes", "Don Quijote"));
        // Add(Book.Builder(5, "Antoine de Saint-Exupéry", "El principito"));
        // Add(Book.Builder(6, "Jane Austen", "Orgullo y prejuicio"));
        // Add(Book.Builder(7, "Paulo Coelho", "El alquimista"));
        // Add(Book.Builder(8, "Mary Shelley", "Frankenstein"));
        // Add(Book.Builder(9, "Fiódor Dostoyevski", "Crimen y castigo"));
        // Add(Book.Builder(10, "Julio Verne", "Viaje al centro de la Tierra"));
        lastInsert = 3;
        Console.WriteLine("Se agregaron 10 libros de prueba.");
    }
    
    // Agregar libros a la biblioteca.
    public void AddBook()
    {
        Console.WriteLine("Agregar libros");
        Console.WriteLine("Cantidad de libros a insertar: ");

        int total = int.Parse(Console.ReadLine()!);

        // Validar la capacidad disponible.
        if (total < 0 || total > Books.Length - lastInsert)
        {
            Console.WriteLine("Cantidad inválida o capacidad insuficiente.");
            return;
        }

        for (int i = 0; i < total; i++)
        {
            Console.WriteLine("Id: ");
            int id = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Author: ");
            string author = Console.ReadLine() ?? "";

            Console.WriteLine("Título: ");
            string title = Console.ReadLine() ?? "";

            Book book = Book.Builder(id, author, title);

            Add(book);
        }
    }

    // Insertar un libro en la siguiente posición disponible.
    private void Add(Book book)
    {
        if (lastInsert < Books.Length)
        {
            Books[lastInsert] = book;
            lastInsert++;
        }
    }

    // Ordenar los libros alfabéticamente mediante Bubble Sort.
    public void OrderBooks()
    {
        int comparisons = 0;
        int swaps = 0;

        Console.WriteLine("\n=== BUBBLE SORT ===");

        Console.WriteLine("\nArreglo inicial:");
        PrintBooks();

        // Controlar las pasadas del algoritmo.
        for (int i = 0; i < lastInsert - 1; i++)
        {
            Console.WriteLine($"\n--- Pasada {i + 1} ---");

            bool swapped = false;

            // Comparar elementos consecutivos.
            for (int j = 0; j < lastInsert - 1 - i; j++)
            {
                comparisons++;

                Console.WriteLine(
                    $"\nComparando: {Books[j].Title} <-> {Books[j + 1].Title}");

                // Comparar títulos ignorando mayúsculas y minúsculas.
                if (string.Compare(
                    Books[j].Title,
                    Books[j + 1].Title,
                    StringComparison.OrdinalIgnoreCase) > 0)
                {
                    // Intercambiar libros mediante una tupla.
                    (Books[j], Books[j + 1]) =
                        (Books[j + 1], Books[j]);

                    swaps++;
                    swapped = true;

                    Console.WriteLine("Intercambio realizado.");
                }
                else
                {
                    Console.WriteLine("No se requiere intercambio.");
                }

                // Mostrar el arreglo después de cada comparación.
                PrintBooks();
            }

            // Optimización: detener si no hubo intercambios.
            if (!swapped)
            {
                Console.WriteLine("\nEl arreglo ya está ordenado.");
                break;
            }
        }

        // Mostrar las métricas finales.
        Console.WriteLine("\n=== RESULTADOS ===");
        Console.WriteLine($"Comparaciones: {comparisons}");
        Console.WriteLine($"Intercambios: {swaps}");

        Console.WriteLine("\nArreglo ordenado:");
        PrintBooks();
    }

    // Mostrar los títulos de los libros existentes.
    private void PrintBooks()
    {
        for (int i = 0; i < lastInsert; i++)
        {
            Console.Write($"[{Books[i].Title}] ");
        }
        Console.WriteLine();
    }
}
