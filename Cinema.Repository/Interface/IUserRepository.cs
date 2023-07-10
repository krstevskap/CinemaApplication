using Cinema.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<CinemaAppUser> GetAll();
        CinemaAppUser Get(string id);
        void Insert(CinemaAppUser entity);
        void Update(CinemaAppUser entity);
        void Delete(CinemaAppUser entity);
    }
}
