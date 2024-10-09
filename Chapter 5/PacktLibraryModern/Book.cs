namespace Packt.Shared;
using System.Diagnostics.CodeAnalysis;
public class Book
{
    public required string? Isbn { get; set; }
    public required string? Title { get; set; }
    public string? Author { get; set; }
    public int PageCount { get; set; }

    public Book() { }

    [SetsRequiredMembers]
    public Book(string? isbn, string? title)
    {
        Isbn = isbn;
        Title = title;
    }
}

