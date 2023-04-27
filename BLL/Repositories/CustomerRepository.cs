using DAL;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class CustomerRepository : IFilmBox<CustomerCs>
    {
        FilmBox_DbEntities db = Db_Tools.DbInstance;
        public void Delete(int id)
        {
            Customer gelen= db.Customers.Find(id);
            db.Customers.Remove(gelen);
            db.SaveChanges();
        }

        public List<CustomerCs> GetAll()
        {
            return db.Customers.Select(c => new CustomerCs { FirstName = c.FirstName, LastName = c.LastName, IdentityNo = c.IdentityNo, Gender = c.Gender, Age = (int)c.Age, PhoneNumer = c.PhoneNumer, Email = c.Email }).ToList();

        }

        public CustomerCs GetByID(int ID)
        {
            Customer gelen = db.Customers.Find(ID);
            return new CustomerCs { FirstName = gelen.FirstName, LastName = gelen.LastName, IdentityNo = gelen.IdentityNo, Gender = gelen.Gender, Age = (int)gelen.Age, PhoneNumer = gelen.PhoneNumer, Email = gelen.Email };
        }

        public void Insert(CustomerCs item)
        {
            db.Customers.Add(new Customer { FirstName = item.FirstName, LastName = item.LastName, IdentityNo = item.IdentityNo, Gender = item.Gender, Age = (int)item.Age, PhoneNumer = item.PhoneNumer, Email = item.Email });
            db.SaveChanges();
        }

        public void Update(CustomerCs item)
        {
            Customer gelen = db.Customers.Find(item.CustomerId);
            gelen.FirstName = item.FirstName;
            gelen.LastName = item.LastName;
            gelen.IdentityNo = item.IdentityNo;
            gelen.Gender = item.Gender; gelen.Age = (int)item.Age;
            gelen.PhoneNumer = item.PhoneNumer;
            gelen.Email = item.Email;
            db.SaveChanges();


        }
    }
}
