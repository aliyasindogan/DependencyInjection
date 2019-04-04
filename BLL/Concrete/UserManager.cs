using BLL.Abstract;
using DAL.Abstract;
using ENTITIES;
using System;
using System.Collections.Generic;

namespace BLL.Concrete
{
    public class UserManager : IUserService
    {
        private IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }
        public User Add(User entity)
        {
            throw new NotImplementedException();
        }

        public User Delete(User entity)
        {
            throw new NotImplementedException();
        }



        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
