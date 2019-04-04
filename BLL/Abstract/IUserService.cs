using ENTITIES;
using System.Collections.Generic;

namespace BLL.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User Add(User entity);
        User Update(User entity);
        User Delete(User entity);
        User GetById(int id);
    }
}
