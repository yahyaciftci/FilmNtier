﻿using DAL;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class CategoryRepository : IFilmBox<CategoryCs>
    {
        FilmBox_DbEntities db = Db_Tools.DbInstance;
        public void Delete(int id)
        {
           Category gelen= db.Categories.Find(id);
            db.Categories.Remove(gelen);
            db.SaveChanges();

        }

        public List<CategoryCs> GetAll()
        {
            return db.Categories.Select(c => new CategoryCs { CategoryId = c.CategoryId, Genre = c.Genre, NumberOfFilm = (int)c.NumberOfFilm }).ToList();
        }

        public CategoryCs GetByID(int ID)
        {
            Category gelen= db.Categories.Find(ID);
            return new CategoryCs { CategoryId = gelen.CategoryId, Genre = gelen.Genre, NumberOfFilm = (int)gelen.NumberOfFilm };
        }

        public void Insert(CategoryCs item)
        {
            db.Categories.Add(new Category { Genre = item.Genre, NumberOfFilm = item.NumberOfFilm });
            db.SaveChanges();
        }

        public void Update(CategoryCs item)
        {
            Category gelen= db.Categories.Find(item.CategoryId);
            gelen.Genre = item.Genre;
            gelen.NumberOfFilm = item.NumberOfFilm;
            db.SaveChanges();
            
        }
    }
}
