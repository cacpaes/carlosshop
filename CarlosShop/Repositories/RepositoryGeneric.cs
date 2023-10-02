﻿using CarlosShop.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CarlosShop.Repositories
{
    public class RepositoryGeneric<T> where T : class
    {

        private readonly DbContextOptions<ContextBase> _optionBuilder;
        public RepositoryGeneric()
        {
            _optionBuilder = new DbContextOptions<ContextBase>();
        }

        public async Task Create(T objectEntry)
        {
            using var data = new ContextBase(_optionBuilder);
            await data.Set<T>().AddAsync(objectEntry);
            await data.SaveChangesAsync();
        }

        public async Task Update(T objectEntry)
        {
            using var data = new ContextBase(_optionBuilder);
            data.Set<T>().Update(objectEntry);
            await data.SaveChangesAsync();
        }

        public async Task Delete(T objectEntry)
        {
            using var data = new ContextBase(_optionBuilder);
            data.Set<T>().Remove(objectEntry);
            await data.SaveChangesAsync();
        }

        public async Task<List<T>> List()
        {
            using var data = new ContextBase(_optionBuilder);
            return await data.Set<T>().AsNoTracking().ToListAsync();
        }


        public async Task<T?> GetById(int id)
        {
            using var data = new ContextBase(_optionBuilder);
            return await data.Set<T>().FindAsync(id);
        }

    }
}
