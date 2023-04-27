using DAL;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class FilmCategortDetailRepository : IFilmBox<FilmCategoryDetailCs>
    {
        FilmBox_DbEntities db = Db_Tools.DbInstance;
        public void Delete(int id)
        {
            FilmCategoryDetail gelen = db.FilmCategoryDetails.Find(id);
            db.FilmCategoryDetails.Remove(gelen);
            db.SaveChanges();

        }

        public List<FilmCategoryDetailCs> GetAll()
        {
            return db.FilmCategoryDetails.Select(c => new FilmCategoryDetailCs {FilmCategoryDetailID=c.FilmCategoryDetailID,FilmId=c.FilmId,CategoryId=c.CategoryId }).ToList();
        }

        public FilmCategoryDetailCs GetByID(int ID)
        {
            FilmCategoryDetail gelen= db.FilmCategoryDetails.Find(ID);
            return new FilmCategoryDetailCs { FilmCategoryDetailID = gelen.FilmCategoryDetailID, FilmId = gelen.FilmId, CategoryId = gelen.CategoryId };
        }

        public void Insert(FilmCategoryDetailCs item)
        {
            db.FilmCategoryDetails.Add(new FilmCategoryDetail { FilmId = item.FilmId, CategoryId = item.CategoryId });
            db.SaveChanges();
        }

        public void Update(FilmCategoryDetailCs item)
        {
            FilmCategoryDetail gelen = db.FilmCategoryDetails.Find(item.FilmCategoryDetailID);
            gelen.FilmId = item.FilmId;
            gelen.CategoryId = item.CategoryId;
            db.SaveChanges();

        }
    }
}
