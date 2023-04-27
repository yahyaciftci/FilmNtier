using DAL;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class SeriesDirectorDetailRepository : IFilmBox<SeriesDirectorDetailCs>
    {
        FilmBox_DbEntities db = Db_Tools.DbInstance;
        public void Delete(int id)
        {
           SeriesDirectorDetail gelen= db.SeriesDirectorDetails.Find(id);
            db.SeriesDirectorDetails.Remove(gelen);
            db.SaveChanges();
        }

        public List<SeriesDirectorDetailCs> GetAll()
        {
            return db.SeriesDirectorDetails.Select(c=> new SeriesDirectorDetailCs {SeriesDirectorDetailID=c.SeriesDirectorDetailID,SeriesId=c.SeriesId,DirectorId=c.DirectorId,DirectorRate=(int)c.DirectorRate }).ToList();
        }

        public SeriesDirectorDetailCs GetByID(int ID)
        {
           SeriesDirectorDetail gelen= db.SeriesDirectorDetails.Find(ID);
            return new SeriesDirectorDetailCs { SeriesDirectorDetailID = gelen.SeriesDirectorDetailID, SeriesId = gelen.SeriesId, DirectorId = gelen.DirectorId, DirectorRate = (int)gelen.DirectorRate };
        }

        public void Insert(SeriesDirectorDetailCs item)
        {
            db.SeriesDirectorDetails.Add(new SeriesDirectorDetail { SeriesId = item.SeriesId, DirectorId = item.DirectorId, DirectorRate = item.DirectorRate });
            db.SaveChanges();
        }

        public void Update(SeriesDirectorDetailCs item)
        {
            SeriesDirectorDetail gelen = db.SeriesDirectorDetails.Find(item.SeriesDirectorDetailID);
            gelen.SeriesId = item.SeriesId; gelen.DirectorId = item.DirectorId; gelen.DirectorRate = item.DirectorRate;
            db.SaveChanges();
        }
    }
}
