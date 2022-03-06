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
    public class CommentRepository : IGenericDal<Comment>
    {
        Context db = new Context();
        public List<Comment> AllList()
        {
            return db.Comments.ToList();
        }

        public void Delete(Comment t)
        {
            db.Remove(t);
            db.SaveChanges();

        }

        public Comment GetByID(int id)
        {
            return db.Comments.Find(id);
        }

        public void Insert(Comment t)
        {
            db.Add(t);
            db.SaveChanges();
        }

        public void Update(Comment t)
        {
            db.Update(t);
            db.SaveChanges();
        }
    }
}
