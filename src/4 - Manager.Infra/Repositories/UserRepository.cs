using System;
using System.Linq;
using System.Threading.Tasks;
using Manager.Infra.Interfaces;
using Manager.Infra.Context;
using Manager.Domain.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Manager.Infra.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly ManagerContext _context;

        public UserRepository(ManagerContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> GetByEmail(string email)
        {
            var user = await _context.Users
                                       .Where
                                       (
                                           x =>
                                           x.Email.ToLower() == email.ToLower()
                                       )
                                       .AsNoTracking()
                                       .ToListAsync();

            return user.FirstOrDefault();
        }

        public async Task<List<User>> SearchByEmail(string email)
        {
            var allUsers = await _context.Users
                                    .Where
                                    (
                                        x =>
                                           x.Email.ToLower().Contains(email.ToLower())
                                    )
                                    .AsNoTracking()
                                    .ToListAsync();

            return allUsers;
        }

        public async Task<List<User>> SearchByNome(string nome)
        {
            var allUsers = await _context.Users
                                    .Where
                                    (
                                        x =>
                                           x.Nome.ToLower().Contains(nome.ToLower())
                                    )
                                    .AsNoTracking()
                                    .ToListAsync();

            return allUsers;
        }


    }
}