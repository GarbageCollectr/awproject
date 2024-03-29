﻿using awprojectdata;
using awprojectmodels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace awprojectrepositories
{
    public class StatesRepository : IStatesRepository
    {
        private AwProjectDbContext _context;

        public StatesRepository(AwProjectDbContext context)
        {
            _context = context;
        }
        public async Task<IList<State>> GetAllAsync()
        {
            var states = await _context.States.AsNoTracking().ToListAsync();
            return states;
            
        }

        public async Task<State?> GetAsync(int id)
        {
            var state = await _context.States.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            return state;
        }

        public async Task<int> AddOrUpdateAsync(State state)
        {
            if(state.Id > 0)
            {
                return await Update(state);
            }
            return await Insert(state);
        }
        private async Task<int> Insert(State state)
        {
            await _context.States.AddAsync(state);
            await _context.SaveChangesAsync();
            return state.Id;
        }

        private async Task<int> Update(State state)
        {
            var existingState = await _context.States.FirstOrDefaultAsync(x => x.Id == state.Id);
            if (existingState is null) throw new Exception("State not found");

            existingState.Abbreviation = state.Abbreviation;
            existingState.Name = state.Name;

            
            await _context.SaveChangesAsync();
            return state.Id;
        }

        public async Task<int> DeleteAsync(State state)
        {
            return await DeleteAsync(state.Id);
        }

        public async Task<int> DeleteAsync(int id)
        {
            var existingState = await _context.States.FirstOrDefaultAsync(x => x.Id == id);
            if (existingState is null) throw new Exception("Could not delete State due to unable to find");

            await Task.Run(() => { _context.States.Remove(existingState); });

            await _context.SaveChangesAsync();
            return id;
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.States.AnyAsync(x => x.Id == id);
        }
    }
}
