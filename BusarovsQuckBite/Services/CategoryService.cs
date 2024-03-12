﻿using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data;
using BusarovsQuckBite.Models;
using Microsoft.EntityFrameworkCore;

namespace BusarovsQuckBite.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<CategoryViewModel>> GetCategoriesForUserByStatusAsync(string? keyword = "")
        {
            var categories = await _context.Categories.Select(c => new CategoryViewModel()
            {
                Id = c.Id,
                Name = c.Name,
                TransactionDateAndTime = c.TransactionDateAndTime.ToString(DateFormatConstants.DefaultDateFormat),
                Creator = c.User.UserName,
                IsDeleted = c.IsDeleted,

            }).AsNoTracking().ToListAsync();
            switch (keyword)
            {
                case "Deleted":
                    categories = categories.Where(x => x.IsDeleted).ToList();
                    break;
                case "Active":
                    categories = categories.Where(x => !x.IsDeleted).ToList();
                    break;
            }
            return categories;
        }
        public async Task DeleteCategoryAsync(int id, string owner)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (category == null)
            {
                throw new InvalidOperationException(ErrorMessagesConstants.EntityNotFoundExceptionMessage);
            }
            if (category.Who != owner)
            {
                throw new InvalidOperationException(ErrorMessagesConstants.OwnerIsInvalid);
            }
            category.IsDeleted = !category.IsDeleted;
            await _context.SaveChangesAsync();
        }
    }
}