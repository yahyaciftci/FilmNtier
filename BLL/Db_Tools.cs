using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Db_Tools
    {
        private static FilmBox_DbEntities _dbInstance;

        public static FilmBox_DbEntities DbInstance
        {
            get
            {
                if (_dbInstance==null)
                {
                    _dbInstance = new FilmBox_DbEntities();
                }
                return _dbInstance;
            }
       
        }

    }
}
