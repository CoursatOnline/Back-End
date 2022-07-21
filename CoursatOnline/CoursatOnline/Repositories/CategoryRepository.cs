﻿using CoursatOnline.Data;
using CoursatOnline.Models;
using Microsoft.EntityFrameworkCore;

namespace CoursatOnline.Repositories
{
    public class CategoryRepository : IRepository<Category> , IRepositoryGetByName<Category>
    {
        CoursatOnlineDbContext db;
        public CategoryRepository(CoursatOnlineDbContext db)
        {
            this.db = db;
        }


        public int Create(Category category)
        {
            try
            {
                db.Add(category);
                int raw = db.SaveChanges();
                return raw;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }



        public int Delete(int id)
        {
            
            Category category = db.Category.FirstOrDefault(c => c.Id == id);
            if(category == null)
            {
                return -1;
            }
            else
                category.Show = false;
            
            try
            {
                int raws = db.SaveChanges();
                return raws;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public int Edit(int id, Category category)
        {
            
            
            Category oldCategory = db.Category.FirstOrDefault(c => c.Id == id); 
            if(category == null)
                return -1;

            //oldCategory.Id = category.Id;
            oldCategory.Name = category.Name;
            oldCategory.Image = category.Image;
            oldCategory.Show = category.Show;
            try
            {
                int raws = db.SaveChanges();
                return raws;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }



        public ICollection<Category> getAll()
        {
            
            List<Category> categories = db.Category.Where(c => c.Show == true).ToList();
            return categories;
        }

        public ICollection<Category> getAllByName(string word)
        {
           List<Category> categories =  db.Category.Where(c=>c.Show==true && c.Name.Contains(word)).ToList();
           return categories;
        }

        public Category getById(int id)
        {
            Category? category = db.Category.FirstOrDefault(c => c.Id == id);
            if (category.Show == false)
                return null;
            else
                return category;
        }

        public Category getByName(string name)
        {
            Category? category = db.Category.FirstOrDefault(c => c.Name == name && c.Show == true);
            return category;
        }
    }
}
