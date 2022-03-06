using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class BlogRepository : IBlog
    {
        Context db = new Context();
        public void AddBlog(Blog blog)
        {
            db.Add(blog);
            db.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            db.Remove(blog);
            db.SaveChanges();
        }

        public Blog GetById(int id)
        {
            return db.Blogs.Find(id);
        }

        public List<Blog> ListAllBlog()
        {
            return db.Blogs.ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            db.Update(blog);
            db.SaveChanges();
        }
    }
}
