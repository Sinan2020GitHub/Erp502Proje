using MyEverNote.DataAccessLayer;
using MyEverNote.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyeverNote.DataAccessLayer.EntityFramework
{
    public class RepositoryBase
    {
        //Singleton Pattern
        protected static DatabaseContext db;


        //lock için 
        private static object _lockSync = new object();

        protected RepositoryBase()
        {
            CreateContext();
        }

        private static void CreateContext()
        {
            if (db == null)
            {
                lock (_lockSync)
                {
                    if (db == null)
                    {
                        db = new DatabaseContext();
                    }
                }

            }
        }

    }
}
