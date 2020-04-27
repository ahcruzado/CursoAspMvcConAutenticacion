using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EfCodeFirst.Models
{
    public class BlogContext:DbContext
    {

        public BlogContext():base(EfCodeFirst.Properties.Settings.Default.BlogPostConnectionString)
        {

        }
        public DbSet<BlogPost>BlogPosts{ get; set; }
        public DbSet<Comentario> Comentarios { get; set; }

    }
}