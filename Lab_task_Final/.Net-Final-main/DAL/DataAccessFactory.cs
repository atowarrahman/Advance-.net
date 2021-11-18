using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static News_portalEntities db;

        public DataAccessFactory()
        {
            db = new News_portalEntities();
        }

        public static IRepository<Category, int> CategoryDataAcees()
        {
            return new CategoryRepo(db);
        }
        public static IRepository<News, int> NewsDataAccess()
        {
            return new NewsRepo(db);
        }


    }
}
