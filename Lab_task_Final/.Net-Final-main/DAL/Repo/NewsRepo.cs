using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class NewsRepo : IRepository<News, int>
    {
        News_portalEntities db;

        public NewsRepo(News_portalEntities db)
        {
            this.db = db;
        }

        public void Add(News e)
        {
            db.News.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.News.FirstOrDefault(e => e.id == id);
            db.News.Remove(s);
            db.SaveChanges();
        }

        public void Edit(News e)
        {
            var s = db.News.FirstOrDefault(en => en.id == e.id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<News> Get()
        {
            return db.News.ToList();
        }

        public News Get(int id)
        {
            return db.News.FirstOrDefault(e => e.id == id);
        }
    }
}
