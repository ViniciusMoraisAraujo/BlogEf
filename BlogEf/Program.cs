using BlogEf.Data;
using BlogEf.Models;

namespace BlogEf;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            using (var context = new BlogDataContext())
            {
                // var tag = new Tag { Name = "ASP.NET", Slug = "new"};
                // context.Tags.Add(tag);
                // context.SaveChanges();
                // context.Tags.Update(tag);
                // var tag = context.Tags.FirstOrDefault(t => t.Id == 1003); //obj que vem do banco
                // tag.Slug = "sla";
                // context.Update(tag);
                // context.SaveChanges();
                var tag = context.Tags.FirstOrDefault(t => t.Id == 1003);
                context.Remove(tag);
                context.SaveChanges();
                var tags = context.Tags.ToList();
                foreach (var abc in tags)
                {
                    Console.WriteLine(abc.Name + " - " + abc.Slug);
                }

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
