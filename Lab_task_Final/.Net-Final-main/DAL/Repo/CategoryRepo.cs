using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class CategoryRepo : IRepository<Category,int>
    {
        News_portalEntities db;

        public CategoryRepo(News_portalEntities db)
        {
            this.db = db;
        }

        public void Add(Category e)
        {
            db.Categories.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.Categories.FirstOrDefault(e => e.id == id);
            db.Categories.Remove(s);
            db.SaveChanges();
        }

        public void Edit(Category e)
        {
            var s = db.Categories.FirstOrDefault(en => en.id == e.id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Category> Get()
        {
            return db.Categories.ToList();
        }

        public Category Get(int id)
        {
            return db.Categories.FirstOrDefault(e => e.id == id);
        }
    }
}
