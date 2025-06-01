using BlogEf.Data;
using BlogEf.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEf;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            using (var context = new BlogDataContext())
            {
                // var user = new User{ Name = "Vinicim", Slug = "vini-ma", Bio = "student developer", Email = "vinicim@gmail.com", Image = "https", PasswordHash = "123456789"};
                // var category = new Category { Name = "Backend", Slug = "backend" };
                // var post = new Post
                // {
                //     Author = user, Category = category, Body = "<p>Hello world<p>", Slug = "comecando-com-ef-core", Summary = "aprendendo ef core",
                //     Title = "Comecando ef core", CreateDate = DateTime.Now, LastUpdateDate = DateTime.Now};
                // context.Posts.Add(post);
                // context.SaveChanges();
                var posts = context.Posts.AsNoTracking().OrderByDescending(x => x.LastUpdateDate).ToList();
                foreach (var post in posts)
                {
                    Console.WriteLine($"{post.Title} ({post.Author?.Name})");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
