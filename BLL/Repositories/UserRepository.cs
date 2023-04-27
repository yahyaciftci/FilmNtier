using DAL;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UserRepository
    {
        FilmBox_DbEntities db = Db_Tools.DbInstance;
        public List<UsersDTO> GetAll()
        {
           return db.Users.Select(c => new UsersDTO { UserName = c.KullaniciAdi, Password = c.sifre }).ToList();
        }
        public void Delete(string id)
        {
            User gelen = db.Users.Find(id);
            db.Users.Remove(gelen);
            db.SaveChanges();
        }

        public UsersDTO GetByName(string kullanici)
        {
          User gelen=  db.Users.Find(kullanici);
            return new UsersDTO { UserName = gelen.KullaniciAdi,Password=gelen.sifre };

        }

        public void Insert(UsersDTO item)
        {
            db.Users.Add(new User { KullaniciAdi = item.UserName, sifre = item.Password});
            db.SaveChanges();
        }

        public void Update(UsersDTO item)
        {
            User gelen = db.Users.Find(item.UserName);
            gelen.sifre = item.Password;
            db.SaveChanges();
        }
    }
}
