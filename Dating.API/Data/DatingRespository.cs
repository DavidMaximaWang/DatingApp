using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dating.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Dating.API.Data
{
    public class DatingRespository : IDatingRepository
    {
        private readonly DataContext _contex;
        public DatingRespository(DataContext contex)
        {
            _contex = contex;

        }
        public void Add<T>(T entity) where T : class
        {
            _contex.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _contex.Remove(entity);
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _contex.User.Include(p => p.Photos).FirstOrDefaultAsync(x => x.Id == id);
            return user;

        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _contex.User.Include(p => p.Photos).ToListAsync();
            return users;
        }

        public async Task<bool> SaveAll()
        {
            return await _contex.SaveChangesAsync() > 0;
        }
    }
}