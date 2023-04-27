using DAL;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class FilmDirectorRepository : IFilmBox<FilmDirectorDetailCs>
    {
        FilmBox_DbEntities db = Db_Tools.DbInstance;
        public void Delete(int id)
        {
            FilmDirectorDetail gelen = db.FilmDirectorDetails.Find(id);
            db.FilmDirectorDetails.Remove(gelen);
            db.SaveChanges();
        }

        public List<FilmDirectorDetailCs> GetAll()
        {
            return db.FilmDirectorDetails.Select(c => new FilmDirectorDetailCs { FilmDirectorDetailID=c.FilmDirectorDetailID,FilmId=c.FilmId,DirectorId=c.DirectorId,DirectorRate=(int)c.DirectorRate}).ToList();
        }

        public FilmDirectorDetailCs GetByID(int ID)
        {
           FilmDirectorDetail gelen=  db.FilmDirectorDetails.Find(ID);
            return new FilmDirectorDetailCs { FilmDirectorDetailID = gelen.FilmDirectorDetailID, FilmId = gelen.FilmId, DirectorId = gelen.DirectorId, DirectorRate = (int)gelen.DirectorRate };
        }

        public void Insert(FilmDirectorDetailCs item)
        {
            db.FilmDirectorDetails.Add(new FilmDirectorDetail { FilmId = item.FilmId, DirectorId = item.DirectorId, DirectorRate = item.DirectorRate });
            db.SaveChanges();
        }

        public void Update(FilmDirectorDetailCs item)
        {
           FilmDirectorDetail gelen= db.FilmDirectorDetails.Find(item.FilmDirectorDetailID);
            gelen.FilmId = item.FilmId;
            gelen.DirectorId = item.DirectorId;
            gelen.DirectorRate = item.DirectorRate;
            db.SaveChanges();

        }
    }
}
