using Microsoft.AspNetCore.Mvc;
using ASPProject.Models;
using System.Collections.Generic;
using System.Linq;

public class HomeController : Controller
{
          private readonly List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "Riding to Music", Author = "J.A Allen", Description = "This book focuses on the integration of music with equestrian riding, offering insights into how riders can enhance their performances by aligning their movements with music, especially in disciplines like dressage.", Price = 9.99m, ImageUrl = "https://covers.openlibrary.org/b/id/8234731-L.jpg" },
            new Book { Id = 2, Title = "1984", Author = "George Orwell", Description = "A dystopian novel about a totalitarian regime.", Price = 12.99m, ImageUrl = "https://covers.openlibrary.org/b/id/7222246-L.jpg" },
            new Book { Id = 3, Title = "I'll be Seeing You", Author = "Diane Castell", Description = "I'll Be Seeing You by Diane Castell is a contemporary romance novel. It revolves around the story of Sarah Ferguson, a woman who has suffered a tragic loss and is dealing with the emotional aftermath. The novel explores themes of grief, healing, and the complexities of relationships as Sarah navigates her personal struggles.As she starts to find a way to move forward, Sarah crosses paths with a man who helps her rediscover love and hope. The story delves into her emotional journey and the new opportunities that arise for her to find happiness again, despite the pain she has endured."
            , Price = 10.99m, ImageUrl = "https://covers.openlibrary.org/b/id/8229450-L.jpg" },
            new Book { Id = 4, Title = "Rocks and Minerals", Author = "Pat Bell, David Wright", Description = "Macmillan Field Guide to Rocks and Minerals by Pat Well and David Wright is a comprehensive guide for identifying and understanding various rocks and minerals, providing detailed descriptions, classifications, and visual references for enthusiasts and professionals alike.", Price = 8.99m, ImageUrl = "https://covers.openlibrary.org/b/id/8364329-L.jpg" },
            new Book { Id = 5, Title = "Estragia Nacional para la Converacion y el Desarrollo Sustentable del Territorio Insular Mexicano", Author = "Mexico", Description = "(National Strategy for the Conservation and Sustainable Development of the Mexican Insular Territories) is a comprehensive framework developed by the Mexican government, specifically the Ministry of Environment and Natural Resources (SEMARNAT), alongside other governmental and non-governmental organizations.", Price = 11.99m, ImageUrl = "https://covers.openlibrary.org/b/id/7225426-L.jpg" },
            new Book { Id = 6, Title = "Moby Dick", Author = "Herman Melville", Description = "A story of obsession and revenge, centered on a giant white whale.", Price = 13.99m, ImageUrl = "https://tse4.mm.bing.net/th?id=OIP.6ae-geadYhG-pOWvDafNIgHaKs&w=474&h=474&c=7" },
            new Book { Id = 7, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Description = "A novel about teenage angst and alienation.", Price = 7.99m, ImageUrl = "https://covers.openlibrary.org/b/id/7984916-L.jpg" },
            new Book { Id = 8, Title = "Brave New World", Author = "Aldous Huxley", Description = "A dystopian novel set in a technologically advanced society.", Price = 12.49m, ImageUrl = "https://covers.openlibrary.org/b/id/8265447-L.jpg" },
        };

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult MyView()
    {
        return View(books); 
    }

    public IActionResult Details(int id)
    {
         if (books == null)
            {
                return NotFound("Books list is empty.");
            }

            // Try to find the book by id
            var book = books.FirstOrDefault(b => b.Id == id);

            // Check if book is found
            if (book == null)
            {
                return NotFound($"Book with ID {id} not found.");
            }

            // Return the view with the book details
            return View(book);
    }
}
