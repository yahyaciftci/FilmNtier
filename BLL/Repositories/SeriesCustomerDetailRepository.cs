using DAL;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class SeriesCustomerDetailRepository : IFilmBox<SeriesCustomerDetailCs>
    {
        FilmBox_DbEntities db = Db_Tools.DbInstance;
        public void Delete(int id)
        {
            SeriesCustomerDetail gelen= db.SeriesCustomerDetails.Find(id);
            db.SeriesCustomerDetails.Remove(gelen);
            db.SaveChanges();
        }

        public List<SeriesCustomerDetailCs> GetAll()
        {
            return db.SeriesCustomerDetails.Select(c=> new SeriesCustomerDetailCs { SeriesCustomerDetailID = c.SeriesCustomerDetailID,SeriesId = c.SeriesId,CustomerId=c.CustomerId }).ToList();
        }

        public SeriesCustomerDetailCs GetByID(int ID)
        {
           SeriesCustomerDetail gelen= db.SeriesCustomerDetails.Find(ID);
            return new SeriesCustomerDetailCs { SeriesCustomerDetailID = gelen.SeriesCustomerDetailID, SeriesId = gelen.SeriesId, CustomerId = gelen.CustomerId };
        }

        public void Insert(SeriesCustomerDetailCs item)
        {
            db.SeriesCustomerDetails.Add(new SeriesCustomerDetail { SeriesId = item.SeriesId, CustomerId = item.CustomerId });
            db.SaveChanges();
        }

        public void Update(SeriesCustomerDetailCs item)
        {
            SeriesCustomerDetail gelen= db.SeriesCustomerDetails.Find(item.SeriesCustomerDetailID);
            gelen.SeriesId = item.SeriesId;
            gelen.CustomerId = item.CustomerId;
            db.SaveChanges();
        }
    }
}
