namespace PracticaalgoritmosDeordenamientos.entities;

public class Book
{
    public int Id { get; private set; }
    public string Title { get; private set; } = string.Empty;
    public string Author { get; private set; } = string.Empty;
    
    private Book(){ }

    public static Book Builder(int id, string title, string author)
    {
        return new Book() { Author = author, Id = id, Title = title };
    }

   
}