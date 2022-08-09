using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace MyBooksApp.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Model.Book()
                    {
                        Title = "1st Book Title",
                        Description = "1st Book Created",
                        isRead = true,
                        Rate = 4,
                        Genre = "Horror",
                        Author = "First Author",
                        CoverURL = "https....",
                        DateAdded = System.DateTime.Now
                    },
                    new Model.Book()
                    {
                        Title = "2nd Book Title",
                        Description = "2nd Book Created",
                        isRead = false,
                        Genre = "Horror",
                        Author = "First Author",
                        CoverURL = "https....",
                        DateAdded = System.DateTime.Now
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
